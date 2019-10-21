// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AnnotationChecker.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Annotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// Annotation Checker
    /// </summary>
    public class AnnotationChecker
    {
        /// <summary>
        /// Checker
        /// </summary>
        public void Checker()
        {
            Console.WriteLine("Employee class Validation");
            Console.WriteLine("---------------------------\n");
            ////Create the Employee instance
            Employee objEmployee = new Employee();
            Console.WriteLine("Enter Name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the email address");
            string emailAddress = Console.ReadLine();

            objEmployee.Name = name1;
            objEmployee.Age = age;
            objEmployee.Phonenumber = number;
            objEmployee.email = emailAddress;
            ////Create instance of ValidationContext
            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    Console.Write("Member Name :{0}", vr.MemberNames.First());
                    Console.Write("   ::  {0}{1}", vr.ErrorMessage, Environment.NewLine);
                }
            }
        }
    }
}
