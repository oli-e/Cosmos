using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class PlanetarySystem : BasicAstronomicalObject, IParent<Planet>, IRemovable
    {
        private Star Star { get; set; }

        public List<Planet> Planets { get; set; } = new List<Planet>();

        public PlanetarySystem(
            string name,
            UnitValue<long> size,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension) : base(name, size, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {
            Init();
        }
        public override void Init()
        {
            Planets.ForEach(planet =>
            {
                planet.SetPlanetarySystem(this);
                planet.Init();
            });
        }

        public void SetStar(Star star)
		{
            Star = star;
		}

        public Planet GetPlanet(long id)
        {
            return FindPlanetById(id);
        }

        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
            planet.SetPlanetarySystem(this);
        }

        public List<Planet> GetPlanets()
        {
            return Planets;
        }

        public void RemovePlanet(long id)
        {
            Planets.Remove(FindPlanetById(id));
        }

        private Planet FindPlanetById(long id)
        {
            return Planets.Find(p => p.Id == id);
        }

		public List<Planet> GetChildren()
		{
            return Planets;
		}

        public override object FindById(long id)
        {
            foreach (Planet planet in Planets)
            {
                object obj = planet.FindById(id);
                if (obj != null)
                {
                    return obj;
                }
            }
            return base.FindById(id);
        }

		public override void Remove()
		{
            Star.RemovePlanetarySystem(Id);
		}
	}
}
