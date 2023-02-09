using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Moon : AstronomicalObject, IRemovable
    {
        private Planet Planet { get; set; }

        public UnitValue<long> DistanceFromPlanet { get; set; }

        public Moon(
            string name,
            UnitValue<long> size,
            UnitValue<double> mass,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension,
            UnitValue<long> distanceFromPlanet) : base(name, size, mass, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {
            DistanceFromPlanet = distanceFromPlanet;
        }

        public void SetPlanet(Planet planet)
		{
            Planet = planet;
        }

		public override void Remove()
		{
            Planet.RemoveMoon(Id);
		}

		public override void Init()
		{
			// Do nothing
		}
	}
}
