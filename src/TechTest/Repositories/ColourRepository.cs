using System.Collections.Generic;
using System.Linq;
using TechTest.Repositories.Models;

namespace TechTest.Repositories
{
    public class ColourRepository : Repository<Colour>, IColourRepository
    {
        public ColourRepository(TechDbContext context) : base(context)
        {

        }

        public TechDbContext techDbContext
        {
            get { return Context as TechDbContext; }
        }

    }
}
