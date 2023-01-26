using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
	interface IFindableById
	{
		Object FindById(long id);
	}
}
