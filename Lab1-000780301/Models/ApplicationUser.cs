using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_000780301.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

      //  [Required, Display(Name = "User Name")]
      //  public string User { get; set; }

     //   [Required, Display(Name = "Email")]
      //  public string UserEmail { get; set; }

      //  [Display(Name = "Phone Number")]
     //   public int Phone { get; set; }

        [Display(Name = "Birth Date")]
        public string BirthDate { get; set; }
    }
}
