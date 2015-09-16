/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 9.9.2015
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace franz
{
	/// <summary>
	/// Description of UzelDesign.
	/// </summary>
	public class UzelDesign
	{
		public UzelDesign()
		{				
			Uzel = new Button {
				Text = "INPUT", 				
			};
			Uzel.Click += clickUzel;
		}
		public UzelDesign(string jmPred, string jmTrid)
		{				
			Uzel = new Button {
				Text = jmPred + " " + jmTrid, AutoSize = true,
			};
			Uzel.Click += clickUzel;
		}
		
		public Form DataForm {
			get;
			private set;
		}
		//tlacitko pro zobrazeni dat konkretniho uzlu
		public Button Uzel {
			get;
			set;
		}
		//datova tabulka uzlu
		public DataTable Data {
			get;
			set;
		}
		
		public void setLocationButton(){
			
		}
		
		public void clickUzel(object sender, EventArgs e)
		{			
			DataForm = new Form{ //vytvoreni noveho formu pro kazdy uzel
				AutoScroll = true,
				Size = new Size(600, 600),	
			};			
			DataForm.Controls.Add(new DataGridView 
			    { 
			    	DataSource = Data,
					Anchor = ((AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom |
						AnchorStyles.Left | AnchorStyles.Right)),
					ScrollBars = ScrollBars.Both,
					Size = new Size(580, 580),	
			    });
			DataForm.Show();
		}
	}
}
