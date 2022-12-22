using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class PlanetarySystem : BasicAstronomicalObject
    {
        public List<Planet> Planets { get; set; } = new List<Planet>();

        public PlanetarySystem(
            string name,
            UnitValue<long> size,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension) : base(name, size, distanceFromEarth, apparentMagnitude, declination, rightAscension)
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
