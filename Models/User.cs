using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ehrman_SD2.Models
{
    public class User
    {
        [Key]
        [Display(Name = "User ID")]
        [Required]
        public Guid userID { get; set; }
        [Display(Name = "User First Name")]
        [Required]
        public string userFirstName { get; set; }
        [Display(Name = "User Last Name")]
        [Required]
        public string userLastName { get; set; }
        [Display(Name = "User Full Name")]
        [Required]
        public string userFullname { get
            {
                return userLastName + ", " + userFirstName;
            } 
        }
        [Display(Name = "User E-Mail")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string userEmail { get; set; }
    }
}