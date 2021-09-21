using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parcelle
    {
        string id, province, commune, rue, numero, taille, batie, cniResident;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CniResident
        {
            get { return cniResident; }
            set { cniResident = value; }
        }

        public string Batie
        {
            get { return batie; }
            set { batie = value; }
        }

        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        public String Commune
        {
            get { return commune; }
            set { commune = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string provinceNumeroAre
        {
            get
            {
                return Province + " " + Numero + " " + Taille;
            }
        }
    }
}
