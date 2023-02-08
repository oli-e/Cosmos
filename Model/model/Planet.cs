using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Planet : AstronomicalObject, IParent<Moon>, IRemovable
    {
        private PlanetarySystem PlanetarySystem { get; set; }

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

        public void SetPlanetarySystem(PlanetarySystem planetarySystem)
		{
            PlanetarySystem = planetarySystem;
		}

        public Moon GetMoon(long id)
        {
            return FindMoonById(id);
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon);
        }

        public List<Moon> GetMoons()
        {
            return Moons;
        }

        public void RemoveMoon(long id)
        {
            Moons.Remove(FindMoonById(id));
        }

        private Moon FindMoonById(long id)
        {
            return Moons.Find(m => m.Id == id);
        }

		public List<Moon> GetChildren()
		{
            return Moons;
		}

        public override object FindById(long id)
        {
            foreach(Moon moon in Moons) {
                object obj = moon.FindById(id);
                if (obj != null)
				{
                    return obj;
				}
			}
            return base.FindById(id);
        }

		public override void Remove()
		{
            PlanetarySystem.RemovePlanet(Id);
		}
	}
}
