using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class AddChildCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        public AddChildCommand(BaseViewModel baseViewModel)
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
                galaxyViewModel.Galaxy.AddStar(new Star(
                    "Empty Name",
                    new UnitValue<long>(0, Unit.SUN_MASS),
                    new UnitValue<double>(0, Unit.SUN_MASS),
                    new UnitValue<long>(0, Unit.KM),
                    new UnitValue<double>(0, Unit.MAGNITUDE),
                    new Declination(0, 0, 0),
                    new RightAscension(0, 0, 0),
                    StarType.SOLAR));
                System.Diagnostics.Debug.WriteLine($"Created new Star in Galaxy");
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                starViewModel.Star.AddPlanetarySystem(new PlanetarySystem(
                    "Name",
                    new UnitValue<long>(0,Unit.KM)));
                System.Diagnostics.Debug.WriteLine($"Created new Planetary System in Star");
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetarySystemViewModel")
            {
                PlanetarySystemViewModel planetarySystemViewModel = (PlanetarySystemViewModel)_baseViewModel;
                planetarySystemViewModel.PlanetarySystem.AddPlanet(
                    new Planet(
                        "Name",
                        new UnitValue<long>(0, Unit.KM),
                        new UnitValue<double>(0, Unit.SUN_MASS),
                        new UnitValue<long>(0, Unit.KM),
                        new UnitValue<double>(0, Unit.MAGNITUDE),
                        new Declination(0, 0, 0),
                        new RightAscension(0, 0, 0)));
                System.Diagnostics.Debug.WriteLine($"Created new Planetary System in Star");
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.PlanetViewModel")
            {
                PlanetViewModel planetViewModel = (PlanetViewModel)_baseViewModel;
                planetViewModel.Planet.AddMoon(
                    new Moon(
                        "Name",
                        new UnitValue<long>(0, Unit.KM),
                        new UnitValue<double>(0, Unit.SUN_MASS),
                        new UnitValue<long>(0, Unit.KM),
                        new UnitValue<double>(0, Unit.MAGNITUDE),
                        new Declination(0, 0, 0),
                        new RightAscension(0, 0, 0),
                        new UnitValue<long>(0,Unit.KM))
                    );
                System.Diagnostics.Debug.WriteLine($"Created new Planetary System in Star");
            }
        }
    }
}
