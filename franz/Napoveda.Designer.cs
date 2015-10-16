namespace franz
{
    partial class Napoveda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.status_Clock = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// listBox1
        	// 
        	this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.ItemHeight = 20;
        	this.listBox1.Items.AddRange(new object[] {
			"Autor",
			"Popis aplikace",
			"Příklad"});
        	this.listBox1.Location = new System.Drawing.Point(12, 12);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(135, 584);
        	this.listBox1.TabIndex = 0;
        	this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        	// 
        	// panel1
        	// 
        	this.panel1.Location = new System.Drawing.Point(153, 12);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(767, 584);
        	this.panel1.TabIndex = 1;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.status_Clock,
			this.toolStripStatusLabel1});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 604);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(932, 22);
        	this.statusStrip1.TabIndex = 44;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// status_Clock
        	// 
        	this.status_Clock.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.status_Clock.Name = "status_Clock";
        	this.status_Clock.Size = new System.Drawing.Size(0, 17);
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
        	this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
        	// 
        	// timer1
        	// 
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// Napoveda
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(932, 626);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.listBox1);
        	this.Name = "Napoveda";
        	this.Text = "Napoveda";
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_Clock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}