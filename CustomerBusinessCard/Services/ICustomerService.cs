using CustomerBusinessCard.Models;
using System.Threading.Tasks;

namespace CustomerBusinessCard.Services
{
    public interface ICustomerService
    {
        Task<string> GetCustomer(int id);
        Task<Customer> GetCustomerDetails(int id);

    }
}
