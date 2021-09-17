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
            // Resize the master DataGridView columns to fit the newly loaded data.
            //dgvResident.AutoResizeColumns();

            listeResident = Factory.getResident();
            dgvResident.DataSource = listeResident;

            dgvResident.Columns["DateNaissance"].HeaderText = "Date de Naissance";
            dgvResident.Columns["Nationnalite"].HeaderText = "Nationalite";
            dgvResident.Columns["Cni"].DisplayIndex = 0;
            //dgvResident.Columns["cni_Residents"].Visible = false;
            dgvResident.Columns["LieuNaissance"].HeaderText = "Lieu de Naissance";
            dgvResident.Columns["EtatCivil"].HeaderText = "Etat civil";
            dgvResident.Columns["Genre"].DisplayIndex = 3;
            dgvResident.Columns["Prenom"].DisplayIndex = 2;
            dgvResident.Columns["Nom"].DisplayIndex = 1;
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
                    Actualiser();
                    Reinitialiser();
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
            Reinitialiser();
        }

        private void Actualiser()
        {
            listeResident = Factory.getResident();
            dgvResident.DataSource = listeResident;
        }
        private void Reinitialiser()
        {
                    tcni.Text = "";
                    tnom.Text = "";
                    tprenom.Text = "";
                    gGenre.Text = "";
                    gEtatCivil.Text = "";
                    coNationnalite.Text = "";
                    tdateNaissance.Text = "";
                    tLieuNaissance.Text = "";
                    tRechercher.Text = "";

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
            foreach (Control c in gGenre.Controls)
            {
                if (r.Genre == ((RadioButton)c).Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
            }

            foreach (Control c in gEtatCivil.Controls)
            {
                if (r.EtatCivil == ((RadioButton)c).Text)
                {
                    ((RadioButton)c).Checked = true;
                }
            }
            gGenre.Text = r.Genre;
            gEtatCivil.Text = r.EtatCivil;
            coNationnalite.Text = r.Nationnalite;
            tdateNaissance.Text = r.DateNaissance;
            tLieuNaissance.Text = r.LieuNaissance;


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce resident??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        int line = Factory.deleteResident(tRechercher.Text);
                        if (line != 0)
                            MessageBox.Show("Suppression reussi");
                            Actualiser();
                            Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Votre resident a ete supprime ...");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre resident n'a pas ete supprime ...");
                    break;

            }

        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment Modifier ces donnees??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
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
                        int line = Factory.modifierResident(r);

                        if (line != 0)
                            MessageBox.Show("Modification reussi");
                            Actualiser();
                            Reinitialiser();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Votre donnees a ete modifiees !!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre donnees n'a pas ete modifiees!!");
                    break;
            }

        }

        private void dgvResident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvResident.Rows[e.RowIndex];
                tLieuNaissance.Text = row.Cells["DateNaissance"].Value.ToString();
                coNationnalite.Text = row.Cells["Nationnalite"].Value.ToString();
                tcni.Text = row.Cells["Cni"].Value.ToString();
                tprenom.Text = row.Cells["LieuNaissance"].Value.ToString();
                gEtatCivil.Text = row.Cells["EtatCivil"].Value.ToString();
                gGenre.Text = row.Cells["Genre"].Value.ToString();
                tprenom.Text = row.Cells["Prenom"].Value.ToString();
                tnom.Text = row.Cells["Nom"].Value.ToString();
            }
        }

    }
}
