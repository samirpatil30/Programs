// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Annotation
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3,
       ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [Range(18, 99, ErrorMessage = "Age should be between 18 and 99")]
        public int Age { get; set; }


        /// <summary>
        /// Gets or sets the phonenumber.
        /// </summary>
        /// <value>
        /// The phonenumber.
        /// </value>
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, ErrorMessage = "Mobile number must be 10 digit")]
        [Phone]
        public string Phonenumber { get; set; }


        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
    }
}