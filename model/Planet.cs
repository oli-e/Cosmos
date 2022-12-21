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

        public Planet(string name, UnitValue<long> size, UnitValue<double> mass, UnitValue<long> distanceFromEarth) : base(name, size, mass, distanceFromEarth)
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

        public string Print()
        {
            return "I have " + Moons.Count() + " moons";
        }
    }
}
