using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Mission1AP3
{
    public class BaseDeDonnees
    {
        //classe métier centrée les échanges avec la base de données.
       
        //Paramètre de classe sur la connexion
        private MySqlConnection laConnexion;

        public BaseDeDonnees(string nomServeur, string nomBDD, string numeroPort, string nomUtilisateur, string MDP)
        {
            //explication de Try et Catch
            try
            {
                
                //construction de la chaine de connexion pour se connecter sur la base de données
                string maChaineConnexion = "";
                {
                     maChaineConnexion = "server=" + nomServeur + ";Database=" + nomBDD + ";port=" + numeroPort + ";uid=" + nomUtilisateur + ";pwd=" + MDP;
                }
                laConnexion = new MySqlConnection();
                laConnexion.ConnectionString = maChaineConnexion;
                laConnexion.Open();
                //on ouvre une connexion à la base de données
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                laConnexion = null;
            }
        }

        public void Connexion(string identifiant, string motDepasse)
        {
            try
            {
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                SqlConnection conn;

                maRequete = "SELECT nom, , nom, code_postal, population_2012, surface FROM ville Limit 50";

            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void chargerVille(ListBox uneListe , int nbMaxVille)
        {
            //méthode permettant de construire une Liste de Ville à partir des données récupérées depuis la base de données. 
            try
            {
                //on utilise les outils MySQL pour effectuer les requêtes.
                string maRequete;
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                SqlConnection conn;

                //on commence par netoyer la liste s'il y a des éléments déjà présent.
                uneListe.Items.Clear();

                uneListe.Items.Add("id slug nom code_postal  population_2012 surface");

                maRequete = "SELECT id, slug, nom, code_postal, population_2012, surface FROM ville Limit " + nbMaxVille;

                maCommande = new MySqlCommand(maRequete, laConnexion);

                mesResultats = maCommande.ExecuteReader();
                //pour chaque Ligne retournée par la requete , nous allons remplir la liste des Villes
                while (mesResultats.Read())
                {
                    uneListe.Items.Add(mesResultats.GetInt32("id") + " " + mesResultats.GetString("slug") + " " + mesResultats.GetString("nom") + " " + mesResultats.GetString("code_postal") + " " + mesResultats.GetInt32("population_2012").ToString() + " " + mesResultats.GetInt32("surface").ToString());
                }
                mesResultats.Close();
            }
            catch (System.Exception erreur)
            {
                uneListe.Items.Add("Erreur");
            }
        }
    }
}
