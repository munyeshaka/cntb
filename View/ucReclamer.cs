using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class ucReclamer : UserControl
    {
        public ucReclamer()
        {
            InitializeComponent();
        }
        
        private void ucReclamer_Load(object sender, EventArgs e)
        {
            comboBoxRappatrie.DataSource = Factory.getRappatries();
            comboBoxRappatrie.DisplayMember = "nomComplet";

            comboBoxParcelle.DataSource = Factory.getParcelle();
            comboBoxParcelle.DisplayMember = "provinceNumeroAre";
        }
    }
}
