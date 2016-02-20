using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Match_FootBall.Model
{
    public class Equipe
    {
        public string NomEquipe { get; set; }
        public int Buts_Marques { get; set; }
        public int Buts_Encaisses { get; set; }
        public Equipe(string nomEquipe, int but_marques, int but_encasisses)
        {
            this.NomEquipe = nomEquipe;
            this.Buts_Marques = but_marques;
            this.Buts_Encaisses = but_encasisses;
        }
        public Equipe() { }
    }
}