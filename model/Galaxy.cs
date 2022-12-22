using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Galaxy : NamedObject
    {
        public List<Star> Stars { get; set; } = new List<Star>();

        public Galaxy(string name) : base(name)
        {

        }

        public void AddStar(Star star)
        {
            Stars.Add(star);
        }

        public List<Star> GetStars()
        {
            return Stars;
        }
    }
}
