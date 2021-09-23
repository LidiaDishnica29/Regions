using Microsoft.EntityFrameworkCore;
using RegionsTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionsTask.Context
{
    public class RegionsTaskContext : DbContext
    {
        public RegionsTaskContext(DbContextOptions<RegionsTaskContext> options) : base(options)
        {
        }
        public DbSet<Region> Regions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
