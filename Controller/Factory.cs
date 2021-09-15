using System;
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
        //public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=cntb;Integrated Security=True");
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QQL0BU4\\SQLEXPRESS;Initial Catalog=CNTB;Integrated Security=True");

        //=======================AFFICHER PROF==============

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

    }
}
