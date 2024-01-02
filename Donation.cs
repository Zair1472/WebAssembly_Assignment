using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly_Assignment.Shared
{
    public class Donation
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MedicineName { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Potency { get; set; }
        [Required]
        public int DonateQuantity { get; set; }
    }
}
