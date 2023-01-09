using Cosmos.Stores;
using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using Cosmos.ViewModels.SpecificViewModels.PlanetViewModels;
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

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            SimpleNavigationViewModel = new SimpleNavigationViewModel(navigationStore);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        /*public BaseViewModel CurrentViewModel { get; }
        public MainWindowViewModel()
        {
            CurrentViewModel = new MoonUserControlViewModel();
        }*/
    }
}
