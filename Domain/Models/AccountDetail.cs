using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AccountDetail
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public int productId { get; set; }
        public int accountId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal total { get; set; }

        public Account account { get; set; }
        public Product product { get; set; }
    }
}
