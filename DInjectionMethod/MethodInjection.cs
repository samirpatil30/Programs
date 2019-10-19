// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MethodInjection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DInjectionMethod
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
    /// <seealso cref="DesignPattern.DInjectionMethod.Employee" />
    public class EmployeeData : Employee
    {
        /// <summary>
        /// Selects all employees.
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDetails> SelectAllEmployees()
        {
            Console.WriteLine("*********** SelectAllEmployee method ***************");
            Console.WriteLine("How many employee details you want to add");
            int number = Convert.ToInt32(Console.ReadLine());
            //// create yhe array of EmployeeDetail type
            EmployeeDetails[] emp = new EmployeeDetails[number];
            //// iterate Number
            for (int i = 0; i < number; i++)
            {
                emp[i] = new EmployeeDetails();
                emp[i].EnterDetailsOfEmployee();
            }

            //// Create the instance of list
            List<EmployeeDetails> list = new List<EmployeeDetails>();
            //// iterate the number
            for (int i = 0; i < number; i++)
            {
                list.Add(emp[i]);
            }

            return list;
        }
    }

    /// <summary>
    /// Method Injection
    /// </summary>
    public class MethodInjection
    {
        /// <summary>
        /// employee
        /// </summary>
        Employee employee;

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="refEmployee">The reference employee.</param>
        /// <returns></returns>
        public List<EmployeeDetails> GetEmployee(EmployeeData refEmployee)
        {
            Console.WriteLine("********** Method Injection ************");
            employee = refEmployee;
            return this.employee.SelectAllEmployees();
        }
    }
}
