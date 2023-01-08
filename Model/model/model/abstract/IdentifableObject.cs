using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public abstract class IdentifableObject
    {
        protected IdentifableObject(long id)
        {
            Id = id;
        }

        protected IdentifableObject()
        {
            Id = GlobalIdentificatorProvider.GetInstance().Get();
        }

        public long Id { get; set; }
    }
}
