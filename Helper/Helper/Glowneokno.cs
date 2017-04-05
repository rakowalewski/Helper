using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public partial class Glowneokno : Form
    {
        public Glowneokno()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new dodajApteka()).Show();
        }

        private void wszystkieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WszystkieApteki()).Show();
        }

        private void pojedynczoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Search_one()).Show();
        }
    }
}
