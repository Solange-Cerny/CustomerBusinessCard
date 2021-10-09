using System.Collections.Generic;

namespace CustomerBusinessCard.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
