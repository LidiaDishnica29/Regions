using Microsoft.EntityFrameworkCore;
using RegionsTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionsTask.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(
                new Region
                {
                    Id = Guid.NewGuid(),
                    Code = "001",
                    Name = "Country 1"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Code = "0011",
                    Name = "Region 2"
                },
                 new Region
                 {
                     Id = Guid.NewGuid(),
                     Code = "0012",
                     Name = "Region 3"
                 }
            ); ;
        }
    }
}
