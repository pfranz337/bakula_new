/*
 * Created by SharpDevelop.
 * User: franz
 * Date: 11.9.2015
 * Time: 9:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace franz
{
	partial class DataMining
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ListView vypocty;
		private System.Windows.Forms.Button krok;
		private System.Windows.Forms.Button spust;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.ToolStripComboBox algoritmy;
		private System.Windows.Forms.ListBox sloupceTab;
		private System.Windows.Forms.Button setCil;
		private System.Windows.Forms.Button cilNahoru;
		private System.Windows.Forms.Button itemDolu;
		private System.Windows.Forms.Button predNahoru;
		private System.Windows.Forms.ListBox prediktori;
		private System.Windows.Forms.ListBox pred_atribut;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.algoritmy = new System.Windows.Forms.ToolStripComboBox();
			this.vypocty = new System.Windows.Forms.ListView();
			this.krok = new System.Windows.Forms.Button();
			this.spust = new System.Windows.Forms.Button();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.sloupceTab = new System.Windows.Forms.ListBox();
			this.setCil = new System.Windows.Forms.Button();
			this.cilNahoru = new System.Windows.Forms.Button();
			this.itemDolu = new System.Windows.Forms.Button();
			this.predNahoru = new System.Windows.Forms.Button();
			this.prediktori = new System.Windows.Forms.ListBox();
			this.pred_atribut = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.helpToolStripMenuItem,
			this.algoritmy});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(884, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// algoritmy
			// 
			this.algoritmy.AccessibleName = "Algoritmy";
			this.algoritmy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.algoritmy.Items.AddRange(new object[] {
			"GINI index",
			"Informační zisk",
			"Podmíněná entropie"});
			this.algoritmy.Name = "algoritmy";
			this.algoritmy.Size = new System.Drawing.Size(121, 23);
			this.algoritmy.Sorted = true;
			// 
			// vypocty
			// 
			this.vypocty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vypocty.Location = new System.Drawing.Point(12, 362);
			this.vypocty.Name = "vypocty";
			this.vypocty.Size = new System.Drawing.Size(164, 263);
			this.vypocty.TabIndex = 5;
			this.vypocty.UseCompatibleStateImageBehavior = false;
			this.vypocty.View = System.Windows.Forms.View.Tile;
			// 
			// krok
			// 
			this.krok.Location = new System.Drawing.Point(12, 635);
			this.krok.Name = "krok";
			this.krok.Size = new System.Drawing.Size(75, 33);
			this.krok.TabIndex = 6;
			this.krok.Text = "Krok";
			this.krok.UseVisualStyleBackColor = true;
			this.krok.Click += new System.EventHandler(this.KrokClick);
			// 
			// spust
			// 
			this.spust.Location = new System.Drawing.Point(93, 635);
			this.spust.Name = "spust";
			this.spust.Size = new System.Drawing.Size(83, 33);
			this.spust.TabIndex = 7;
			this.spust.Text = "Spust";
			this.spust.UseVisualStyleBackColor = true;
			this.spust.Click += new System.EventHandler(this.SpustClick);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
			// 
			// sloupceTab
			// 
			this.sloupceTab.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sloupceTab.FormattingEnabled = true;
			this.sloupceTab.ItemHeight = 20;
			this.sloupceTab.Location = new System.Drawing.Point(12, 30);
			this.sloupceTab.Name = "sloupceTab";
			this.sloupceTab.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.sloupceTab.Size = new System.Drawing.Size(164, 124);
			this.sloupceTab.TabIndex = 38;
			// 
			// setCil
			// 
			this.setCil.Location = new System.Drawing.Point(12, 157);
			this.setCil.Name = "setCil";
			this.setCil.Size = new System.Drawing.Size(164, 23);
			this.setCil.TabIndex = 37;
			this.setCil.Text = "SET MAIN ATRIBUT";
			this.setCil.UseVisualStyleBackColor = true;
			this.setCil.Click += new System.EventHandler(this.SetCilClick);
			// 
			// cilNahoru
			// 
			this.cilNahoru.Enabled = false;
			this.cilNahoru.Location = new System.Drawing.Point(182, 313);
			this.cilNahoru.Name = "cilNahoru";
			this.cilNahoru.Size = new System.Drawing.Size(20, 39);
			this.cilNahoru.TabIndex = 36;
			this.cilNahoru.Text = "↑";
			this.cilNahoru.UseVisualStyleBackColor = true;
			this.cilNahoru.Click += new System.EventHandler(this.retPredikAtrToAtribut);
			// 
			// itemDolu
			// 
			this.itemDolu.Enabled = false;
			this.itemDolu.Location = new System.Drawing.Point(182, 81);
			this.itemDolu.Name = "itemDolu";
			this.itemDolu.Size = new System.Drawing.Size(20, 70);
			this.itemDolu.TabIndex = 35;
			this.itemDolu.Text = "↓";
			this.itemDolu.UseVisualStyleBackColor = true;
			this.itemDolu.Click += new System.EventHandler(this.addToPrediktori);
			// 
			// predNahoru
			// 
			this.predNahoru.Enabled = false;
			this.predNahoru.Location = new System.Drawing.Point(182, 187);
			this.predNahoru.Name = "predNahoru";
			this.predNahoru.Size = new System.Drawing.Size(20, 70);
			this.predNahoru.TabIndex = 34;
			this.predNahoru.Text = "↑";
			this.predNahoru.UseVisualStyleBackColor = true;
			this.predNahoru.Click += new System.EventHandler(this.retPredikToSloupce);
			// 
			// prediktori
			// 
			this.prediktori.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.prediktori.FormattingEnabled = true;
			this.prediktori.ItemHeight = 20;
			this.prediktori.Location = new System.Drawing.Point(12, 186);
			this.prediktori.Name = "prediktori";
			this.prediktori.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.prediktori.Size = new System.Drawing.Size(164, 124);
			this.prediktori.TabIndex = 39;
			// 
			// pred_atribut
			// 
			this.pred_atribut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pred_atribut.FormattingEnabled = true;
			this.pred_atribut.ItemHeight = 20;
			this.pred_atribut.Location = new System.Drawing.Point(12, 313);
			this.pred_atribut.Name = "pred_atribut";
			this.pred_atribut.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.pred_atribut.Size = new System.Drawing.Size(164, 44);
			this.pred_atribut.TabIndex = 40;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(219, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(665, 648);
			this.panel1.TabIndex = 41;
			// 
			// DataMining
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 675);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pred_atribut);
			this.Controls.Add(this.prediktori);
			this.Controls.Add(this.sloupceTab);
			this.Controls.Add(this.setCil);
			this.Controls.Add(this.cilNahoru);
			this.Controls.Add(this.itemDolu);
			this.Controls.Add(this.predNahoru);
			this.Controls.Add(this.spust);
			this.Controls.Add(this.krok);
			this.Controls.Add(this.vypocty);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(900, 714);
			this.MinimumSize = new System.Drawing.Size(900, 714);
			this.Name = "DataMining";
			this.Text = "DataMining";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
