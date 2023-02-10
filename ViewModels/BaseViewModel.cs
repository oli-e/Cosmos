using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public bool CanSave { get; set; }
        public bool CanDiscard { get; set; } 
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
