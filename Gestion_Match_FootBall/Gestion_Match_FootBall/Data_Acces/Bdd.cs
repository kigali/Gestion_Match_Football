using Gestion_Match_FootBall.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace Gestion_Match_FootBall.Data_Acces
{
    public class Bdd
    {
        private MySqlConnection _connection;

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
            _connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection
        {
            get
            {
                if(_connection == null) 
                    throw new ArgumentNullException("Conection");
                return _connection;
            }
        }
    }
}
