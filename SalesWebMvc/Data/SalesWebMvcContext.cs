#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Department> Department { get; set; }
        public DbSet<Entities.Seller> Seller { get; set; }
        public DbSet<Entities.SalesRecord> SalesRecord { get; set; }
    }
}
