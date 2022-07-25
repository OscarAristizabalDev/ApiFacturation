using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string identification { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateOrProvinceAbbr { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        [Required]
        public int age { get; set; }

        public ICollection<Account> accounts { get; set; }
    }
}
