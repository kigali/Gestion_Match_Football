using Gestion_Match_FootBall.Data_Acces;
using System;
using System.Collections.ObjectModel;

namespace Gestion_Match_FootBall.ViewModel
{
    class Afficher_tous_les_Equipes : ViewModel_Base
    {
        readonly Equipe_MySQL_dataBase _equipes_from_dataBase;
        public ObservableCollection<Model.Equipe> Tous_les_equipes
        {
            get;
            private set;
        }

        public Afficher_tous_les_Equipes(Equipe_MySQL_dataBase equipes_from_dataBase)
        {
            if (equipes_from_dataBase == null)
                throw new ArgumentNullException("equipes_from_dataBase");
            _equipes_from_dataBase = equipes_from_dataBase;
            Tous_les_equipes = new ObservableCollection<Model.Equipe>(_equipes_from_dataBase.Get_Equipes());
        }
        protected override void OnDispose()
        {
            this.Tous_les_equipes.Clear();
        }
    }
}
