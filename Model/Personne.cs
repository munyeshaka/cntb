using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Personne
    {
        string nom, prenom, genre, etatCivil, lieuNaissance;

        public string LieuNaissance
        {
            get { return lieuNaissance; }
            set { lieuNaissance = value; }
        }

        public string EtatCivil
        {
            get { return etatCivil; }
            set { etatCivil = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
