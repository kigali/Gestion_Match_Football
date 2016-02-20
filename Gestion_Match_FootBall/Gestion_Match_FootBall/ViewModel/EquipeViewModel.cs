using Gestion_Match_FootBall.Model;
using System;

namespace Gestion_Match_FootBall.ViewModel
{
    public class EquipeViewModel : ViewModel_Base
    {
        private Equipe _equipe;
        
        public EquipeViewModel()
        {
            _equipe = new Equipe();
        }
        // Let's Create properties that will bind with my UI (of creating a team)

            // The name of a team to create

        public string TeamName
        {
            get { return _equipe.NomEquipe; }
            set { _equipe.NomEquipe = value; }
        }
        
        // The scored goals of a team to create (0 by default, because the Federation creates team before the start of a season)

        public string Scored_Goals
        {
            get { return _equipe.Buts_Marques.ToString(); }
            set { _equipe.Buts_Marques = Convert.ToInt32(value); }
        }
        
        // The goals conceded of a team to create (0 by default, because the Federation creates team before the start of a season)

        public String Goals_Conceded
        {
            get { return _equipe.Buts_Encaisses.ToString(); }
            set { _equipe.Buts_Encaisses = Convert.ToInt32(value); }
        }
    }
}
