using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class student
    {
      
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required(ErrorMessage ="password is required")]
        
        public string password { get; set; }
        [Compare("password", ErrorMessage = "password and confirm password must match")]

        public string confirmpassword { get; set; }

    }
}