using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ehrman_SD2.Models
{
    public class Visit
    {
        [Key]
        [Display(Name = "Visit ID")]
        [Required]
        public int visitID { get; set; }
        [Display(Name = "Description")]
        [Required]
        public string description { get; set; }
        [Display(Name = "Visit Date")]
        [Required]
        [DisplayFormat(DataFormatString ="{0:dddd MMM d, yyyy h:mm tt}", ApplyFormatInEditMode =true )]
        public DateTime visitDate { get; set; }
        [Display(Name = "Pet ID")]
        [Required]
        public int petID { get; set; }
        [Display(Name = "Vet ID")]
        [Required]
        public int vetID { get; set; }
        public virtual Pet pet { get; set; }
        public virtual Vet vet { get; set; }


    }
}