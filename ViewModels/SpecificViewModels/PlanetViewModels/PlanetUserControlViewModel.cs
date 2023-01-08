using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.PlanetViewModels
{
    internal class PlanetUserControlViewModel : BaseViewModel
    {
        private readonly PlanetObjectViewModel _planet;
        public PlanetObjectViewModel Planet
        {
            get { return _planet; }
        }
        public PlanetUserControlViewModel()
        {
            _planet = new PlanetObjectViewModel(
                    new Planet(
                        "Wojciech's Planet",
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<double>.Of(420_000, Unit.SUN_MASS),
                        UnitValue<long>.Of(200_000_000, Unit.KM),
                        UnitValue<double>.Of(1, Unit.MAGNITUDE),
                        new Declination(10, 5, 1),
                        new RightAscension(5, 3, 12)
                    )
                );
        }
    }
}
