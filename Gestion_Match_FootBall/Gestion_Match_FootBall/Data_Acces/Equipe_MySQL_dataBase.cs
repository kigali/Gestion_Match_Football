using Gestion_Match_FootBall.Model;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Gestion_Match_FootBall.Data_Acces
{
    public class Equipe_MySQL_dataBase
    {
        private Bdd _bd;

        public Equipe_MySQL_dataBase()
        {
            _bd = new Bdd();
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
                //MessageBox.Show(equipe.NomEquipe);
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
    }
}
