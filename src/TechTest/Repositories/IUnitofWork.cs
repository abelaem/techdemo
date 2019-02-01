using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTest.Repositories
{
    public interface IUnitofWork : IDisposable
    {
        IPersonRepository Persons { get;  }
        IColourRepository Colors { get; }
        int Complete();
    }
}
