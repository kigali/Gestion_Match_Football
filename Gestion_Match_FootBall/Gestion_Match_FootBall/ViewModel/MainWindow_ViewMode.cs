using Gestion_Match_FootBall.Data_Acces;
using System.Collections.ObjectModel;

namespace Gestion_Match_FootBall.ViewModel
{
    public class MainWindow_ViewMode : ViewModel_Base
    {
        readonly Equipe_MySQL_dataBase equipes_from_dataBase;
        private ObservableCollection<ViewModel_Base> _view_Models;
        public MainWindow_ViewMode()
        {
            equipes_from_dataBase = new Equipe_MySQL_dataBase();

            // create an instance of my view model and add it to my collection 

            Afficher_tous_les_Equipes equipes = new Afficher_tous_les_Equipes(equipes_from_dataBase);
            EquipeViewModel equipe_viewModel = new EquipeViewModel();
               
            this.ViewModels.Add(equipe_viewModel);
        } 

        public ObservableCollection<ViewModel_Base> ViewModels
        {
            get
            {
                if (_view_Models == null)
                {
                    _view_Models = new ObservableCollection<ViewModel_Base>();
                }
                return _view_Models;
            }
        }
    }
}
