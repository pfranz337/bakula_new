/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 11.9.2015
 * Time: 9:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace franz
{
	/// <summary>
	/// Description of DataMining.
	/// </summary>
	public partial class DataMining : Form
	{
		//stop kriteria
		const int MIN_POCET_ZAZNAMU = 0;
		const int MIN_POCET_TRID_PRED_A = 1;
		
		char[] splitter = {';', ','};			//podle ceho ma tvorit tabulku
		
		List<List<Uzel>> strom = new List<List<Uzel>>();		//postupny vyvoj rozhodovaciho stromu
		List<Uzel> uzlyVKrocich = new List<Uzel>();				//uzly vznikle v jednotlivych krosich	
		int start = 0;
		int x = 0, y = 25;
		
		public DataMining()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			algoritmy.SelectedIndex=0;		//vybrani prvniho itemu v combu
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//getter pro cely strom
		public List<List<Uzel>> Strom {
			get {
				return strom;
			}
		}
		//pomocny list pro kazdy krok algoritmu pred dalsim krokem se ulozi do stromu :)		
		public List<Uzel> UzlyVKrocich {
			get {
				return uzlyVKrocich;
			}
		}

		//metoda pro otevreni a nacteni dat ze souboru - data se ukladaji do prvni tabulky v uzlu typu Uzel 
		int klikOpen = 0;	//kontrola pro opetvne kliknuti na open
		void openClick(object sender, EventArgs e)
		{
			krok.Enabled = true;
			spust.Enabled = true;
			klikOpen++;
			if (klikOpen > 1){	//pokud uz bylo kliknuto vse nastav do default
				panel1.Controls.Clear(); vypocty.Items.Clear(); prediktori.Items.Clear(); pred_atribut.Items.Clear(); sloupceTab.Items.Clear(); 
				algoritmy.Enabled = true;
				klikOpen=1; setCil.Enabled = true;
				strom = new List<List<Uzel>>();
				uzlyVKrocich = new List<Uzel>();
				start = 0; x = 0; y = 25; 
			}
			var main = new DataTable();						//vstupni tabulka		
			
			openFile.Filter = "CSV Files (.csv)|*.csv";	//filter hodnot pro cteni souboru
			openFile.ShowDialog();
			string path = openFile.FileName;
			var sr = new StreamReader(path, Encoding.Default);
			string s = sr.ReadLine();
			string []hlavicka = s.Split(splitter);
			sloupceTab.Items.AddRange(hlavicka);		//pridani atributu do listboxu pro uvodni vyber
			
			//plneni vstupni tabulky
			var cols = new DataColumn[hlavicka.Length];
			for (int i = 0, hlavickaLength = hlavicka.Length; i < hlavickaLength; i++) {
				string name = hlavicka[i];
				cols[i] = new DataColumn(name);
			}
			main.Columns.AddRange(cols);
			while ((s = sr.ReadLine()) != null) {
			
				string []row = s.Split(splitter);
				main.Rows.Add(row);
			}										
			
			//vytvoreni prvniho uzlu ve stromu	
			var u = new Uzel();
			u.Design.Data = main;
			uzlyVKrocich.Add(u);
			strom.Add(uzlyVKrocich);
			panel1.Controls.Add(u.Design.UzelB);
				
			sr.Close();
			itemDolu.Enabled = true;
			predNahoru.Enabled = true;
		}	
		//metody pro prohazovani itemu mezi listboxy --- START
		void addToPrediktori(object sender, EventArgs e)
		{
			prohazujItem(sloupceTab, prediktori);
		}
		
		void retPredikToSloupce(object sender, EventArgs e)
		{
			prohazujItem(prediktori, sloupceTab);
		}
		
		void retPredikAtrToAtribut(object sender, EventArgs e)
		{
			prohazujItem(pred_atribut, sloupceTab);
			setCil.Enabled = true;
			cilNahoru.Enabled = false;
		}
		
		private void prohazujItem(ListBox from, ListBox to){
			var copy = new object[from.SelectedItems.Count];
			from.SelectedItems.CopyTo(copy, 0);
			foreach(object item in copy){
				to.Items.Add(item);
				from.Items.Remove(item);			
			}
		}
		
		void SetCilClick(object sender, EventArgs e)
		{
			prohazujItem(sloupceTab, pred_atribut);
			setCil.Enabled = false;
			cilNahoru.Enabled = true;
		}
		//metody pro prohazovani itemu mezi listboxy --- END
		
		//naplneni prvniho uzlu
		private void firstSetUzel(){
			var pom = new List<Prediktor>();
			foreach (string s in prediktori.Items)
				pom.Add(new Prediktor {
					Name = s,
					Enable = true
				});
			strom[0][0].Prediktori.AddRange(pom.ToArray());			
			strom[0][0].PredikovanyAtribut = new Prediktor 
				{Enable = true, Name = pred_atribut.Items[0].ToString()};
			
		}
		
		//krokovani		
		void KrokClick(object sender, EventArgs e)
		{
			spust.Enabled = false;
			algoritmy.Enabled = false;
			if (start == 0){ firstSetUzel(); start++; }
			List<Uzel> uzly = strom[strom.Count - 1];
			projdi(uzly);
		}
		
		//spusteni
		void SpustClick(object sender, EventArgs e)
		{
			run();
		}
		
		//metoda pro automaticke prochazeni
		private void run(){
			krok.Enabled = false;
			spust.Enabled = false;
			algoritmy.Enabled = false;
			if (start == 0){ firstSetUzel(); start++; }
			List<Uzel> uzly = strom[strom.Count - 1];
			int pocet = strom.Count;
			projdi(uzly);
			if (pocet < strom.Count)
				run();
		}
		
		
		//samotne prochazeni prediktoru v uzlu
		Dictionary<string, List<Kategorie>> tabulkaZavislosti; bool stop=true;
		private void projdi(List<Uzel> uzly){
			int cisloKroku = strom.Count;
			vypocty.Items.Add(string.Format("Krok: {0}", cisloKroku));
			stop = true;
			foreach (Uzel u in uzly) {	//zde provadeni operaci po krocich
				u.pocitaniKategorii();		//spocitej cetnosti trid prediktoru
				tabulkaZavislosti = u.pocitaniKategoriiVZavislosti();		//vytvoreni tabulky zavisloti mezi prediktory a predikovanym atributem
				/// 
				/// 
				/// STOP KRITERIA V PODMINCE
				/// 
				/// 
				if (u.PredikovanyAtribut.TridyPrediktora.Count > MIN_POCET_TRID_PRED_A 		//zkontroluj stop kriteria
				    && u.Design.Data.Rows.Count-1 > MIN_POCET_ZAZNAMU){		
					stop = false;
					setAlg(u);			//spust prislusnou statistickou metodu podle vyberu v combu
					vyberNej(u);		//vyber nejlepsiho prediktora podle vypoctu
					rozdelPodleNej(u);	//rozdel uzel
					
				}
				
			}
			if(stop) {krok.Enabled = false; vypocty.Items[vypocty.Items.Count-1].Remove(); return;}
		}
		
		//metoda pro vypocet informacniho zisku
		private void spocitej_IFZ(Uzel u){
			int pocetZaznamu = u.Design.Data.Rows.Count;
			foreach (Prediktor p in u.Prediktori){
				meziVysledky(pocetZaznamu, p);
			}
			meziVysledky(pocetZaznamu, u.PredikovanyAtribut);
			foreach (Prediktor p in u.Prediktori){
				if (p.Enable){
					p.Zisk = u.PredikovanyAtribut.Zisk - p.Zisk;
					p.Zisk = Math.Round(p.Zisk, 5);
					vypocty.Items.Add(p.Name + " " + p.Zisk);
				}
			}			
		}

		//metoda pro vypocet podminene entropie
		void spocitej_Entropy(Uzel u)
		{
			double entropyPred = 0;
			int pocetZaznamu = u.Design.Data.Rows.Count;
			foreach(Prediktor p in u.Prediktori){		//projdi vsechny prediktory v uzlu
				if (p.Enable){
				string jmPred = p.Name;
				double vysledek = 0;
				foreach(Kategorie k in p.TridyPrediktora){		//projdi vsechny tridy prediktora
					string key = jmPred+"."+k.JmTridy;			//KEY pro tabulku zavislosti
					
					foreach(Kategorie trida in tabulkaZavislosti[key]){			//projdi cetnosti v tabulce zavisloti podle KEY
						double podil = trida.PocetVyskytu / k.PocetVyskytu;
						vysledek += podil * Math.Log(podil, 2);
					}
					
				}
				entropyPred = vysledek;
				double zisk = 0;
				for (int i = 0; i < p.TridyPrediktora.Count; i++){			//projdi znova vsechny tridy prediktora a dopocitej zisk
					double podil = p.TridyPrediktora[i].PocetVyskytu / pocetZaznamu;
					zisk += podil * entropyPred;
				}
				zisk = Math.Round(zisk, 4);
				p.Zisk = (-1)*zisk;
				vypocty.Items.Add(p.Name + " " + p.Zisk);
			}
			}
		}
		
		//metoda pro vypocet GINI indexu
		void spictej_GINI(Uzel u){
			
		}
		
		//pomocna metoda pro pocitani nepodminene entropie
		private double Entropy(double pocetVyskytu, double count){
			double podil = pocetVyskytu / count;
			return podil * Math.Log(podil, 2);
		}
		
		//pomocna metoda pro vypocet celkoveho zisku
		private void meziVysledky(double pocetZaznamu, Prediktor cetnosti){
			double vysledek = 0;
			double suma = cetnosti.TridyPrediktora.Sum(X => Entropy(X.PocetVyskytu, pocetZaznamu));			
			vysledek = -1 * suma;
			cetnosti.Zisk = vysledek;
			vysledek = 0;
		}
		
		//metoda pro vybrani nejlepsiho prediktora
		private void vyberNej(Uzel u){
			double nej = 0;
			//vyber spravne rozhodovaci podminky pro statistickou metodu
			if (startIFZ) nej = Double.MinValue;
			if (startE) nej = Double.MaxValue;
			if (startGINI) nej = Double.MinValue;
			Prediktor nejP = null;
			foreach (Prediktor p in u.Prediktori){
				if (p.Zisk > nej && p.Enable && startIFZ){
					nej = p.Zisk;
					nejP = p;
				}
				if (p.Zisk < nej && p.Enable && startE){
					nej = p.Zisk;
					nejP = p;
				}				
				if (p.Zisk > nej && p.Enable && startGINI){
					nej = p.Zisk;
					nejP = p;
				}
				
			}
			if (nejP != null){
				u.Prediktori.Find(p => p == nejP).Best = false;
				vypocty.Items.Add(nejP.Name);
			}
		}
		
		//metoda pro rozdeleni uzlu podle nejlepsiho prediktora
		private void rozdelPodleNej(Uzel u){		
			uzlyVKrocich = new List<Uzel>();		//vytvor novy seznam pro dalsi krok
			DataTable dt = u.Design.Data;			//tabulka pro deleni
			Prediktor nejP = u.Prediktori.Find(p => p.Best == false);	//vrat ze seznamu nejlepsiho prediktora
			if (nejP == null) {stop=true; return;}	//jestli uz zadny neni -> skonci :-)
			for(int i = 0; i < nejP.TridyPrediktora.Count; i++){	//projdi vsechny tridy nejlepsiho prediktora
				var novyUzel = new Uzel(nejP.Name, nejP.TridyPrediktora[i].JmTridy, u.PredikovanyAtribut.Name);		//vytvor novy uzel podle vstupniho							
				var newTable = new DataTable();					//vytvor novou tabulku pro novy uzel
				newTable = dt.Copy();							//prekopiruj vsechna data
				newTable.Rows.Clear();							//vymaz radky
				for (int j = 0; j < dt.Rows.Count; j++){		//projdi vsechny radky vstupni tabulky	
					if (nejP.TridyPrediktora[i].JmTridy == dt.Rows[j][nejP.Name].ToString())	//vybirej vzdy jen jednu tridu prediktora
						newTable.Rows.Add(dt.Rows[j].ItemArray);	//vloz novy radek
				}
				novyUzel.Design.Data = newTable;	//nastaveni nove tabulky novemu uzlu
				//pomocny list prediktoru, ktery je pak nastaven novemu uzlu
				var pom = new List<Prediktor>();
				foreach (Prediktor copyP in u.Prediktori)
				pom.Add(new Prediktor {
					Name = copyP.Name,
					Enable = copyP.Enable,
				});				
				novyUzel.Prediktori.AddRange(pom.ToArray());
				novyUzel.Prediktori.Find(p => p.Name == nejP.Name).Enable = false;
				uzlyVKrocich.Add(novyUzel);	//pridej uzel do listu uzlu pro aktualni krok
			}		
			
			
			strom.Add(uzlyVKrocich); //pridej uzly kroku do stromu a pridej buttony na panel
			foreach(Uzel but in strom[strom.Count-1]){
				but.Design.UzelB.Location = new Point(x, y);			
				panel1.Controls.Add(but.Design.UzelB);
				x+=120;
			}
			y += 25;
			x=0;
		}
		//volani statistickych metod podle comba	
		bool startE = false, startIFZ = false, startGINI = false;
		private void setAlg(Uzel u){
			string jmAlg = algoritmy.Items[algoritmy.SelectedIndex].ToString();
			switch(jmAlg.ToUpper()){
					case "PODMÍNĚNÁ ENTROPIE" : spocitej_Entropy(u); startE = true; break;
					case "INFORMAČNÍ ZISK" : spocitej_IFZ(u); startIFZ = true; break;
					case "GINI INDEX" : startGINI = true; break;
			}
		}


	}
}
