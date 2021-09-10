using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Resident: Personne
    {
        string cni, nationnalite, dateNaissance;

        public string DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string Nationnalite
        {
            get { return nationnalite; }
            set { nationnalite = value; }
        }

        public string Cni
        {
            get { return cni; }
            set { cni = value; }
        }
    }
}
