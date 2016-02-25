using System;
using Gestion_Match_FootBall.Data_Acces;
using Gestion_Match_FootBall.Model;
using System.Windows.Input;

namespace Gestion_Match_FootBall.ViewModel
{
    public class EquipeViewModel : ViewModel_Base
    {
        private Equipe_MySQL_dataBase _equipe_MySQL_dataBase;
        private Equipe _equipe;

        // create a command that i will bind to my User Interface

        RelayCommand _dataFromUI;

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
            set { _equipe.Buts_Marques = Convert.ToInt16(value); }
        }

        // The goals conceded of a team to create (0 by default, because the Federation creates team before the start of a season)

        public String Goals_Conceded
        {
            get { return _equipe.Buts_Encaisses.ToString(); }
            set { _equipe.Buts_Encaisses = Convert.ToInt32(value); }
        }

        public ICommand DataFromUI
        {
            get
            {
                if (_dataFromUI == null)
                {
                    _dataFromUI = new RelayCommand (Param => this.DataFromUIcommandExecute(), Param => this.DataFromUICanExecute);
                }
                return _dataFromUI;
            }
        }
        public void DataFromUIcommandExecute()
        {
            //MessageBox.Show(_equipe.Buts_Marques.ToString());

            // Insert team's data in MySQL dataBase

            _equipe_MySQL_dataBase = new Equipe_MySQL_dataBase();

            _equipe_MySQL_dataBase.Create_Equipe(_equipe);
        }
        public bool DataFromUICanExecute
        {
            get
            {
                // predicate for weather to execute command or not

                return true;
            } 
        }
    }
}