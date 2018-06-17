using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolidLiquid.Data;

namespace SolidLiquid.Models
{
    public class SolidLiquidContext : DbContext
    {
        public SolidLiquidContext (DbContextOptions<SolidLiquidContext> options)
            : base(options)
        {
        }

        public DbSet<SolidLiquid.Data.Clients> Clients { get; set; }
        public DbSet<SolidLiquid.Data.Deals> Deals { get; set; }
    }
}
