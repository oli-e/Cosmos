using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Planet : AstronomicalObject
    {
        public List<Moon> Moons { get; set; } = new List<Moon>();

        public Planet(
            string name,
            UnitValue<long> size,
            UnitValue<double> mass,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension) : base(name, size, mass, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {

        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon);
        }

        public List<Moon> GetMoons()
        {
            return Moons;
        }
    }
}
