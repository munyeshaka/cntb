using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Controller;

namespace View
{
    public partial class ucRappatries : UserControl
    {
        ArrayList listeRappatries = new ArrayList();
        public ucRappatries()
        {
            InitializeComponent();
        }

        private void lblNomMR_Click(object sender, EventArgs e)
        {

        }

        private void ucRappatries_Load(object sender, EventArgs e)
        {
            listeRappatries = Factory.getRappatries();
            dgvRappatries.DataSource = listeRappatries;
        }
    }
}
