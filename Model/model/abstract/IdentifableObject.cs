using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public abstract class IdentifableObject : IFindableById
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

		public virtual object FindById(long id)
		{
            return Id == id ? this : null;
        }

        public abstract void Remove();
    }
}
