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
        private DataGenerator dataGenerator = new DataGenerator();
        private GalaxyDao galaxyDao = new GalaxyDao();
        
        public DummyItemsStore()
        {
            Galaxy g = dataGenerator.GenerateGalaxy();
            galaxyDao.SaveGalaxy(g);
            object o = galaxyDao.FindById(4);
            Console.WriteLine();

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
            /*new CommonObjectViewModel(new Galaxy(
                        "Milky Way",
                        UnitValue<long>.Of(130_000, Unit.KM),
                        UnitValue<long>.Of(200_000_000, Unit.KM),
                        UnitValue<double>.Of(1, Unit.MAGNITUDE),
                        new Declination(10, 5, 1),
                        new RightAscension(5, 3, 12),
                        GalaxyType.SPIRAL)
                )
            ), BasicAstronomicalObjects cannot be converted that way*/
            new CommonObjectViewModel(getSunAsObject()),
            new CommonObjectViewModel(new Moon(
                "Wojciech's Moon",
                UnitValue<long>.Of(40_000, Unit.KM),
                UnitValue<double>.Of(0.05, Unit.SUN_MASS),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12),
                UnitValue<long>.Of(350_000, Unit.KM)
                )
            ),
            new CommonObjectViewModel( new Planet(
                        "Wojciech's Planet",
                        UnitValue<long>.Of(1, Unit.KM),
                        UnitValue<double>.Of(1, Unit.SUN_MASS),
                        UnitValue<long>.Of(1, Unit.KM),
                        UnitValue<double>.Of(1, Unit.MAGNITUDE),
                        new Declination(1, 1, 1),
                        new RightAscension(1, 1, 1)
                    )
                )
            };
            
        }

        public Object getSunAsObject()
		{
            Star star= new Star(
                "Wojciech's Sun",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.SUN_MASS),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12),
                StarType.SOLAR);
            return star;
        }

        public CommonObjectViewModel getItem(int id)
        {
            return dummy_list[id];
        }
}
}
