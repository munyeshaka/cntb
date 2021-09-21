using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reclamer
    {
        string idparcelle, idRappatries,rappatrie,numeroParcelle,areParcelle;
        Rappatries ra;
        Parcelle pa;
        int id;
        public int Id { get => id; set => id = value; }
        public string Idparcelle { get => idparcelle; set => idparcelle = value; }
        public string IdRappatries { get => idRappatries; set => idRappatries = value; }
        public string Rappatrie { get => rappatrie; set => rappatrie = value; }
        public string NumeroParcelle { get => numeroParcelle; set => numeroParcelle = value; }
        public string AreParcelle { get => areParcelle; set => areParcelle = value; }
        public Rappatries Ra { get => ra; set => ra = value; }
        public Parcelle Pa { get => pa; set => pa = value; }
        
    }
}
