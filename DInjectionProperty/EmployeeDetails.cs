// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DInjectionProperty
{
    using System;

    /// <summary>
    /// Employee Details
    /// </summary>
    public class EmployeeDetails
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public string department { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public int salary { get; set; }

        /// <summary>
        /// Enter the details.
        /// </summary>
        public void EnterDetails()
        {
            Console.WriteLine("Enter id of employee ");
            this.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name of employee ");
            this.name = Console.ReadLine();

            Console.WriteLine("Enter department of employee ");
            this.department = Console.ReadLine();

            Console.WriteLine("Enter salary of employee ");
            this.salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}
