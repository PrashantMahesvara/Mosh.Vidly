using Mosh.Vidly.Models;
using System.Collections.Generic;

namespace Mosh.Vidly.ViewModels.Vidly
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
    }
}