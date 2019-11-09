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
        [RegularExpression("^[a-zA-Z ]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string LastName { get; set; }
     
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
