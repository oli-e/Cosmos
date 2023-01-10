using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels
{
    public class SingleItemViewViewModel : BaseViewModel
    {
        //passing the dictionary in constructor or fetching object from a store
        private Dictionary<string, string> _objectProperties;
        public Dictionary<string, string> ObjectProperties
        {
            get 
            { 
                return _objectProperties; 
            }
            set 
            { 
                _objectProperties = value; 
                OnPropertyChanged(nameof(ObjectProperties)); 
            }
        }
    }
}
