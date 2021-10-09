using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerBusinessCard.Data;
using CustomerBusinessCard.Models;
using CustomerBusinessCard.Services;

namespace CustomerBusinessCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        // GET: api/Customers/5
        [HttpGet("GetCustomer/{id}")]
        public async Task<ActionResult<string>> GetCustomer(int id)
        {
            string fullName = await _service.GetCustomer(id);

            if (string.IsNullOrWhiteSpace(fullName))
            {
                return NotFound();
            }

            return fullName;
        }

        // GET: api/GetCustomerDetails/5
        [HttpGet("GetCustomerDetails/{id}")]
        public async Task<ActionResult<Customer>> GetCustomerDetails(int id)
        {
            var customer = await _service.GetCustomerDetails(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

    }
}
