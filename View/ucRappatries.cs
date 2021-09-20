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
            dgvRappatries.Columns[0].DisplayIndex=0;
            dgvRappatries.Columns[11].DisplayIndex = 1;
            dgvRappatries.Columns[10].DisplayIndex = 2;
            dgvRappatries.Columns[2].DisplayIndex = 3;
            dgvRappatries.Columns[3].DisplayIndex = 4;
            dgvRappatries.Columns[9].DisplayIndex = 5;
            dgvRappatries.Columns[8].DisplayIndex = 6;
            dgvRappatries.Columns[7].DisplayIndex = 7;
            dgvRappatries.Columns[4].DisplayIndex = 8;
            dgvRappatries.Columns[5].DisplayIndex = 9;
            dgvRappatries.Columns[1].DisplayIndex = 10;
            dgvRappatries.Columns[6].DisplayIndex = 11;
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

        private void dgvRappatries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRappatries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tId.Text = dgvRappatries.SelectedRows[0].Cells[0].Value.ToString();
            tnbe.Text= dgvRappatries.SelectedRows[0].Cells[1].Value.ToString();
            tNom.Text = dgvRappatries.SelectedRows[0].Cells[11].Value.ToString();
            tNp.Text = dgvRappatries.SelectedRows[0].Cells[2].Value.ToString();
            tNm.Text = dgvRappatries.SelectedRows[0].Cells[3].Value.ToString();
            cboPro.Text = dgvRappatries.SelectedRows[0].Cells[4].Value.ToString();
            cboCo.Text = dgvRappatries.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePickerRa.Text = dgvRappatries.SelectedRows[0].Cells[6].Value.ToString();
            tLn.Text = dgvRappatries.SelectedRows[0].Cells[7].Value.ToString();


            if (dgvRappatries.SelectedRows[0].Cells[8].Value.ToString() == "Celibataire") {
                rbtnCelibataire.Checked = true;
                rbtnDivorce.Checked = false;
                rbtnMarie.Checked = false;
                rbtnVeuf.Checked = false;
            }
            else if (dgvRappatries.SelectedRows[0].Cells[8].Value.ToString() == "Marié")
            {
                rbtnMarie.Checked = true;
                rbtnCelibataire.Checked = false;
                rbtnDivorce.Checked = false;
                rbtnVeuf.Checked = false;
            }
            else if (dgvRappatries.SelectedRows[0].Cells[8].Value.ToString() == "Veuf")
            {
                rbtnVeuf.Checked = true;
                rbtnMarie.Checked = false;
                rbtnCelibataire.Checked = false;
                rbtnDivorce.Checked = false;
               
            }
            else if (dgvRappatries.SelectedRows[0].Cells[8].Value.ToString() == "Divorcé")
            {
                rbtnDivorce.Checked = true;
                rbtnVeuf.Checked = false;
                rbtnMarie.Checked = false;
                rbtnCelibataire.Checked = false;
                
            }
            else
            {
                rbtnDivorce.Checked = false;
                rbtnVeuf.Checked = false;
                rbtnMarie.Checked = false;
                rbtnCelibataire.Checked = false;
            }

            if (dgvRappatries.SelectedRows[0].Cells[9].Value.ToString() == "Masculin")
            {

                rbtnMasculin.Checked = true;
                rbtnFeminin.Checked = false;


            }
            else if (dgvRappatries.SelectedRows[0].Cells[9].Value.ToString() == "Feminin")
            {
                rbtnFeminin.Checked = true;
                rbtnMasculin.Checked = false;
            }
            else
            {
                rbtnMasculin.Checked = false;
                rbtnFeminin.Checked = false;
            }
            //gbGenre.Text = dgvRappatries.SelectedRows[0].Cells[9].Value.ToString();
            tPren.Text = dgvRappatries.SelectedRows[0].Cells[10].Value.ToString();
        
        }

        }
    }

