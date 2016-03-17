using Gestion_Match_FootBall.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;
using System.Data.SqlClient;

namespace Gestion_Match_FootBall.Data_Acces
{
    public class Equipe_MySQL_dataBase
    {
        private Bdd _bd;
        private List <Equipe> _equipes;
        private Equipe equipe_from_dataBase;

        public Equipe_MySQL_dataBase()
        {
            _bd = new Bdd();

            if (_equipes == null)
                _equipes = new List<Equipe>();

            // All team from MySQL dataBase

            this.Equipes_DataBase();
        }

        public void Equipes_DataBase()
        {
            try
            {
                // Ouverture de la connexion SQL
                _bd.Connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection

                MySqlCommand cmd = _bd.Connection.CreateCommand();

                // Requête SQL

                cmd.CommandText = "SELECT * FROM Equipe";

                // Exécution de la commande SQL
                    
                MySqlDataReader reader = cmd.ExecuteReader();

                // Data From MySQL dataBase

                while (reader.Read())
                {
                    equipe_from_dataBase = new Equipe();
                    equipe_from_dataBase.NomEquipe = reader.GetString(1);
                    equipe_from_dataBase.Buts_Marques = reader.GetInt16(2);
                    equipe_from_dataBase.Buts_Encaisses = reader.GetInt16(3);
                    _equipes.Add(equipe_from_dataBase);
                }
                
                // Fermeture de la connexion

                _bd.Connection.Close();
            }
            catch (MySqlException exception)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si l'équipe à été ajouté correctement.
                MessageBox.Show(exception.ToString());
            }

        }

        // Méthode pour créer une équipe

        public void Create_Equipe(Equipe equipe)
        {
            try
            {
                // Ouverture de la connexion SQL
                _bd.Connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection

                MySqlCommand cmd = _bd.Connection.CreateCommand();

                // Requête SQL

                cmd.CommandText = "INSERT INTO Equipe (ID_EQUIPE, NOM, BUTS_MARQUES, BUTS_ENCAISSES) VALUES (null, @nom_equipe, @buts_marques, @buts_encaisses)";

                // utilisation de l'objet Equipe passé en paramètre
                cmd.Parameters.AddWithValue("@nom_equipe", equipe.NomEquipe);
                cmd.Parameters.AddWithValue("@buts_marques", equipe.Buts_Marques);
                cmd.Parameters.AddWithValue("@buts_encaisses", equipe.Buts_Encaisses);

                // Exécution de la commande SQL

                cmd.ExecuteNonQuery();

                // Fermeture de la connexion

                _bd.Connection.Close();
            }
            catch ( MySqlException exception)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si l'équipe à été ajouté correctement.
                MessageBox.Show(exception.ToString());
            }
        }
        // 
        public List<Equipe> Get_Equipes()
        {
            return new List<Equipe>(_equipes);
        }
    }
}
