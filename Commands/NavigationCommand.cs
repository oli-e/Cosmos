using Cosmos.Services;
using Cosmos.Stores;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationCommand(NavigationStore navStore, Func<TViewModel> createViewModel)
        {
            _navStore = navStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navStore.CurrentViewModel = _createViewModel();
        }
    }
}
