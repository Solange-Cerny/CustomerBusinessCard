using CustomerBusinessCard.Data;
using CustomerBusinessCard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBusinessCard.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerBusinessCardContext _dbContext;

        public CustomerService(CustomerBusinessCardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> GetCustomer(int id)
        {
            var name = await _dbContext.Customer.Where(c => c.Id == id).Select(d => d.FullName).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Customer> GetCustomerDetails(int id)
        {
            var customer = await _dbContext.Customer.FirstOrDefaultAsync(c => c.Id == id);
            return customer;
        }
    }
}
