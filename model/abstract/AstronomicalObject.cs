using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public abstract class AstronomicalObject : BasicAstronomicalObject
    {

        public UnitValue<double> Mass { get; set; }

        protected AstronomicalObject(
            string name,
            UnitValue<long> size,
            UnitValue<double> mass,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension) : base(name, size, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {
            Mass = mass;
        }
    }
}
