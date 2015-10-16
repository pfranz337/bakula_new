using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace franz
{
    public partial class Napoveda : Form
    {
        public Napoveda()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ListBox indexMenu = sender as ListBox;
            zobrazKomponentu(indexMenu.SelectedIndex);

        }

        private void zobrazKomponentu(int ID) {
            switch (ID) {
                case 0: panel1.Controls.Add(new autor()); break;
                case 1: panel1.Controls.Add(new popisAp()); break;
                case 2: break;
            }
        }
    }
}
