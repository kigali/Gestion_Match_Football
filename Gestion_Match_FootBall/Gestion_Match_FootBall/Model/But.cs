using System;
namespace Gestion_Match_FootBall.Model
{
    public class But
    {
        public int ID_BUT { get; set; }
        public int ID_JOUEUR { get; set; }
        public int ID_MATCH { get; set; }
        public DateTime MIN_MARQUE { get; set; }
        public But( Joueur buteur, Match match, DateTime minute)
        {
            this.ID_JOUEUR = buteur.ID_JOUEUR;
            this.ID_MATCH = match.ID_MATCH;
            MIN_MARQUE = minute;
        }
    }
}
