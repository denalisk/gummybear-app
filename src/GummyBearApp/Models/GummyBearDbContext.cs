using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GummyBearApp.Models;

namespace GummyBearApp.Models
{
    public class GummyBearDbContext : DbContext
    {
        public GummyBearDbContext()
        {

        }

        public DbSet<GummyBear> GummyBear { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearDb;integrated security=True");
        }

        public GummyBearDbContext(DbContextOptions<GummyBearDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
