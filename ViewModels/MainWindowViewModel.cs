using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        //TODO
        private readonly DummyItemsStore _dummyItemStore; // To be replaced
        //private readonly CurrentItemStore _currentItemStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public SimpleNavigationViewModel SimpleNavigationViewModel { get; set; }

        public MainWindowViewModel(DummyItemsStore d,NavigationStore navigationStore) //CurrentItemStore
        {
            _navigationStore = navigationStore;
            _dummyItemStore = d;
            SimpleNavigationViewModel = new SimpleNavigationViewModel(navigationStore,d);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
