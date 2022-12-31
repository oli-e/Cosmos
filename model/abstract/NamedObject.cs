using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public abstract class NamedObject : IdentifableObject
    {
        protected NamedObject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
