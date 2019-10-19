// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyInjection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DInjectionProperty
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Employee
    /// </summary>
    interface Employee
    {
        /// <summary>
        /// Selects all employees.
        /// </summary>
        /// <returns></returns>
        List<EmployeeDetails> SelectAllEmployees();
    }

    /// <summary>
    /// Employee Data
    /// </summary>
    /// <seealso cref="DesignPattern.DInjectionProperty.Employee" />
    public class EmployeeData : Employee
    {
        /// <summary>
        /// Select all employees.
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDetails> SelectAllEmployees()
        {
            Console.WriteLine("How many employee details you want to add");
            int number = Convert.ToInt32(Console.ReadLine());
            //// create array of EmployeeDetails type
            EmployeeDetails[] emp = new EmployeeDetails[number];
            //// iterate number
            for (int i = 0; i < number; i++)
            {
                emp[i] = new EmployeeDetails();
                emp[i].EnterDetails();               
            }
            //// Create the instance of List Function
            List<EmployeeDetails> list = new List<EmployeeDetails>();
            //// iterate number
            for (int i = 0; i < number; i++)
            {
                list.Add(emp[i]);
            }

            return list;
        }
    }

    /// <summary>
    /// Property Injection
    /// </summary>
    internal class PropertyInjection
    {
        /// <summary>
        /// The employee
        /// </summary>
        private Employee employee;

        /// <summary>
        /// Gets or sets the employee variable.
        /// </summary>
        /// <value>
        /// The employee variable.
        /// </value>
        public Employee employeeVariable
        {
            get
            {
                return employee;              
            }

            set
            {
                employee = value;
            }
        }

        /// <summary>
        /// Gets all employee details.
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDetails> GetAllEmployeeDetails()
        {
             return employee.SelectAllEmployees();
        }
    }
}