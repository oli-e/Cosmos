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
        private readonly DummyItemsStore _dummyItemStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public SimpleNavigationViewModel SimpleNavigationViewModel { get; set; }

        public MainWindowViewModel(DummyItemsStore d,NavigationStore navigationStore)
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
