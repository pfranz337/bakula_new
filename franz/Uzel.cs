/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 9.9.2015
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace franz
{
	/// <summary>
	/// Description of Uzel.
	/// </summary>
	public class Uzel
	{
		public Uzel()
		{
			Design = new UzelDesign();
			Prediktori = new List<Prediktor>();
		}
		public Uzel(string jmP, string jmT, string predikovanyAtr)
		{
			Design = new UzelDesign(jmP, jmT);		
			Prediktori = new List<Prediktor>();
			JmPrediktora = jmP; JmTridy = jmT; 
			PredikovanyAtribut = new Prediktor {Enable = true, Name = predikovanyAtr};
		}
		//design uzlu
		public UzelDesign Design {
			get;
			private set;
		}
		//seznam vsech prediktoru v uzlu
		public List<Prediktor> Prediktori {
			get;
			set;
		}
		//jmeno prediktora ze ktereho uzel vznikl
		public string JmPrediktora {
			get;
			set;
		}
		//jmeno tridy ze ktere uzel vznikl
		public string JmTridy {
			get;
			set;
		}
		//predikovany atribut
		public Prediktor PredikovanyAtribut {
			get;
			set;
		}		
		public void pocitaniKategorii(){	//pocitani kategorii prediktoru
			DataTable table = Design.Data;
			for (int i = 0; i < table.Rows.Count; i++)
            {
				string nazevSloupce = "", trida = "";
                for (int j = 0; j < Prediktori.Count; j++)
                {
                    if (Prediktori[j].Enable){
                    	nazevSloupce = Prediktori[j].Name;
                        trida = table.Rows[i][Prediktori[j].Name].ToString();
                        bool test = true;
                        foreach (Kategorie k in Prediktori[j].TridyPrediktora){
                        	if (k.JmTridy == trida) {k.PocetVyskytu++; test = false; break;}
                        }
                    	if (test || Prediktori[j].TridyPrediktora.Count == 0) 
                    		Prediktori[j].TridyPrediktora.Add(new Kategorie {JmTridy = trida, PocetVyskytu = 1});
            	   	}                                                                                
            	}
                
                bool testCil = true;
                foreach (Kategorie k in PredikovanyAtribut.TridyPrediktora){
                	if (k.JmTridy == table.Rows[i][PredikovanyAtribut.Name].ToString()) 
                		{k.PocetVyskytu++; testCil = false; break;}
                }
                if (testCil || PredikovanyAtribut.TridyPrediktora.Count == 0) 
                	PredikovanyAtribut.TridyPrediktora.Add(new Kategorie 
                	     {JmTridy = table.Rows[i][PredikovanyAtribut.Name].ToString(), PocetVyskytu = 1});
                nazevSloupce = PredikovanyAtribut.Name;							
                trida = table.Rows[i][PredikovanyAtribut.Name].ToString();		
                
        	}
			if (PredikovanyAtribut != null)
				setTablesCetnosti();
		}
		
		private void setTablesCetnosti(){
			List<Prediktor> zapnute = Prediktori;
			Design.tablesCetnosti = new List<System.Windows.Forms.DataGridView>();
			
			int y = 0;
			for(int i = 0; i < zapnute.Count; i++){
				var table = new DataTable();
				var grid = new System.Windows.Forms.DataGridView();
				grid = new System.Windows.Forms.DataGridView {
					Size = new System.Drawing.Size(180, 145),
				};
				table.Columns.Add(zapnute[i].Name);
				table.Columns.Add("Pocet");
				foreach(Kategorie k in Prediktori[i].TridyPrediktora){
					var radek = new object[2];
					radek[0] = k.JmTridy; radek[1] = k.PocetVyskytu;
					table.Rows.Add(radek);					
				}
				grid.Location = new System.Drawing.Point(0, y);	
				grid.DataSource = table;
				if (zapnute[i].Enable){
					Design.tablesCetnosti.Add(grid);;											
					y+=150;
				}
			}
		}
		
		public Dictionary<string, List<Kategorie>> pocitaniKategoriiVZavislosti(){
			var entropie = new Dictionary<string, List<Kategorie>>();
			string jmPredAtr = PredikovanyAtribut.Name;
			for (int i = 0; i < Design.Data.Rows.Count; i++){
				for (int j = 0; j < Prediktori.Count; j++){
					if (Prediktori[j].Enable){
						string jmPred = Prediktori[j].Name;
						string valueInPredAtr = Design.Data.Rows[i][jmPredAtr].ToString();
						string valueInPred = Design.Data.Rows[i][jmPred].ToString();
						string key = jmPred+"."+valueInPred;
						if (entropie.ContainsKey(key)){
							bool test = true;
							foreach(Kategorie kat in entropie[key]){
								if (kat.JmTridy == valueInPredAtr){
									kat.PocetVyskytu++;
									test = false;
									break;
								}
							}
							if (test){
								var k = new Kategorie {JmTridy = valueInPredAtr, PocetVyskytu = 1};
								entropie[key].Add(k);
							}
						} else {
							var k = new Kategorie {JmTridy = valueInPredAtr, PocetVyskytu = 1};
							entropie.Add(key, new List<Kategorie>());
							entropie[key].Add(k);
						}
					}
				}
			}
			return entropie;
		}
		
		/*private void addKategorie(string tridaVRadku, List<Kategorie> tridy){
			bool test = true;
            foreach (Kategorie k in tridy){
                if (k.JmTridy == tridaVRadku) 
                	{k.PocetVyskytu++; test = false; break;}
            }
            if (test || tridy.Count == 0) 
               	PredikovanyAtribut.TridyPrediktora.Add(new Kategorie 
               	     {JmTridy = tridaVRadku, PocetVyskytu = 1});
		}*/
	}
}
