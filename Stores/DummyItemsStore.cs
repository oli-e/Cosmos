using Cosmos.Commands;
using Cosmos.ViewModels.ObjectViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
    public class DummyItemsStore
    {
        public List<CommonObjectViewModel> dummy_list;
        public DummyItemsStore()
        {
            dummy_list = new List<CommonObjectViewModel>()
            {
            new CommonObjectViewModel( new Planet(
                        "Wojciech's Planet",
                        UnitValue<long>.Of(1, Unit.KM),
                        UnitValue<double>.Of(1, Unit.SUN_MASS),
                        UnitValue<long>.Of(1, Unit.KM),
                        UnitValue<double>.Of(1, Unit.MAGNITUDE),
                        new Declination(1, 1, 1),
                        new RightAscension(1, 1, 1)
                    )
                ),
            new CommonObjectViewModel(new Moon(
                        "Wojciech's Moon",
                        UnitValue<long>.Of(2, Unit.KM),
                        UnitValue<double>.Of(2, Unit.SUN_MASS),
                        UnitValue<long>.Of(2, Unit.KM),
                        UnitValue<double>.Of(2, Unit.MAGNITUDE),
                        new Declination(2, 2, 2),
                        new RightAscension(2, 2, 2),
                        UnitValue<long>.Of(2, Unit.KM)
                    )
                )
            };
        }

        public CommonObjectViewModel getItem(int id)
        {
            return dummy_list[id];
        }
}
}
