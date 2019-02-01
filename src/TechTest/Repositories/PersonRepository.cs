using System;
using System.Collections.Generic;
using System.Linq;
using TechTest.Repositories.Models;

namespace TechTest.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(TechDbContext context) : base(context)
        {
           
        }

        public TechDbContext techDbContext
        {
            get { return Context as TechDbContext; }
        }
    }
}
