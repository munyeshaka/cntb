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
using Model;

namespace View
{
    public partial class UcProces1 : UserControl
    {
        ArrayList listProces = new ArrayList();
        Proces proces = null;
        Parcelle parcelle = null;

        public UcProces1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void UcProces1_Load(object sender, EventArgs e)
        {
            afficher();

            comboBoxParcelle.DataSource = Factory.getParcelle(); ;
             comboBoxParcelle.DisplayMember = "provinceNumeroAre";
        }

        private void afficher()
        {
            listProces = Factory.getProces();
            dgvProces.DataSource = listProces;


        }
    }
}
