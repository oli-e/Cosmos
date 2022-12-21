using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class AstronomicalObject
    {
        protected AstronomicalObject(string name, UnitValue<long> size, UnitValue<double> mass, UnitValue<long> distanceFromEarth)
        {
            Name = name;
            Size = size;
            Mass = mass;
            DistanceFromEarth = distanceFromEarth;
        }

        public string Name { get; set; }
        public UnitValue<long> Size { get; set; }
        public UnitValue<double> Mass { get; set; }
        public UnitValue<long> DistanceFromEarth { get; set; }
    }
}
