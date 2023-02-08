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

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public SimpleNavigationViewModel SimpleNavigationViewModel { get; set; }

        public MainWindowViewModel(DummyItemsStore d,NavigationStore navigationStore, CurrentItemIDStore currentItemIDStore) //CurrentItemStore
        {
            _navigationStore = navigationStore;
            SimpleNavigationViewModel = new SimpleNavigationViewModel(navigationStore,d, currentItemIDStore);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
