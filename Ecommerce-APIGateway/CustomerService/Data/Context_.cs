using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace ApplicatioDbContext__CustomerService
{
    public class Context_ : DbContext
    {
        public Context_ (DbContextOptions<Context_> options)
            : base(options)
        {
        }

        public DbSet<BusinessObjects.Customer> Customer { get; set; } = default!;
    }
}
