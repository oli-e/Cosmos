using Cosmos.ViewModels.SpecificObjectsViewModels;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;

namespace Cosmos.Commands
{
    public class DiscardChangesCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        public DiscardChangesCommand(BaseViewModel baseViewModel)
        {
            _baseViewModel = baseViewModel;
            System.Diagnostics.Debug.WriteLine($"Checking Types");
            System.Diagnostics.Debug.WriteLine(baseViewModel.GetType());
        }
        public override void Execute(object parameter)
        {
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.GalaxyViewModel")
            {
                GalaxyViewModel galaxyViewModel = (GalaxyViewModel)_baseViewModel;
                galaxyViewModel.Name = galaxyViewModel.Galaxy.Name;
                galaxyViewModel.Size = galaxyViewModel.Galaxy.Size.Get();
                galaxyViewModel.DistanceFromEarth = galaxyViewModel.Galaxy.DistanceFromEarth.Get();
                galaxyViewModel.ApparentMagnitude = galaxyViewModel.Galaxy.ApparentMagnitude.Get();
                galaxyViewModel.DeclinationDegress = galaxyViewModel.Galaxy.Declination.Degress;
                galaxyViewModel.DeclinationMinutes = galaxyViewModel.Galaxy.Declination.Minutes;
                galaxyViewModel.DeclinationSeconds = galaxyViewModel.Galaxy.Declination.Seconds;
                galaxyViewModel.RightAscensionHours = galaxyViewModel.Galaxy.RightAscension.Hours;
                galaxyViewModel.RightAscensionMinutes = galaxyViewModel.Galaxy.RightAscension.Minutes;
                galaxyViewModel.RightAscensionSeconds = galaxyViewModel.Galaxy.RightAscension.Seconds;
                galaxyViewModel.Type = galaxyViewModel.Galaxy.Type.ToString();

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                starViewModel.Name = starViewModel.Star.Name;
                starViewModel.Size = starViewModel.Star.Size.Get();
                starViewModel.Mass = starViewModel.Star.Mass.Get();
                starViewModel.DistanceFromEarth = starViewModel.Star.DistanceFromEarth.Get();
                starViewModel.ApparentMagnitude = starViewModel.Star.ApparentMagnitude.Get();
                starViewModel.DeclinationDegress = starViewModel.Star.Declination.Degress;
                starViewModel.DeclinationMinutes = starViewModel.Star.Declination.Minutes;
                starViewModel.DeclinationSeconds = starViewModel.Star.Declination.Seconds;
                starViewModel.RightAscensionHours = starViewModel.Star.RightAscension.Hours;
                starViewModel.RightAscensionMinutes = starViewModel.Star.RightAscension.Minutes;
                starViewModel.RightAscensionSeconds = starViewModel.Star.RightAscension.Seconds;
                starViewModel.Type = starViewModel.Star.Type.ToString();

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetarySystemViewModel")
            {
                PlanetarySystemViewModel planetarySystemViewModel = (PlanetarySystemViewModel)_baseViewModel;
                planetarySystemViewModel.Name = planetarySystemViewModel.PlanetarySystem.Name;
                planetarySystemViewModel.Size = planetarySystemViewModel.PlanetarySystem.Size.Get();
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetViewModel")
            {
                PlanetViewModel planetViewModel = (PlanetViewModel)_baseViewModel;
                planetViewModel.Name = planetViewModel.Planet.Name;
                planetViewModel.Size = planetViewModel.Planet.Size.Get();
                planetViewModel.Mass = planetViewModel.Planet.Mass.Get();
                planetViewModel.DistanceFromEarth = planetViewModel.Planet.DistanceFromEarth.Get();
                planetViewModel.ApparentMagnitude = planetViewModel.Planet.ApparentMagnitude.Get();
                planetViewModel.DeclinationDegress = planetViewModel.Planet.Declination.Degress;
                planetViewModel.DeclinationMinutes = planetViewModel.Planet.Declination.Minutes;
                planetViewModel.DeclinationSeconds = planetViewModel.Planet.Declination.Seconds;
                planetViewModel.RightAscensionHours = planetViewModel.Planet.RightAscension.Hours;
                planetViewModel.RightAscensionMinutes = planetViewModel.Planet.RightAscension.Minutes;
                planetViewModel.RightAscensionSeconds = planetViewModel.Planet.RightAscension.Seconds;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.MoonViewModel")
            {
                MoonViewModel moonViewModel = (MoonViewModel)_baseViewModel;
                moonViewModel.Name = moonViewModel.Moon.Name;
                moonViewModel.Size = moonViewModel.Moon.Size.Get();
                moonViewModel.Mass = moonViewModel.Moon.Mass.Get();
                moonViewModel.DistanceFromEarth = moonViewModel.Moon.DistanceFromEarth.Get();
                moonViewModel.ApparentMagnitude = moonViewModel.Moon.ApparentMagnitude.Get();
                moonViewModel.DeclinationDegress = moonViewModel.Moon.Declination.Degress;
                moonViewModel.DeclinationMinutes = moonViewModel.Moon.Declination.Minutes;
                moonViewModel.DeclinationSeconds = moonViewModel.Moon.Declination.Seconds;
                moonViewModel.RightAscensionHours = moonViewModel.Moon.RightAscension.Hours;
                moonViewModel.RightAscensionMinutes = moonViewModel.Moon.RightAscension.Minutes;
                moonViewModel.RightAscensionSeconds = moonViewModel.Moon.RightAscension.Seconds;
                moonViewModel.DistanceFromPlanet = moonViewModel.Moon.DistanceFromPlanet.Get();
                
            }

            //TODO remaining objects

            //throw new NotImplementedException();
        }
        /*public override bool CanExecute(object parameter)
        {
            return _baseViewModel.CanDiscard;
        }*/
    }
}
