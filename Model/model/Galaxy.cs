using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Galaxy : BasicAstronomicalObject, IParent<Star>
    {
        public List<Star> Stars { get; set; } = new List<Star>();
        public GalaxyType Type { get; set; }

        public Galaxy(
            string name,
            UnitValue<long> size,
            UnitValue<long> distanceFromEarth,
            UnitValue<double> apparentMagnitude,
            Declination declination,
            RightAscension rightAscension,
            GalaxyType type) : base(name, size, distanceFromEarth, apparentMagnitude, declination, rightAscension)
        {
            Type = type;
        }

        public Star GetStar(long id)
        {
            return FindStarById(id);
        }

        public void AddStar(Star star)
        {
            Stars.Add(star);
        }

        public List<Star> GetStars()
        {
            return Stars;
        }

        public void RemoveStar(long id)
        {
            Stars.Remove(FindStarById(id));
        }

        private Star FindStarById(long id)
        {
            return Stars.Find(s => s.Id == id);
        }

		public List<Star> GetChildren()
		{
			return Stars;
		}

        public override object FindById(long id)
        {
            foreach (Star star in Stars)
            {
                object obj = star.FindById(id);
                if (obj != null)
                {
                    return obj;
                }
            }
            return base.FindById(id);
        }

		public override void Remove()
		{
			
		}
	}
}
