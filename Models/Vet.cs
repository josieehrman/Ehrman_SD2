using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ehrman_SD2.Models
{
    public class Vet
    {
        [Key]
        [Display(Name = "Vet ID")]
        [Required]
        public int vetID { get; set; }
        [Display(Name = "Vet First Name")]
        [Required]
        public string vetFirstName { get; set; }
        [Display(Name = "Vet Last Name")]
        [Required]
        public string vetLastName { get; set; }
        [Display(Name = "Vet E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string vetEmail { get; set; }
        [Display(Name = "Employee Since")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime employeeSince { get; set; }
        public ICollection<Visit> visit { get; set; }
        [Display(Name = "Vet Full Name")]
        public string vetFullName => vetFirstName + " " + vetLastName;
    }
}