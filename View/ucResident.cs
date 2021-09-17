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

            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce resident??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
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

                    MessageBox.Show("Votre resident a ete supprime ...");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre resident n'a pas ete supprime ...");
                    break;

            }

        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment reinitialiser ce formulaire??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    tcni.Text = "";
                    tnom.Text = "";
                    tprenom.Text = "";
                    gGenre.Text = "";
                    gEtatCivil.Text = "";
                    coNationnalite.Text = "";
                    tdateNaissance.Text = "";
                    tLieuNaissance.Text = "";
                    tRechercher.Text = "";

                    MessageBox.Show("Votre formulaire a ete reinitialise !!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre formulaire n'a pas ete reinitialise !!");
                    break;

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
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
                        int line = Factory.insertResident(r);

                        if (line != 0)
                            MessageBox.Show("Modification reussi");
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
    }
}
