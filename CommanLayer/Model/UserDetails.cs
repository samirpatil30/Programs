using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer.Model
{
    public class UserDetails
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter LastName")]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
