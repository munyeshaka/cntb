using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proces
    {
        string id, nom, date, pv, province;

       

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Pv
        {
            get { return pv; }
            set { pv = value; }
        }
       

        Parcelle parcelle;

        public Parcelle Parcelle
        {
            get { return parcelle; }
            set { parcelle = value; }
        }

        public string Province
        {
            get { return parcelle.Province; }
            set { province = value; }
        }
       
    }
}
