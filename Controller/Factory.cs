using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using Model;

namespace Controller
{
    public class Factory
    {
        public static ArrayList listResident = new ArrayList();
        public static ArrayList listRappatries = new ArrayList();

<<<<<<< HEAD
//<<<<<<< HEAD
        //public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=cntb;Integrated Security=True");
       // public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QQL0BU4\\SQLEXPRESS;Initial Catalog=CNTB;Integrated Security=True");

        //public static SqlConnection conn = new SqlConnection("Data Source=AUGUSTIN;Initial Catalog=cntb;Integrated Security=True");
        //public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=cntb;Integrated Security=True");
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QQL0BU4\\SQLEXPRESS;Initial Catalog=CNTB;Integrated Security=True");
//>>>>>>> 
=======
        //public static SqlConnection conn = new SqlConnection("Data Source=AUGUSTIN;Initial Catalog=cntb;Integrated Security=True");
        //public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=cntb;Integrated Security=True");
        public static SqlConnection conn = new SqlConnection("Data Source=FYFO;Initial Catalog=cntb;Integrated Security=True");
        //public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QQL0BU4\\SQLEXPRESS;Initial Catalog=CNTB;Integrated Security=True");

>>>>>>> 57fdc2c31fdae948ceee0996fdd360327c61e56f

        //=======================AFFICHER Resident==============

        public static ArrayList getResident()
        {
            ArrayList residents = new ArrayList();
            Resident r = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Residents";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                r = new Resident();
                r.Cni = reader["cni_Residents"].ToString();
                r.Nom = reader["nom_Residents"].ToString();
                r.Prenom = reader["prenom_Residents"].ToString();
                r.Genre = reader["genre_Residents"].ToString();
                r.EtatCivil = reader["etatCivil_Residents"].ToString();
                r.Nationnalite = reader["nationalite_Residents"].ToString();
                r.DateNaissance = reader["dateNaissance_Residents"].ToString();
                r.LieuNaissance = reader["lieuNaissance_Residents"].ToString();

                residents.Add(r);

            }

            reader.Close();
            conn.Close();
            return residents;

        }

        //=======================INSERT Resident==============

        public static int insertResident(Resident r)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.Residents (cni_Residents, nom_Residents, prenom_Residents, genre_Residents, etatCivil_Residents, nationalite_Residents, dateNaissance_Residents, lieuNaissance_Residents)  values (@cni,@no,@pre,@g,@eta,@na,@da,@li)";
            
            commande.Parameters.Add(new SqlParameter("@cni", r.Cni));
            commande.Parameters.Add(new SqlParameter("@no", r.Nom));
            commande.Parameters.Add(new SqlParameter("@pre", r.Prenom));
            commande.Parameters.Add(new SqlParameter("@g", r.Genre));
            commande.Parameters.Add(new SqlParameter("@eta", r.EtatCivil));
            commande.Parameters.Add(new SqlParameter("@na", r.Nationnalite));
            commande.Parameters.Add(new SqlParameter("@da", r.DateNaissance));
            commande.Parameters.Add(new SqlParameter("@li", r.LieuNaissance));

            int n = commande.ExecuteNonQuery();

            return n;
        }
        //=======================END INSERT Resident==============

        //=======================RECHERCHE RESIDENT==============

        public static Resident getResidentRechercheByCni(string cniResident)
        {
            ArrayList res = new ArrayList();
            Resident r = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Residents where cni_Residents=@cnimat";
            commande.Parameters.Add(new SqlParameter("@cnimat", cniResident));
            SqlDataReader reader = commande.ExecuteReader();
            
            if (reader.Read())
            {
                r = new Resident();

                r.DateNaissance = reader["dateNaissance_Residents"].ToString();
                r.Nationnalite = reader["nationalite_Residents"].ToString();
                r.Cni = reader["cni_Residents"].ToString();
                r.LieuNaissance = reader["lieuNaissance_Residents"].ToString();
                r.EtatCivil = reader["etatCivil_Residents"].ToString();
                r.Genre = reader["genre_Residents"].ToString();
                r.Prenom = reader["prenom_Residents"].ToString();
                r.Nom = reader["nom_Residents"].ToString();

            }

            reader.Close();
            conn.Close();
            return r;

        }//=======================END RECHERCHE RESIDENT==============

        //======================= SUPRRIMER RESIDENT==============
        
        public static int deleteResident(string cniRe)
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "delete from dbo.Residents where cni_Residents = @cni";
            commande.Parameters.AddWithValue("@cni", cniRe);
            int n = commande.ExecuteNonQuery();
            return n;
        }//=======================END SUPRRIMER RESIDENT==============

        //======================= MODIFIER RESIDENT==============
        public static int modifierResident(Resident r)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;

            commande.CommandText = "update dbo.Residents set cni_Residents=@cni, nom_Residents=@no, prenom_Residents=@pre, genre_Residents=@g, etatCivil_Residents=@eta, nationalite_Residents=@na, dateNaissance_Residents=@da, lieuNaissance_Residents=@li where cni_Residents=@cni";
            //commande.CommandText = "update dbo.Residents set cni_Residents='" + r.Cni + "', nom_Residents='" + r.Nom + "', prenom_Residents='" + r.Prenom + "', genre_Residents='" + r.Genre + "', etatCivil_Residents='" + r.EtatCivil + "', nationalite_Residents='" + r.Nationnalite + "', dateNaissance_Residents='" + r.DateNaissance + "', lieuNaissance_Residents='" + r.LieuNaissance + "' where cni_Residents='" + r.Cni + "'";

            
            commande.Parameters.Add(new SqlParameter("@cni", r.Cni));
            commande.Parameters.Add(new SqlParameter("@no", r.Nom));
            commande.Parameters.Add(new SqlParameter("@pre", r.Prenom));
            commande.Parameters.Add(new SqlParameter("@g", r.Genre));
            commande.Parameters.Add(new SqlParameter("@eta", r.EtatCivil));
            commande.Parameters.Add(new SqlParameter("@na", r.Nationnalite));
            commande.Parameters.Add(new SqlParameter("@da", r.DateNaissance));
            commande.Parameters.Add(new SqlParameter("@li", r.LieuNaissance));
            

            int n = commande.ExecuteNonQuery();
            return n;

        }////=======================END MODIFIER RESIDENT==============

        public static ArrayList getRappatries() {
            ArrayList rappatries = new ArrayList();
            Rappatries ra = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Rappatries";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read()) {

                ra = new Rappatries();
                ra.Id = reader["id_Rappatries"].ToString();
                ra.Nom = reader["nom_Rappatries"].ToString();
                ra.Prenom = reader["prenom_Rappatries"].ToString();
                ra.Genre = reader["genre_Rappatries"].ToString();
                ra.EtatCivil = reader["etatCivil_Rappatries"].ToString();
                ra.NombreEnfants = reader["nombreEnfant_Rappatries"].ToString();
                ra.LieuNaissance = reader["lieuNaissance_Rappatries"].ToString();
                ra.NomPere = reader["nomPere_Rappatries"].ToString();
                ra.NomMere = reader["nomMere_Rappatries"].ToString();
                ra.Province = reader["province_Rappatries"].ToString();
                ra.Commune = reader["commune_Rappatries"].ToString();
                ra.DateRetour = reader["dateRetour_Rappatries"].ToString();

                rappatries.Add(ra);

            }
            reader.Close();
            conn.Close();
            return rappatries;
        }
            //============== Inserer rappatries ==============//
        public static int insererRappatries(Rappatries ra)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.Rappatries(id_Rappatries,nom_Rappatries,prenom_Rappatries,genre_Rappatries,etatCivil_Rappatries,nombreEnfant_Rappatries,lieuNaissance_Rappatries,nomPere_Rappatries,nomMere_Rappatries,province_Rappatries,commune_Rappatries,dateRetour_Rappatries) values(@id,@nom,@prenom,@genre,@etatcivil,@nbe,@lieun,@nompe,@nomme,@province,@commune,@dateret)";
            commande.Parameters.Add(new SqlParameter("@id",ra.Id));
            commande.Parameters.Add(new SqlParameter("@nom", ra.Nom));
            commande.Parameters.Add(new SqlParameter("@prenom", ra.Prenom));
            commande.Parameters.Add(new SqlParameter("@genre", ra.Genre));
            commande.Parameters.Add(new SqlParameter("@etatcivil", ra.EtatCivil));
            commande.Parameters.Add(new SqlParameter("@nbe", ra.NombreEnfants));
            commande.Parameters.Add(new SqlParameter("@lieun", ra.LieuNaissance));
            commande.Parameters.Add(new SqlParameter("@nompe", ra.NomPere));
            commande.Parameters.Add(new SqlParameter("@nomme", ra.NomMere));
            commande.Parameters.Add(new SqlParameter("@province", ra.Province));
            commande.Parameters.Add(new SqlParameter("@commune", ra.Commune));
            commande.Parameters.Add(new SqlParameter("@dateret", ra.DateRetour));


            int n = commande.ExecuteNonQuery();
            return n;

        }

        //======================Modifier Rappatries ==============//
        public static int modifierRappatries(Rappatries ra)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "update dbo.Rappatries set id_Rappatries=@id,nom_Rappatries=@nom,prenom_Rappatries=@prenom,genre_Rappatries=@genre,etatCivil_Rappatries=@etatcivil,nombreEnfant_Rappatries=@nbe,lieuNaissance_Rappatries=@lieun,nomPere_Rappatries=@nompe,nomMere_Rappatries=@nomme,province_Rappatries=@province,commune_Rappatries=@commune,dateRetour_Rappatries=@dateret where id_Rappatries=@id";
            commande.Parameters.Add(new SqlParameter("@id", ra.Id));
            commande.Parameters.Add(new SqlParameter("@nom", ra.Nom));
            commande.Parameters.Add(new SqlParameter("@prenom", ra.Prenom));
            commande.Parameters.Add(new SqlParameter("@genre", ra.Genre));
            commande.Parameters.Add(new SqlParameter("@etatcivil", ra.EtatCivil));
            commande.Parameters.Add(new SqlParameter("@nbe", ra.NombreEnfants));
            commande.Parameters.Add(new SqlParameter("@lieun", ra.LieuNaissance));
            commande.Parameters.Add(new SqlParameter("@nompe", ra.NomPere));
            commande.Parameters.Add(new SqlParameter("@nomme", ra.NomMere));
            commande.Parameters.Add(new SqlParameter("@province", ra.Province));
            commande.Parameters.Add(new SqlParameter("@commune", ra.Commune));
            commande.Parameters.Add(new SqlParameter("@dateret", ra.DateRetour));


            int n = commande.ExecuteNonQuery();
            return n;

        }

        //======================Effacer Rappatries ==============//
        public static int deleteRappatries(string id)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = " delete from dbo.Rappatries where id_Rappatries =@id ";
            commande.Parameters.AddWithValue("@id", id);


            int n = commande.ExecuteNonQuery();
            return n;
        }

        public static Rappatries getrapbyID(string idrap)
        {
            ArrayList rap = new ArrayList();
            Rappatries rapp = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Rappatries where id_Rappatries=@idrap";
            commande.Parameters.Add(new SqlParameter("@idrap", idrap));

            SqlDataReader reader = commande.ExecuteReader();


            if (reader.Read())
            {
                rapp = new Rappatries();
                rapp.Id = reader["id_Rappatries"].ToString();
                rapp.Nom = reader["nom_Rappatries"].ToString();
                rapp.Prenom = reader["prenom_Rappatries"].ToString();
                rapp.Genre = reader["genre_Rappatries"].ToString();
                rapp.EtatCivil = reader["etatCivil_Rappatries"].ToString();
                rapp.NombreEnfants = reader["nombreEnfant_Rappatries"].ToString();
                rapp.LieuNaissance = reader["lieuNaissance_Rappatries"].ToString();
                rapp.NomPere = reader["nomPere_Rappatries"].ToString();
                rapp.NomMere = reader["nomMere_Rappatries"].ToString();
                rapp.Province = reader["province_Rappatries"].ToString();
                rapp.Commune = reader["commune_Rappatries"].ToString();
                rapp.DateRetour = reader["dateRetour_Rappatries"].ToString();

                rap.Add(rapp);
 
            }
            reader.Close();
            conn.Close();
            return rapp;
        }

        //=======================AFFICHER Parcelle==============

        public static ArrayList getParcelle()
        {
            ArrayList parcelle = new ArrayList();
            Parcelle p = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Parcelle";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                p = new Parcelle();
                p.Id = reader["id_Parcelle"].ToString();
                p.Province = reader["province_Parcelle"].ToString();
                p.Commune = reader["commune_Parcelle"].ToString();
                p.Rue = reader["rue_Parcelle"].ToString();
                p.Numero = reader["numero_Parcelle"].ToString();
                p.Taille = reader["nombreAres_Parcelle"].ToString();
                p.Batie = reader["batieVraiFaux_Parcelle"].ToString();
                p.CniResident = reader["cni_Residents"].ToString();


                parcelle.Add(p);

            }

            reader.Close();
            conn.Close();
            return parcelle;

        }//=======================Fin AFFICHER Parcelle==============

        //=======================INSERER Parcelle==============

        public static int insertParcelle(Parcelle p)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.Parcelle (id_Parcelle, province_Parcelle, commune_Parcelle, rue_Parcelle, numero_Parcelle, nombreAres_Parcelle, batieVraiFaux_Parcelle)  values (@id,@prov,@com,@rue,@num,@taille,@batie)";

            commande.Parameters.Add(new SqlParameter("@id", p.Id));
            commande.Parameters.Add(new SqlParameter("@prov", p.Province));
            commande.Parameters.Add(new SqlParameter("@com", p.Commune));
            commande.Parameters.Add(new SqlParameter("@rue", p.Rue));
            commande.Parameters.Add(new SqlParameter("@num", p.Numero));
            commande.Parameters.Add(new SqlParameter("@taille", p.Taille));
            commande.Parameters.Add(new SqlParameter("@batie", p.Batie));

            int i = commande.ExecuteNonQuery();

            return i;
        }
        //=======================Fin INSERER Parcelle==============

        //=======================SUPRRIMER Parcelle==============

        public static int deleteParcelle(string id)
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "delete from dbo.Parcelle where id_Parcelle = @id";
            commande.Parameters.AddWithValue("@id", id);
            int d = commande.ExecuteNonQuery();
            return d;
        }//=======================Fin SUPRRIMER Parcelle==============

        //======================= MODIFIER Parcelle==============
        public static int modifyParcelle(Parcelle p)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "update dbo.Parcelle set id_Parcelle=@id, province_Parcelle=@prov, commune_Parcelle=@com, rue_Parcelle=@rue, numero_Parcelle=@num, nombreAres_Parcelle=@taille, batieVraiFaux_Parcelle=@batie where id_Parcelle=@id";
            commande.Parameters.Add(new SqlParameter("@id", p.Id));
            commande.Parameters.Add(new SqlParameter("@prov", p.Province));
            commande.Parameters.Add(new SqlParameter("@com", p.Commune));
            commande.Parameters.Add(new SqlParameter("@rue", p.Rue));
            commande.Parameters.Add(new SqlParameter("@num", p.Numero));
            commande.Parameters.Add(new SqlParameter("@taile", p.Taille));
            commande.Parameters.Add(new SqlParameter("@batie", p.Batie));



            int m = commande.ExecuteNonQuery();
            return m;

        }////=======================Fin MODIFIER Parcelle==============

        //=======================RECHERCHE Parcelle==============

        public static Parcelle getParcelleById(string id)
        {
            ArrayList par = new ArrayList();
            Parcelle p = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.Parcelle where id_Parcelle=@i";
            commande.Parameters.Add(new SqlParameter("@i", id));
            SqlDataReader reader = commande.ExecuteReader();

            if (reader.Read())
            {
                p = new Parcelle();

                p.Id = reader["id_Parcelle"].ToString();
                p.Province = reader["province_Parcelle"].ToString();
                p.Commune = reader["commune_Parcelle"].ToString();
                p.Rue = reader["rue_Parcelle"].ToString();
                p.Numero = reader["numero_Parcelle"].ToString();
                p.Taille = reader["nombreAres_Parcelle"].ToString();
                p.Batie = reader["batieVraiFaux_Parcelle"].ToString();
                p.CniResident = reader["cni_Residents"].ToString();

                par.Add(p);
            }

            reader.Close();
            conn.Close();
            return p;

        }//=======================END RECHERCHE RESIDENT==============
    }
}
