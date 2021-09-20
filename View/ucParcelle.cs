using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Collections;

namespace View
{
    public partial class ucParcelle : UserControl
    {
        ArrayList listeParcelle = new ArrayList();
        Parcelle p = null;

        public ucParcelle()
        {
            InitializeComponent();
        }

        string generateId(Parcelle p)
        {
            int nombre = Factory.getParcelle().Count + 1;
            string idPar = p.Commune.Substring(0, 3);
            idPar = idPar + nombre.ToString();
            return idPar;

        }

        private void ucParcelle_Load(object sender, EventArgs e)
        {
            listeParcelle = Factory.getParcelle();
            dgvParcelle.DataSource = listeParcelle;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            p = new Parcelle();
            p.Id = generateId(p);
            p.Province = cbProvince.SelectedItem.ToString();
            p.Commune = tCom.Text;
            p.Rue = tRue.Text;
            p.Numero = tNum.Text;
            p.Taille = tTaille.Text;
            p.CniResident = tCni.Text;

            try
            {
                int line = Factory.insertParcelle(p);

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

        private void Actualiser()
        {
            listeParcelle = Factory.getParcelle();
            dgvParcelle.DataSource = listeParcelle;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            listeParcelle = Factory.getParcelle();
            dgvParcelle.DataSource = listeParcelle;
            Reinitialiser();
        }

        private void Reinitialiser()
        {
            tId.Text = "";
            tCom.Text = "";
            tRue.Text = "";
            tNum.Text = "";
            cbProvince.Text = "";
            tTaille.Text = "";
            tCni.Text = "";
            tRechercher.Text = "";

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string i = tRechercher.Text.Trim();
            p = Factory.getParcelleById(i);
            if (p != null)
            {
                recupererParcelle(p);
            }
        }

        void recupererParcelle(Parcelle p)
        {
            tId.Text = p.Id;
            tCom.Text = p.Commune;
            tRue.Text = p.Rue;
            tNum.Text = p.Numero;
            tTaille.Text = p.Taille;
            tCni.Text = p.CniResident;
            cbProvince.Text = p.Province;

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce resident??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        int line = Factory.deleteParcelle(tRechercher.Text);
                        if (line != 0)
                            MessageBox.Show("Suppression reussi");
                        Actualiser();
                        Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Parcelle supprimé");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Le parcelle n'a pas ete supprimé");
                    break;

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment Modifier ces donnees??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    p = new Parcelle();
                    p.Id = generateId(p);
                    p.Province = cbProvince.SelectedItem.ToString();
                    p.Commune = tCom.Text;
                    p.Rue = tRue.Text;
                    p.Numero = tNum.Text;
                    p.Taille = tTaille.Text;
                    p.CniResident = tCni.Text;

                    try
                    {
                        int line = Factory.modifyParcelle(p);

                        if (line != 0)
                            MessageBox.Show("Modification reussi");
                        Actualiser();
                        Reinitialiser();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Les donnees ont ete modifiees !!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Les donnees n'ont pas ete modifiees!!");
                    break;
            }
        }
    }
}
