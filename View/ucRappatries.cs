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
    public partial class ucRappatries : UserControl
    {
        ArrayList listeRappatries = new ArrayList();
        Rappatries ra = null; 

        public ucRappatries()
        {
            InitializeComponent();
        }
        String genererid(Rappatries ra)
        {
            int nombre = Factory.getRappatries().Count + 1;
            string idrap = ra.Nom.Substring(0, 2);
            idrap = idrap + nombre.ToString();
            return idrap;

        }

        private void lblNomMR_Click(object sender, EventArgs e)
        {

        }

        private void ucRappatries_Load(object sender, EventArgs e)
        {
            listeRappatries = Factory.getRappatries();
            dgvRappatries.DataSource = listeRappatries;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ra = new Rappatries();
            //ra.Id =tId.Text;
            ra.Nom = tNom.Text;
            ra.Prenom = tPren.Text;

            foreach (Control c in gbGenre.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    ra.Genre = ((RadioButton)c).Text;
                }
            }
            foreach (Control c in gbEC.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    ra.EtatCivil = ((RadioButton)c).Text;
                }
            }
             ra.NombreEnfants=tnbe.Text;
             ra.LieuNaissance = tLn.Text;
             ra.NomPere = tNp.Text;
             ra.NomMere = tNm.Text;
             ra.Province = cboPro.SelectedItem.ToString();
             ra.Commune = cboCo.SelectedItem.ToString();
             ra.DateRetour = dateTimePickerRa.Text;
             ra.Id = genererid(ra);

            try
            {
                int line = Factory.insererRappatries(ra);

                if (line != 0)
                    MessageBox.Show("Enregistrement Reussi");
                Actualiser();
                Reinitialiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce rappatrié?",
                      "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        int line = Factory.deleteRappatries(zonerecherche.Text);

                        if (line != 0)
                            MessageBox.Show("Suppression Reussie");
                        Actualiser();
                        Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Le rappatrié a été supprimé...");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Le rappatrié n'a pas été supprimé...");
                    break;

                    try
                    {
                        int line = Factory.deleteRappatries(zonerecherche.Text);

                        if (line != 0)
                            MessageBox.Show("Suppression Reussie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            listeRappatries = Factory.getRappatries();
            dgvRappatries.DataSource = listeRappatries;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            
            tId.Text = "";
            tNom.Text = "";
            tPren.Text = "";
            gbGenre.Text = "";
            gbEC.Text = "";
            tnbe.Text = "";
            tLn.Text = "";
            tNp.Text = "";
            tNm.Text = "";
            cboPro.Text = "";
            cboCo.Text = "";
            dateTimePickerRa.Text = "";
            tId.Focus();
                    
        }

        private void Reinitialiser() {

                    tId.Text = "";
                    tNom.Text = "";
                    tPren.Text = "";
                    gbGenre.Text = "";
                    gbEC.Text = "";
                    tnbe.Text = "";
                    tLn.Text = "";
                    tNp.Text = "";
                    tNm.Text = "";
                    cboPro.Text = "";
                    cboCo.Text = "";
                    dateTimePickerRa.Text = "";
                    tId.Focus();
                
            
        
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment modifier ces données???",
                      "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    ra = new Rappatries();
                    ra.Id = tId.Text;
                    ra.Nom = tNom.Text;
                    ra.Prenom = tPren.Text;
                    
                    foreach (Control c in gbGenre.Controls)
                    {
                        if (((RadioButton)c).Checked)
                        {
                            ra.Genre = ((RadioButton)c).Text;
                        }
                    }
                    foreach (Control c in gbEC.Controls)
                    {
                        if (((RadioButton)c).Checked)
                        {
                            ra.EtatCivil = ((RadioButton)c).Text;
                        }
                    }
                    ra.NombreEnfants = tnbe.Text;
                    ra.LieuNaissance = tLn.Text;
                    ra.NomPere = tNp.Text;
                    ra.NomMere = tNm.Text;
                    ra.Province = cboPro.SelectedItem.ToString();
                    ra.Commune = cboCo.SelectedItem.ToString();
                    ra.DateRetour = dateTimePickerRa.Text;

                    try
                    {
                        int line = Factory.modifierRappatries(ra);

                        if (line != 0)
                            MessageBox.Show("Modification Reussie");
                        Actualiser();
                        Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    MessageBox.Show("Les données ont été modifiées...");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Les données n'ont pas été modifiées...");
                    break;

                    
            }
        }

        private void Actualiser() {
            listeRappatries = Factory.getRappatries();
            dgvRappatries.DataSource = listeRappatries;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Rappatries rap = null;
            string id = zonerecherche.Text.Trim();
            rap = Factory.getrapbyID(id);
            if (rap != null)
            {
                recupererrap(rap);
            }
        }
        void recupererrap(Rappatries r)
        { 
            tId.Text=r.Id;
            tNom.Text=r.Nom;
            tPren.Text=r.Prenom;
                //gbSexe.Text = r.Sexe;
            tnbe.Text = r.NombreEnfants;
            tLn.Text = r.LieuNaissance;
            tNp.Text=r.NomPere;
            tNm.Text=r.NomMere;
            cboPro.Text=r.Province;
            cboCo.Text=r.Commune;
                
             foreach (Control c in gbGenre.Controls)
                {
                    if (r.Genre == ((RadioButton)c).Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
                }

                foreach (Control c in gbEC.Controls)
                {
                    if (r.EtatCivil == ((RadioButton)c).Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
                }
                
            }

        private void zonerecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tnomEnter(object sender, EventArgs e)
        {
            Rappatries ra = null;
            string id =tId.Text.Trim();

            if (id != null)
            {
                ra = Factory.getrapbyID(id);
                if (ra != null)
                {
                    recupererrap(ra);
                    btnAjouter.Enabled = false;
                    btnModifier.Enabled = false;

                }
            }
        }

        }
    }

