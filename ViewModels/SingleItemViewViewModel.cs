using Cosmos.Stores;
using Cosmos.ViewModels.ObjectViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels
{
    public class SingleItemViewViewModel : BaseViewModel
    {
        //passing the dictionary in constructor or fetching object from a store
        private Dictionary<string, string> _objectProperties = new Dictionary<string, string>();
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
        //TODO DummyItemsStore must be a refference to database
        //TODO2 change to only receive id, and fetch objects from the database
        public SingleItemViewViewModel(DummyItemsStore d,int id)
        {
            ObjectProperties.Clear();
            //TODO Switch to a DB call
            CommonObjectViewModel ao = d.getItem(id);
            ObjectProperties = ao.ObjectProperties;
        }

        public void reloadView(DummyItemsStore d, int id)
        {
            ObjectProperties.Clear();
            CommonObjectViewModel ao = d.getItem(id);
            ObjectProperties = ao.ObjectProperties;
        }
    }
}
