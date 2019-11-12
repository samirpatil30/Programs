// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CommanLayer.Model
{
    using System.ComponentModel.DataAnnotations;

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
