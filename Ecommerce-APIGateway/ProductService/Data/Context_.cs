using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace ApplicationDbContext__ProdctService
{
    public class Context_ : DbContext
    {
        public Context_ (DbContextOptions<Context_> options)
            : base(options)
        {
        }

        public DbSet<BusinessObjects.Product> Product { get; set; } = default!;
    }
}
