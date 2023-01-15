using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public abstract class BasicAstronomicalObject : NamedObject
    {
        public UnitValue<long> Size { get; set; }

        public UnitValue<long> DistanceFromEarth { get; set; }

        public UnitValue<double> ApparentMagnitude { get; set; }

        public Declination Declination { get; set; }

        public RightAscension RightAscension { get; set; }

        protected BasicAstronomicalObject(
            string name,
            UnitValue<long> size,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension) : base(name)
        {
            Size = size;
            DistanceFromEarth = distanceFromEarth;
            ApparentMagnitude = apparentMagnitude;
            Declination = declination;
            RightAscension = rightAscension;
        }
    }
}
