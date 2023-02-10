using Cosmos.ViewModels.SpecificObjectsViewModels;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class DeleteCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        private ItemRepository _itemRepository;
        public DeleteCommand(BaseViewModel baseViewModel, ItemRepository itemRepository)
        {
            _baseViewModel = baseViewModel;
            _itemRepository = itemRepository;
            System.Diagnostics.Debug.WriteLine($"Checking Types");
            System.Diagnostics.Debug.WriteLine(baseViewModel.GetType());
        }
        public override void Execute(object parameter)
        {
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.GalaxyViewModel")
            {
                GalaxyViewModel galaxyViewModel = (GalaxyViewModel)_baseViewModel;
                _itemRepository.RemoveItem(galaxyViewModel.Galaxy.Id);

                //galaxyViewModel.CanSave = false;
                //galaxyViewModel.CanDiscard = false;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                _itemRepository.RemoveItem(starViewModel.Star.Id);

                //starViewModel.CanSave = false;
                //starViewModel.CanDiscard = false;
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetarySystemViewModel")
            {
                PlanetarySystemViewModel planetarySystemViewModel = (PlanetarySystemViewModel)_baseViewModel;
                _itemRepository.RemoveItem(planetarySystemViewModel.PlanetarySystem.Id);

                //starViewModel.CanSave = false;
                //starViewModel.CanDiscard = false;
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetViewModel")
            {
                PlanetViewModel planetViewModel = (PlanetViewModel)_baseViewModel;
                _itemRepository.RemoveItem(planetViewModel.Planet.Id);

                //starViewModel.CanSave = false;
                //starViewModel.CanDiscard = false;
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.MoonViewModel")
            {
                MoonViewModel moonViewModel = (MoonViewModel)_baseViewModel;
                _itemRepository.RemoveItem(moonViewModel.Moon.Id);

                //starViewModel.CanSave = false;
                //starViewModel.CanDiscard = false;
            }
        }
    }
}
