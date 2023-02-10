using Cosmos.Stores;
using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;

namespace Cosmos.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navStore;
        private readonly TreeViewStore _treeViewStore;
        //private readonly Func<TViewModel> _createViewModel;
        private readonly CurrentItemIDStore _currentItemIDStore;

        //to be removed
        private readonly ItemRepository itemRepository;

        public NavigationCommand(NavigationStore navStore, CurrentItemIDStore currentItemIDStore,ItemRepository itemRepository, TreeViewStore treeViewStore)
        {
            _navStore = navStore;
            //_createViewModel = createViewModel;
            _currentItemIDStore = currentItemIDStore;
            this.itemRepository = itemRepository;
            _treeViewStore = treeViewStore;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null)
            {
                System.Diagnostics.Debug.WriteLine($"Clicked: {parameter as string}");
                string id = parameter as string;
                _currentItemIDStore.CurrentItemID = int.Parse(id);
                IdentifableObject a = itemRepository.getItem(int.Parse(id));
                string typeHint = a.GetType().ToString();
                System.Diagnostics.Debug.WriteLine($"TypeHint: {typeHint}");

                if (typeHint == "Cosmos.Galaxy")
                {
                    _navStore.CurrentViewModel = new GalaxyViewModel(itemRepository,_navStore, _currentItemIDStore,_treeViewStore);
                }
                if (typeHint == "Cosmos.Star")
                {
                    _navStore.CurrentViewModel = new StarViewModel(itemRepository, _navStore, _currentItemIDStore, _treeViewStore);
                }
                //TODO rewrite remaining ViewModels
                if (typeHint == "Cosmos.Planet")
                {
                    _navStore.CurrentViewModel = new PlanetViewModel(itemRepository, _navStore, _currentItemIDStore, _treeViewStore);
                }
                if (typeHint == "Cosmos.Moon")
                {
                    _navStore.CurrentViewModel = new MoonViewModel(itemRepository, _navStore, _currentItemIDStore, _treeViewStore);
                }
                if (typeHint == "Cosmos.PlanetarySystem")
                {
                    _navStore.CurrentViewModel = new PlanetarySystemViewModel(itemRepository, _navStore, _currentItemIDStore, _treeViewStore);
                }
                //System.Diagnostics.Debug.WriteLine($"CurrentItemID: {_currentItemIDStore.CurrentItemID}");
                //TODO might be needed to add switching between views for each type
            }
            //_navStore.CurrentViewModel = new SingleItemViewViewModel(d, _currentItemIDStore);
            //_navStore.CurrentViewModel = _createViewModel();
        }
    }
}
