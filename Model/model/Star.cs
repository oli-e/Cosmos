using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Star : AstronomicalObject, IParent<PlanetarySystem>, IRemovable
    {
        private Galaxy Galaxy { get; set; }
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
            Init();
        }

        public override void Init()
        {
            PlanetarySystems.ForEach(planetarySystem =>
            {
                planetarySystem.SetStar(this);
                planetarySystem.Init();
            });
        }

        public void SetGalaxy(Galaxy galaxy)
		{
            Galaxy = galaxy;
		}

        public PlanetarySystem GetPlanetarySystem(long id)
        {
            return FindPlanetarySystemById(id);
        }

        public void AddPlanetarySystem(PlanetarySystem planetarySystem)
        {
            PlanetarySystems.Add(planetarySystem);
            planetarySystem.SetStar(this);
        }

        public List<PlanetarySystem> GetPlanetarySystems()
        {
            return PlanetarySystems;
        }
        public void RemovePlanetarySystem(long id)
        {
            PlanetarySystems.Remove(FindPlanetarySystemById(id));
        }

        private PlanetarySystem FindPlanetarySystemById(long id)
        {
            return PlanetarySystems.Find(ps => ps.Id == id);
        }

		public List<PlanetarySystem> GetChildren()
		{
            return PlanetarySystems;
		}

        public override object FindById(long id)
        {
            foreach (PlanetarySystem planetarySystem in PlanetarySystems)
            {
                object obj = planetarySystem.FindById(id);
                if (obj != null)
                {
                    return obj;
                }
            }
            return base.FindById(id);
        }

		public override void Remove()
		{
            Galaxy.RemoveStar(Id);
		}
	}
}
