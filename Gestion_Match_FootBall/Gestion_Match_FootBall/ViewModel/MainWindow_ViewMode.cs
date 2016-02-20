﻿using System.Collections.ObjectModel;
using Gestion_Match_FootBall.Data_Acces;

namespace Gestion_Match_FootBall.ViewModel
{
    public class MainWindow_ViewMode : ViewModel_Base
    {
        readonly EquipesRepository _equipesRepository;
        private ObservableCollection<ViewModel_Base> _view_Models;
        public MainWindow_ViewMode()
        {
            _equipesRepository = new EquipesRepository();
             // create an instance of my view model and add it to my collection 
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