using Cosmos.Stores;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services
{
    public class SingleItemNavigationService<TViewModel> where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _singleItemViewNavigationStore;
        private readonly Func<TViewModel> _createSingleItemViewModel;

        public SingleItemNavigationService(NavigationStore navStore, Func<TViewModel> createViewModel)
        {
            _singleItemViewNavigationStore = navStore;
            _createSingleItemViewModel = createViewModel;
        }

        public void Navigate()
        {
            _singleItemViewNavigationStore.CurrentViewModel = _createSingleItemViewModel();
        }
    }
}
