using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account
    {
        public int id { get; set; }
        public DateTime accountDate { get; set; }
        public int customerId { get; set; }
        public Customer customer { get; set; }
        public ICollection<AccountDetail> accountDetails { get; set; }
    }
}
