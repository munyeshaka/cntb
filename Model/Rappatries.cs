using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rappatries : Personne
    {
        string id, nombreEnfants, nomPere, nomMere, province, commune, dateRetour;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreEnfants
        {
            get { return nombreEnfants; }
            set { nombreEnfants = value; }
        }

        public string NomPere
        {
            get { return nomPere; }
            set { nomPere = value; }
        }

        public string NomMere
        {
            get { return nomMere; }
            set { nomMere = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string Commune
        {
            get { return commune; }
            set { commune = value; }
        }

        public string DateRetour
        {
            get { return dateRetour; }
            set { dateRetour = value; }
        }
    }
}
