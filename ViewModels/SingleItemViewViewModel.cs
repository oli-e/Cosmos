using Cosmos.Services;
using Cosmos.Stores;
using System.Collections.ObjectModel;

namespace Cosmos.ViewModels
{
    public class SingleItemViewViewModel : BaseViewModel
    {
        private ObservableCollection<CustomDictionaryClass> dict = new ObservableCollection<CustomDictionaryClass>();
        public ObservableCollection<CustomDictionaryClass> Dict
        {
            get { return dict; }
            set { dict = value; OnPropertyChanged(nameof(Dict)); }
        }

        private GetObjectPropertiesService getObjectPropertiesService = new GetObjectPropertiesService();
        public SingleItemViewViewModel(DummyItemsStore d,CurrentItemIDStore currentItemIDStore)
        {
            Dict.Clear();
            IdentifableObject ao = d.getItem(currentItemIDStore.CurrentItemID);
            Dict = getObjectPropertiesService.getObjectProperties(ao);
        }

        public void reloadView(DummyItemsStore d, int id)
        {
            Dict.Clear();
            //CommonObjectViewModel ao = d.getItem(id);
            //ObjectProperties = ao.ObjectProperties;
        }

        
    }
}
