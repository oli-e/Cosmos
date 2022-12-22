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

        public Star(string name, UnitValue<long> size, UnitValue<double> mass, UnitValue<long> distanceFromEarth) : base(name, size, mass, distanceFromEarth)
        {

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
