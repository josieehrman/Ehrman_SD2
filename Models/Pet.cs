using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ehrman_SD2.Models
{
    public class Pet
    {
        [Key]
        [Display(Name="Pet ID")]
        [Required]
        public int petID { get; set; }
        [Display(Name = "Pet Name")]
        [Required]
        public string petName { get; set; }
        [Display(Name = "Owner First Name")]
        [Required]
        public string ownerFirstName { get; set; }
        [Display(Name = "Owner Last Name")]
        [Required]
        public string ownerLastName { get; set; }
        [Display(Name = "Owner E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string ownerEmail { get; set; }
        [Display(Name = "Owner Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string ownerPhone { get; set; }
        [Display(Name = "Patient Since")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime patientSince { get; set; }
        [Display(Name = "Pet Type")]
        [Required]
        public string petAnimal { get; set; }
        public ICollection<Visit> visit { get; set; }

    }
}