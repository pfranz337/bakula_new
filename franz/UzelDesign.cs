/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 9.9.2015
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
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
			UzelB = new Button {
				Text = "INPUT", 				
			};
			UzelB.Click += clickUzel;
		}
		public UzelDesign(string jmPred, string jmTrid)
		{				
			UzelB = new Button {
				Text = jmPred + " " + jmTrid, AutoSize = true,
			};
			UzelB.Click += clickUzel;
		}
		
		public Form DataForm {
			get;
			private set;
		}
		
		public Form CetnostiForm {
			get;
			private set;
		}
		//tlacitko pro zobrazeni dat konkretniho uzlu
		public Button UzelB {
			get;
			set;
		}
		//datova tabulka uzlu
		public DataTable Data {
			get;
			set;
		}
		
		public List<DataGridView> tablesCetnosti{
			get;
			set;
		}
		
		public void setLocationButton(){
			
		}
		
		public void clickUzel(object sender, EventArgs e)
		{			
			UzelB.Enabled = false;
			DataForm = new Form{ //vytvoreni noveho formu pro kazdy uzel
				AutoScroll = true,
				Size = new Size(600, 600),	
				StartPosition = FormStartPosition.CenterScreen
			};			
			DataForm.FormClosing += zavriData;
			DataForm.Controls.Add(new DataGridView 
			    { 
			    	DataSource = Data,
					Anchor = ((AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom |
						AnchorStyles.Left | AnchorStyles.Right)),
					ScrollBars = ScrollBars.Both,
					Size = new Size(580, 560),	
			    });
			DataForm.Show();
			CetnostiForm = new Form {				
				MaximumSize = new Size(250, 600),	
				MinimumSize = new Size(250, 600),	
				AutoScroll = true,
			};
			if (tablesCetnosti != null){
				CetnostiForm.Controls.AddRange(tablesCetnosti.ToArray());
				CetnostiForm.Show();
				CetnostiForm.Location = new Point(DataForm.Location.X + DataForm.Width, DataForm.Location.Y);
			}
			
		}

		void zavriData(object sender, EventArgs e)
		{
			CetnostiForm.Close();
			
			UzelB.Enabled = true;
		}
	}
}
