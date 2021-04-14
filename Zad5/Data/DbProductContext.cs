using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad5.Models;

namespace Zad5.Data
{
    public class DbProductContext : DbContext
    {
        public DbProductContext(DbContextOptions options) : base(options) { }
        public DbSet<DbProduct> DbProduct { get; set; }
    }
}
