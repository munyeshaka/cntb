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
using Model;

namespace View
{
    public partial class ucReclamer : UserControl
    {
        ArrayList list = new ArrayList();
        Reclamer rec = null;
        Parcelle Pa = null;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            rec = new Reclamer();
            rec.Pa = (Parcelle)comboBoxParcelle.SelectedItem;
            rec.Ra = (Rappatries)comboBoxRappatrie.SelectedItem;

            try
            {
                int k = Factory.insertReclamer(rec);
                if (k != 0)
                    MessageBox.Show("Case successful inserted...");
                afficher();
              clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvResident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvResident.Rows[e.RowIndex];
                txtnumero.Text = row.Cells["id"].Value.ToString();
                

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaR = MessageBox.Show(" Do you want to delete Claim number " + txtnumero.Text , " Attention !!!! ", MessageBoxButtons.YesNo);
                if (diaR == DialogResult.Yes)
                {
                    int d = Factory.deleteReclamer(txtnumero.Text);
                    if (d != 0)
                        MessageBox.Show("Deleted Successful..");
                    afficher();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtnumero.Clear();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            afficher();
            clear();
        }
    }
}
