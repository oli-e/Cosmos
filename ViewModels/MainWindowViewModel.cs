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
        private readonly TreeViewStore _treeViewStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public SimpleNavigationViewModel SimpleNavigationViewModel => _treeViewStore.CurrentSimpleNavigationViewModel;

        public MainWindowViewModel(ItemRepository d,NavigationStore navigationStore,TreeViewStore treeViewStore, CurrentItemIDStore currentItemIDStore) //CurrentItemStore
        {
            _navigationStore = navigationStore;
            _treeViewStore = treeViewStore;
            _treeViewStore.CurrentNavigationViewChanged += OnCurrentNavigationModelChanged;
            //SimpleNavigationViewModel = new SimpleNavigationViewModel(navigationStore,d, currentItemIDStore);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void OnCurrentNavigationModelChanged()
        {
            OnPropertyChanged(nameof(SimpleNavigationViewModel));
        }

    }
}
