using System;
using System.ComponentModel;
namespace Gestion_Match_FootBall.ViewModel
{
    public abstract class ViewModel_Base : INotifyPropertyChanged, IDisposable
    {
        public ViewModel_Base() { }

        public event PropertyChangedEventHandler PropertyChanged;

        // Abstract method that All my ViewModel will need to override, when they want to handle the change of their view (on their UI)
      
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if(handler != null)
            {
                var e = new PropertyChangedEventArgs (propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose() { }
    }
}
