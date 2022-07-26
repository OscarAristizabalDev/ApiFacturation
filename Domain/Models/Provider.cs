using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Provider
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public DateTime providerDate { get; set; }
        public ICollection<Product> products { get; set; }
    
    }
}
