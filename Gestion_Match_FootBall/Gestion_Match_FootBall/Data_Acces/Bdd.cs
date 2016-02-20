using Gestion_Match_FootBall.Model;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Gestion_Match_FootBall.Data_Acces
{
    public class Bdd
    {
        private MySqlConnection connection;

        // Constructeur
        public Bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=footballmanagment; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        // Méthode pour ajouter un But d'un joueur
        public void AddBut(But but)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO but (ID_BUT, ID_JOUEUR, ID_MATCH, MIN_MARQUE) VALUES (@id_but, @id_joueur, @id_match, @min_marque)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id_but", but.ID_BUT);
                cmd.Parameters.AddWithValue("@id_joueur", but.ID_JOUEUR);
                cmd.Parameters.AddWithValue("@id_match", but.ID_MATCH);
                cmd.Parameters.AddWithValue("@min_marque", but.MIN_MARQUE);
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                // Fermeture de la connexion
                this.connection.Close();
            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                MessageBox.Show("problème de creation d'un but");
            }
        }
    }
}
