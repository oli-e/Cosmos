using Cosmos.Services;
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
        private GetObjectPropertiesService getObjectPropertiesService = new GetObjectPropertiesService();
        public SingleItemViewViewModel(ItemRepository d,CurrentItemIDStore currentItemIDStore)
        {
            ObjectProperties.Clear();
            IdentifableObject ao = d.getItem(currentItemIDStore.CurrentItemID);
            ObjectProperties = getObjectPropertiesService.getObjectProperties(ao);
        }

        public void reloadView(ItemRepository d, int id)
        {
            ObjectProperties.Clear();
            //CommonObjectViewModel ao = d.getItem(id);
            //ObjectProperties = ao.ObjectProperties;
        }

        
    }
}
