using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Triopod.Models
{
    public class Enquiry
    {
        [Required(ErrorMessage ="Enter Name")]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Email format invalid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Mobile No.")]
        [Display(Name = "Mobile No.:")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "Enter Message")]
        [Display(Name = "Enter Your Message:")]
        [StringLength(1000)]
        public string Message { get; set; }
    }
}