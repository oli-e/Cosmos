using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.GalaxyViewModels
{
    public class GalaxyUserControlViewModel : BaseViewModel
    {
        private readonly GalaxyObjectViewModel _galaxy;
        public GalaxyObjectViewModel Object
        {
            get { return _galaxy; }
        }
        public GalaxyUserControlViewModel()
        {
            _galaxy = new GalaxyObjectViewModel(
                    new Galaxy(
                        "Wojciech's Galaxy",
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<long>.Of(200_000_000, Unit.KM),
                        UnitValue<double>.Of(420_000, Unit.KM),
                        new Declination(10, 5, 1),
                        new RightAscension(5, 3, 12),
                        GalaxyType.SPIRAL
                    )
                );

        }
    }
}
