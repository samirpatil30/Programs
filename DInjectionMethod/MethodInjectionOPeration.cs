// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MethodInjectionOPeration.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DInjectionMethod
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Method Injection Operation
    /// </summary>
    public class MethodInjectionOperation
    {
        /// <summary>
        /// operation.
        /// </summary>
        public void OPeration()
        {
            ////Create the instance of MethodInjection
            MethodInjection methodInjection = new MethodInjection();
            ////Create the instance of list of EmployeeDetails type
            List<EmployeeDetails> list = methodInjection.GetEmployee(new EmployeeData());
            //// iterate the list
            foreach (EmployeeDetails employee in list)
            {
                Console.WriteLine("id = {0}, name = {1}, department = {2}, salary = {3}", employee.id, employee.name, employee.department, employee.salary);
            }
        }
    }
}
