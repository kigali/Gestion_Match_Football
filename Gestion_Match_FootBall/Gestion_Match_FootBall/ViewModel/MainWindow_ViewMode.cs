using Gestion_Match_FootBall.Data_Acces;
using System.Collections.ObjectModel;
using System.Windows;

namespace Gestion_Match_FootBall.ViewModel
{
    public class MainWindow_ViewMode : ViewModel_Base
    {
        private ObservableCollection<ViewModel_Base> _view_Models;
                
        // ensemble des mes models vues (instances of my view model)

        private EquipeViewModel equipe_viewModel;
        //private Afficher_tous_les_Equipes equipes;

        public MainWindow_ViewMode()
        {
            // Add my view model instance to my collection

            //equipes = new Afficher_tous_les_Equipes(equipes_from_dataBase);

            equipe_viewModel = new EquipeViewModel();

            this.ViewModels.Add(equipe_viewModel);
            
            //this.ViewModels.Add(equipes);
        }
        
        public MainWindow_ViewMode(ViewModel_Base view)
        {
            this.ViewModels.Add(view);
            this.ViewModels.Remove(equipe_viewModel);
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