using Cosmos.Stores;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class AddGalaxyCommand : CommandBase
    {
        private TreeViewStore _treeViewStore;
        private NavigationStore _navigationStore;
        private ItemRepository _itemRepository;
        private CurrentItemIDStore _currentItemIDStore;

        public AddGalaxyCommand(TreeViewStore treeViewStore, NavigationStore navigationStore, ItemRepository itemRepository, CurrentItemIDStore currentItemIDStore)
        {
            _treeViewStore = treeViewStore;
            _navigationStore = navigationStore;
            _currentItemIDStore = currentItemIDStore;
            _itemRepository = itemRepository;
        }
        public override void Execute(object parameter)
        {
            _itemRepository.AddGalaxy(new Galaxy(
                "Name",
                new UnitValue<long>(0, Unit.LIGHT_YEAR),
                new UnitValue<long>(0, Unit.LIGHT_YEAR),
                new UnitValue<double>(0, Unit.MAGNITUDE),
                new Declination(0, 0, 0),
                new RightAscension(0, 0, 0),
                GalaxyType.SPIRAL));
            _treeViewStore.CurrentSimpleNavigationViewModel = new SimpleNavigationViewModel(_navigationStore, _itemRepository, _treeViewStore, _currentItemIDStore);
        }
    }
}
