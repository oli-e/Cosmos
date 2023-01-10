using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.AstronomicalObjectViewMiodels
{
    public class AstronomicalObjectUserControlViewModel : BaseViewModel
    {
        private readonly AstronomicalObjectObjectViewModel _astronomicalObject;

        public AstronomicalObjectObjectViewModel AstronomicalObject
        {
            get { return _astronomicalObject; }
        }
        public AstronomicalObjectUserControlViewModel()
        {
            /*_astronomicalObject = new AstronomicalObjectObjectViewModel(
                    new AstronomicalObject(
                        "Wojciech's Moon",
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<double>.Of(420_000, Unit.SUN_MASS),
                        UnitValue<long>.Of(200_000_000, Unit.KM),
                        UnitValue<double>.Of(1, Unit.MAGNITUDE),
                        new Declination(10, 5, 1),
                        new RightAscension(5, 3, 12),
                        UnitValue<long>.Of(130_000, Unit.KM)
                    )
                );
            */
        }
    }
}
