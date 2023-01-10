using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.BasicAstronomicalObjectViewModels
{
    public class BasicAstronomicalUserControlViewModel : BaseViewModel
    {
        private readonly BasicAstronomicalObjectViewModel _object;
        public BasicAstronomicalObjectViewModel Object
        {
            get { return _object; }
        }
        public BasicAstronomicalUserControlViewModel()
        {
            /*_object = new BasicAstronomicalObjectViewModel(
                    new Galaxy(
                        "Wojciech's Moon",
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<double>.Of(420_000, Unit.SUN_MASS),
                        new Declination(10, 5, 1),
                        new RightAscension(5, 3, 12),
                        GalaxyType.SPIRAL)
                    );
                );*/

        }
    }
}
