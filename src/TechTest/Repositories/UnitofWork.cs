using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTest.Repositories
{
    public class UnitofWork:IUnitofWork
    {
        
        
        private TechDbContext _context;
        public UnitofWork()
        {
            _context = new TechDbContext();
            Persons = new PersonRepository(_context);
            Colors = new ColourRepository(_context);
        }

        public IPersonRepository Persons { get; }
        public IColourRepository Colors { get; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
}
