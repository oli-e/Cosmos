using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Moon : AstronomicalObject
    {
        public UnitValue<long> DistanceFromPlanet { get; set; }

        public Moon(string name, UnitValue<long> size, UnitValue<double> mass, UnitValue<long> distanceFromEarth, UnitValue<long> distanceFromPlanet) : base(name, size, mass, distanceFromEarth)
        {
            DistanceFromPlanet = distanceFromPlanet;
        }

        public string Print()
        {
            return "Size: " + Size.Get() + " - " + Size.GetUnit();
        }
    }
}
