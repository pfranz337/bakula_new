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
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMining));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapVypHintyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_Clock = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zobrazeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.středToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.possInPic = new System.Windows.Forms.ToolStripStatusLabel();
            this.přejítNaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.zobrazeníToolStripMenuItem,
            this.algoritmy});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.nastaveníToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            resources.ApplyResources(this.openToolStripMenuItem1, "openToolStripMenuItem1");
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openClick);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapVypHintyToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            resources.ApplyResources(this.nastaveníToolStripMenuItem, "nastaveníToolStripMenuItem");
            // 
            // zapVypHintyToolStripMenuItem
            // 
            this.zapVypHintyToolStripMenuItem.Name = "zapVypHintyToolStripMenuItem";
            resources.ApplyResources(this.zapVypHintyToolStripMenuItem, "zapVypHintyToolStripMenuItem");
            this.zapVypHintyToolStripMenuItem.Click += new System.EventHandler(this.zapVypTipyClick);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            resources.ApplyResources(this.nápovědaToolStripMenuItem, "nápovědaToolStripMenuItem");
            this.nápovědaToolStripMenuItem.Click += new System.EventHandler(this.nápovědaToolStripMenuItem_Click);
            // 
            // algoritmy
            // 
            resources.ApplyResources(this.algoritmy, "algoritmy");
            this.algoritmy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoritmy.Items.AddRange(new object[] {
            resources.GetString("algoritmy.Items"),
            resources.GetString("algoritmy.Items1")});
            this.algoritmy.Name = "algoritmy";
            this.algoritmy.Sorted = true;
            // 
            // vypocty
            // 
            resources.ApplyResources(this.vypocty, "vypocty");
            this.vypocty.Name = "vypocty";
            this.toolTip1.SetToolTip(this.vypocty, resources.GetString("vypocty.ToolTip"));
            this.vypocty.UseCompatibleStateImageBehavior = false;
            this.vypocty.View = System.Windows.Forms.View.Tile;
            // 
            // krok
            // 
            resources.ApplyResources(this.krok, "krok");
            this.krok.Name = "krok";
            this.toolTip1.SetToolTip(this.krok, resources.GetString("krok.ToolTip"));
            this.krok.UseVisualStyleBackColor = true;
            this.krok.Click += new System.EventHandler(this.KrokClick);
            // 
            // spust
            // 
            resources.ApplyResources(this.spust, "spust");
            this.spust.Name = "spust";
            this.toolTip1.SetToolTip(this.spust, resources.GetString("spust.ToolTip"));
            this.spust.UseVisualStyleBackColor = true;
            this.spust.Click += new System.EventHandler(this.SpustClick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // sloupceTab
            // 
            resources.ApplyResources(this.sloupceTab, "sloupceTab");
            this.sloupceTab.FormattingEnabled = true;
            this.sloupceTab.Name = "sloupceTab";
            this.sloupceTab.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toolTip1.SetToolTip(this.sloupceTab, resources.GetString("sloupceTab.ToolTip"));
            // 
            // setCil
            // 
            resources.ApplyResources(this.setCil, "setCil");
            this.setCil.Name = "setCil";
            this.toolTip1.SetToolTip(this.setCil, resources.GetString("setCil.ToolTip"));
            this.setCil.UseVisualStyleBackColor = true;
            this.setCil.Click += new System.EventHandler(this.SetCilClick);
            // 
            // cilNahoru
            // 
            resources.ApplyResources(this.cilNahoru, "cilNahoru");
            this.cilNahoru.Name = "cilNahoru";
            this.toolTip1.SetToolTip(this.cilNahoru, resources.GetString("cilNahoru.ToolTip"));
            this.cilNahoru.UseVisualStyleBackColor = true;
            this.cilNahoru.Click += new System.EventHandler(this.retPredikAtrToAtribut);
            // 
            // itemDolu
            // 
            resources.ApplyResources(this.itemDolu, "itemDolu");
            this.itemDolu.Name = "itemDolu";
            this.toolTip1.SetToolTip(this.itemDolu, resources.GetString("itemDolu.ToolTip"));
            this.itemDolu.UseVisualStyleBackColor = true;
            this.itemDolu.Click += new System.EventHandler(this.addToPrediktori);
            // 
            // predNahoru
            // 
            resources.ApplyResources(this.predNahoru, "predNahoru");
            this.predNahoru.Name = "predNahoru";
            this.toolTip1.SetToolTip(this.predNahoru, resources.GetString("predNahoru.ToolTip"));
            this.predNahoru.UseVisualStyleBackColor = true;
            this.predNahoru.Click += new System.EventHandler(this.retPredikToSloupce);
            // 
            // prediktori
            // 
            resources.ApplyResources(this.prediktori, "prediktori");
            this.prediktori.FormattingEnabled = true;
            this.prediktori.Name = "prediktori";
            this.prediktori.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toolTip1.SetToolTip(this.prediktori, resources.GetString("prediktori.ToolTip"));
            // 
            // pred_atribut
            // 
            resources.ApplyResources(this.pred_atribut, "pred_atribut");
            this.pred_atribut.FormattingEnabled = true;
            this.pred_atribut.Name = "pred_atribut";
            this.pred_atribut.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toolTip1.SetToolTip(this.pred_atribut, resources.GetString("pred_atribut.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_Clock,
            this.possInPic});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // status_Clock
            // 
            this.status_Clock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_Clock.Name = "status_Clock";
            resources.ApplyResources(this.status_Clock, "status_Clock");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picture
            // 
            this.picture.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.picture, "picture");
            this.picture.Name = "picture";
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.picture);
            this.panel1.Name = "panel1";
            // 
            // zobrazeníToolStripMenuItem
            // 
            this.zobrazeníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.středToolStripMenuItem,
            this.přejítNaToolStripMenuItem});
            this.zobrazeníToolStripMenuItem.Name = "zobrazeníToolStripMenuItem";
            resources.ApplyResources(this.zobrazeníToolStripMenuItem, "zobrazeníToolStripMenuItem");
            // 
            // středToolStripMenuItem
            // 
            this.středToolStripMenuItem.Name = "středToolStripMenuItem";
            resources.ApplyResources(this.středToolStripMenuItem, "středToolStripMenuItem");
            this.středToolStripMenuItem.Click += new System.EventHandler(this.středToolStripMenuItem_Click);
            // 
            // possInPic
            // 
            this.possInPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.possInPic.Name = "possInPic";
            resources.ApplyResources(this.possInPic, "possInPic");
            // 
            // přejítNaToolStripMenuItem
            // 
            this.přejítNaToolStripMenuItem.Name = "přejítNaToolStripMenuItem";
            resources.ApplyResources(this.přejítNaToolStripMenuItem, "přejítNaToolStripMenuItem");
            this.přejítNaToolStripMenuItem.Click += new System.EventHandler(this.přejítNaToolStripMenuItem_Click);
            // 
            // DataMining
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
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
            this.Name = "DataMining";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DataMining_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripMenuItem zapVypHintyToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_Clock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem zobrazeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem středToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel possInPic;
        private System.Windows.Forms.ToolStripMenuItem přejítNaToolStripMenuItem;
    }
}
