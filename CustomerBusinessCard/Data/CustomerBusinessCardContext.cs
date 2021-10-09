using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerBusinessCard.Models;

namespace CustomerBusinessCard.Data
{
    public class CustomerBusinessCardContext : DbContext
    {
        public CustomerBusinessCardContext (DbContextOptions<CustomerBusinessCardContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerBusinessCard.Models.Customer> Customer { get; set; }

        public DbSet<CustomerBusinessCard.Models.Address> Address { get; set; }
    }
}
