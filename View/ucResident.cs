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
using Controller;
using Model;

namespace View
{
    public partial class ucResident : UserControl
    {
        ArrayList listeResident = new ArrayList();
        Resident r = null;

        public ucResident()
        {
            InitializeComponent();
        }

        private void ucResident_Load(object sender, EventArgs e)
        {
            listeResident = Factory.getResident();
            dgvResident.DataSource = listeResident;
        }

        string GenererMatri(Resident re)
        {
            int nbre = Factory.getResident().Count + 1;
            string matri = re.Nom.Substring(0, 3);
            matri = matri + nbre.ToString();
            return matri;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            r = new Resident();
            r.Nom = tnom.Text;
            r.Cni = GenererMatri(r);
            r.Prenom = tprenom.Text;
            
            foreach (Control c in gGenre.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    r.Genre = ((RadioButton)c).Text;
                }
            }

            foreach (Control c in gEtatCivil.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    r.EtatCivil = ((RadioButton)c).Text;
                }
            }
            r.Nationnalite = coNationnalite.SelectedItem.ToString();
            r.DateNaissance = tdateNaissance.Text;
            r.LieuNaissance = tLieuNaissance.Text;



            try
            {
                int line = Factory.insertResident(r);

                if (line != 0)
                    MessageBox.Show("Enregistrement reussi");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            listeResident = Factory.getResident();
            dgvResident.DataSource = listeResident;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string ma = tRechercher.Text.Trim();
            r = Factory.getResidentRechercheByCni(ma);
            if (r != null)
            {
                recupererResident(r);
            }
        }

        void recupererResident(Resident r)
        {
            tcni.Text = r.Cni;
            tnom.Text = r.Nom;
            tprenom.Text = r.Prenom;
            gGenre.Text = r.Genre;
            gEtatCivil.Text = r.EtatCivil;
            coNationnalite.Text = r.Nationnalite;
            tdateNaissance.Text = r.DateNaissance;
            tLieuNaissance.Text = r.LieuNaissance;


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int line = Factory.deleteResident(tRechercher.Text);
                if (line != 0)
                    MessageBox.Show("Suppression reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
