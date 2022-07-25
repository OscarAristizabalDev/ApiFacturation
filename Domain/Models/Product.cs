using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public int providerId { get; set; }
        public ICollection<AccountDetail> accountDetails { get; set; }
    }
}
