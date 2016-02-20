using Gestion_Match_FootBall.Model;
using System;

namespace Gestion_Match_FootBall.ViewModel
{
    class EquipeViewModel
    {
        private Equipe equipe = new Equipe();
        
        // Let's Create properties that will bind with my UI (of creating a team)

            // The name of a team to create

        public string TeamName
        {
            get { return equipe.NomEquipe; }
            set { equipe.NomEquipe = value; }
        }
        
        // The scored goals of a team to create (0 by default, because the Federation creates team before the start of a season)

        public string Scored_Goals
        {
            get { return equipe.Buts_Marques.ToString(); }
            set { equipe.Buts_Marques = Convert.ToInt32(value); }
        }
        
        // The goals conceded of a team to create (0 by default, because the Federation creates team before the start of a season)

        public String Goals_Conceded
        {
            get { return equipe.Buts_Encaisses.ToString(); }
            set { equipe.Buts_Encaisses = Convert.ToInt32(value); }
        }
    }
}
