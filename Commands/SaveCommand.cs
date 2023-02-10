using Cosmos.Stores;
using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cosmos.Commands
{
    public class SaveCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        private TreeViewStore _treeViewStore;
        private NavigationStore _navigationStore;
        private ItemRepository _itemRepository;
        private CurrentItemIDStore _currentItemIDStore;
        public bool CanSave { get; set; } = true;
        public SaveCommand(BaseViewModel baseViewModel,TreeViewStore treeViewStore,NavigationStore navigationStore,ItemRepository itemRepository, CurrentItemIDStore currentItemIDStore)
        {
            _baseViewModel = baseViewModel;
            _treeViewStore = treeViewStore;
            _navigationStore = navigationStore;
            _currentItemIDStore = currentItemIDStore;
            _itemRepository = itemRepository;
            System.Diagnostics.Debug.WriteLine($"Checking Types");
            System.Diagnostics.Debug.WriteLine(baseViewModel.GetType());
        }
        public override void Execute(object parameter)
        {
            if(_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.GalaxyViewModel")
            {
                GalaxyViewModel galaxyViewModel = (GalaxyViewModel)_baseViewModel;
                galaxyViewModel.Galaxy.Name = galaxyViewModel.Name;
                galaxyViewModel.Galaxy.Size.Set(galaxyViewModel.Size);

                galaxyViewModel.Galaxy.DistanceFromEarth.Set(galaxyViewModel.DistanceFromEarth);

                galaxyViewModel.Galaxy.ApparentMagnitude.Set(galaxyViewModel.ApparentMagnitude);

                galaxyViewModel.Galaxy.Declination.Degress = galaxyViewModel.DeclinationDegress;
                galaxyViewModel.Galaxy.Declination.Minutes = galaxyViewModel.DeclinationMinutes;
                galaxyViewModel.Galaxy.Declination.Seconds = galaxyViewModel.DeclinationSeconds;

                galaxyViewModel.Galaxy.RightAscension.Hours = galaxyViewModel.RightAscensionHours;
                galaxyViewModel.Galaxy.RightAscension.Minutes = galaxyViewModel.RightAscensionMinutes;
                galaxyViewModel.Galaxy.RightAscension.Seconds = galaxyViewModel.RightAscensionSeconds;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                starViewModel.Star.Name = starViewModel.Name;
                starViewModel.Star.Size.Set(starViewModel.Size);

                starViewModel.Star.DistanceFromEarth.Set(starViewModel.DistanceFromEarth);

                starViewModel.Star.ApparentMagnitude.Set(starViewModel.ApparentMagnitude);

                starViewModel.Star.Declination.Degress = starViewModel.DeclinationDegress;
                starViewModel.Star.Declination.Minutes = starViewModel.DeclinationMinutes;
                starViewModel.Star.Declination.Seconds = starViewModel.DeclinationSeconds;

                starViewModel.Star.RightAscension.Hours = starViewModel.RightAscensionHours;
                starViewModel.Star.RightAscension.Minutes = starViewModel.RightAscensionMinutes;
                starViewModel.Star.RightAscension.Seconds = starViewModel.RightAscensionSeconds;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetarySystemViewModel")
            {
                PlanetarySystemViewModel planetarySystemViewModel = (PlanetarySystemViewModel)_baseViewModel;
                planetarySystemViewModel.PlanetarySystem.Name = planetarySystemViewModel.Name;
                planetarySystemViewModel.PlanetarySystem.Size.Set(planetarySystemViewModel.Size);
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetViewModel")
            {
                PlanetViewModel planetViewModel = (PlanetViewModel)_baseViewModel;
                planetViewModel.Planet.Name = planetViewModel.Name;
                planetViewModel.Planet.Size.Set(planetViewModel.Size);
                planetViewModel.Planet.Mass.Set(planetViewModel.Mass);
                planetViewModel.Planet.DistanceFromEarth.Set(planetViewModel.DistanceFromEarth);    
                planetViewModel.Planet.ApparentMagnitude.Set(planetViewModel.ApparentMagnitude);
                planetViewModel.Planet.Declination.Degress = planetViewModel.DeclinationDegress;
                planetViewModel.Planet.Declination.Minutes = planetViewModel.DeclinationMinutes;
                planetViewModel.Planet.Declination.Seconds = planetViewModel.DeclinationSeconds;
                planetViewModel.Planet.RightAscension.Hours = planetViewModel.RightAscensionHours;
                planetViewModel.Planet.RightAscension.Minutes = planetViewModel.RightAscensionMinutes;
                planetViewModel.Planet.RightAscension.Seconds = planetViewModel.RightAscensionSeconds;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.MoonViewModel")
            {
                MoonViewModel moonViewModel = (MoonViewModel)_baseViewModel;
                moonViewModel.Moon.Name = moonViewModel.Name;
                moonViewModel.Moon.Size.Set(moonViewModel.Size);
                moonViewModel.Moon.Mass.Set(moonViewModel.Mass);
                
                moonViewModel.Moon.DistanceFromEarth.Set(moonViewModel.DistanceFromEarth);
                moonViewModel.Moon.ApparentMagnitude.Set(moonViewModel.ApparentMagnitude);

                moonViewModel.Moon.Declination.Degress = moonViewModel.DeclinationDegress;
                moonViewModel.Moon.Declination.Minutes = moonViewModel.DeclinationMinutes;
                moonViewModel.Moon.Declination.Seconds = moonViewModel.DeclinationSeconds;

                moonViewModel.Moon.RightAscension.Hours = moonViewModel.RightAscensionHours;
                moonViewModel.Moon.RightAscension.Minutes = moonViewModel.RightAscensionMinutes;
                moonViewModel.Moon.RightAscension.Seconds = moonViewModel.RightAscensionSeconds;

                moonViewModel.Moon.DistanceFromPlanet.Set(moonViewModel.DistanceFromPlanet);
            }
            _treeViewStore.CurrentSimpleNavigationViewModel = new SimpleNavigationViewModel(_navigationStore, _itemRepository, _treeViewStore, _currentItemIDStore);

        }
        public override bool CanExecute(object parameter)
        {
            return CanSave && base.CanExecute(parameter);
        }
    }
}
