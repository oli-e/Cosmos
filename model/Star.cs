using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Star : AstronomicalObject
    {
        public List<PlanetarySystem> PlanetarySystems { get; set; } = new List<PlanetarySystem>();
        public StarType Type { get; set; }

        public Star(
            string name,
            UnitValue<long> size,
            UnitValue<double> mass,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension,
            StarType type) : base(name, size, mass, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {
            Type = type;
        }

        public void AddPlanetarySystem(PlanetarySystem planetarySystem)
        {
            PlanetarySystems.Add(planetarySystem);
        }

        public List<PlanetarySystem> GetPlanetarySystems()
        {
            return PlanetarySystems;
        }
    }
}
