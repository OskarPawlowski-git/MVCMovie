using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        
        public DateTime JoinDate { get; set; }
        public string CheckoutMovie { get; set; }
        public decimal Payment { get; set; }
    }
}