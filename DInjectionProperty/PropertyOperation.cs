// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DInjectionProperty
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Property Operation
    /// </summary>
    public class PropertyOperation
    {
        /// <summary>
        /// Employees the properties.
        /// </summary>
        public void EmployeeProperties()
        {
            //// create the instance of PropertyInjection
            PropertyInjection injection = new PropertyInjection();
            //// Here we inject the object through the public property of PropertyInjection class
            injection.employeeVariable = new EmployeeData();
            //// Create the instance of List
            List<EmployeeDetails> ListEmployee = injection.GetAllEmployeeDetails();
            //// iterate the List
            foreach (EmployeeDetails emp in ListEmployee)
            {
                Console.WriteLine("id = {0}, name = {1}, department = {2}, salary = {3}", emp.id, emp.name, emp.department, emp.salary);
            }
        }
    }
}
