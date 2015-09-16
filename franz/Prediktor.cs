/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 9.9.2015
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace franz
{
	/// <summary>
	/// Description of Prediktor.
	/// </summary>
	public class Prediktor
	{
		
		public Prediktor()
		{
			TridyPrediktora = new List<Kategorie>();
			Enable = false;
			Best = true;
		}
		//Jmeno prediktora
		public string Name {
			get;
			set;
		}
		//true = je dale rozdelitelny; false = obsahuje kategorie jedne tridy
		public bool Enable {
			get;
			set;
		}
		//seznam vsech trid, ktere obsahuje
		public List<Kategorie> TridyPrediktora {
			get;
			set;
		}
		//zisk
		public double Zisk {
			get;
			set;
		}
		//nejlepsi prediktor
		public bool Best {
			get;
			set;
		}
		
						
	}
}
