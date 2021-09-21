using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Controller;

namespace View
{
    public partial class ucReclamer : UserControl
    {
        ArrayList list = new ArrayList();
        public ucReclamer()
        {
            InitializeComponent();
        }
        
        private void ucReclamer_Load(object sender, EventArgs e)
        {
            afficher();
            comboBoxRappatrie.DataSource = Factory.getRappatries();
            comboBoxRappatrie.DisplayMember = "nomComplet";

            comboBoxParcelle.DataSource = Factory.getParcelle();
            comboBoxParcelle.DisplayMember = "provinceNumeroAre";
        }
        private void afficher()
        {
            list = Factory.getReclamer();
            dgvResident.DataSource = list;


        }
    }
}
