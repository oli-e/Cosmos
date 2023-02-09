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
        //private readonly Func<TViewModel> _createViewModel;
        private readonly CurrentItemIDStore _currentItemIDStore;

        //to be removed
        private readonly DummyItemsStore d;

        public NavigationCommand(NavigationStore navStore, CurrentItemIDStore currentItemIDStore,DummyItemsStore d)
        {
            _navStore = navStore;
            //_createViewModel = createViewModel;
            _currentItemIDStore = currentItemIDStore;
            this.d = d;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null)
            {
                //System.Diagnostics.Debug.WriteLine($"Clicked: {parameter as string}");
                string id = parameter as string;
                _currentItemIDStore.CurrentItemID = int.Parse(id);
                //System.Diagnostics.Debug.WriteLine($"CurrentItemID: {_currentItemIDStore.CurrentItemID}");
                //TODO might be needed to add switching between views for each type
            }
            _navStore.CurrentViewModel = new SingleItemViewViewModel(d, _currentItemIDStore);
            //_navStore.CurrentViewModel = _createViewModel();
        }
    }
}
