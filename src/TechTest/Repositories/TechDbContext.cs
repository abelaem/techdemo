using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTest.Repositories.Models;

namespace TechTest.Repositories
{
    public class TechDbContext:DbContext
    {
       

        public DbSet<Person> Persons { get; set; }
        public DbSet<Colour> Colours { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-CGR1GD78;Database=TechTest;Trusted_Connection=True;");
        }

    }
}
