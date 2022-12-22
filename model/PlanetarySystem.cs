using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class PlanetarySystem : NamedObject
    {
        public List<Planet> Planets { get; set; } = new List<Planet>();

        public PlanetarySystem(string name) : base(name)
        {

        }

        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }

        public List<Planet> GetPlanets()
        {
            return Planets;
        }
    }
}
