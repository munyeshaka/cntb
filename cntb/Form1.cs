using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace cntb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void residentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucResident resident = new ucResident();
            this.HomePanel.Controls.Clear();
            this.HomePanel.Controls.Add(resident);
        }

        private void rappatriésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRappatries rappatries = new ucRappatries();
            this.HomePanel.Controls.Clear();
            this.HomePanel.Controls.Add(rappatries);
        }

        private void reclamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucReclamer reclamer = new ucReclamer();
            this.HomePanel.Controls.Clear();
            this.HomePanel.Controls.Add(reclamer);
        }
    }
}
