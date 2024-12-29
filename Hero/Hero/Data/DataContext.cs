using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hero.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hero.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet <SuperHero> SuperHeroes { get; set; }
    }

   
}