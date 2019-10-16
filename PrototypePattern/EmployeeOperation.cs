// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.PrototypePattern
{
    using System;

    /// <summary>
    /// Employee Operation
    /// </summary>
    public class EmployeeOperation
    {
        /// <summary>
        /// Employee Details
        /// </summary>
        public void EmployeeDetails()
        {
            ////Create the instance of Employee
            Employee employee = new Employee(1, "Samir", "Bridgelabz", 40000);
            //// Here performing Cloneing
            Employee employeeOne = (Employee)employee.ShallowCopy();

            //// print the values of both object
            Console.WriteLine("Employee ID :: " + employee.empId);
            Console.WriteLine("Employee Name :: " + employee.description.name);
            Console.WriteLine("Employee Company :: " + employee.description.company);
            Console.WriteLine("Employee Salary :: " + employee.description.salary);
            Console.WriteLine("**********************************************************");
            Console.WriteLine("***************ShallowCopy********************************");

            //// change the value of clone object
            employeeOne.empId = 2;
            employeeOne.description.name = "Satish";
            employeeOne.description.company = "wipro";
            employeeOne.description.salary = 30000;

            Console.WriteLine("Employee ID of shallowCopy :: " + employeeOne.empId);
            Console.WriteLine("Employee Name of shallowCopy :: " + employeeOne.description.name);
            Console.WriteLine("Employee Company of shallowCopy :: " + employeeOne.description.company);
            Console.WriteLine("Employee Salary of shallowCopy :: " + employeeOne.description.salary);

            Console.WriteLine("**********************************************************");
            Console.WriteLine("***************DeepCopy********************************");

            //// createing the instance of employee And change the value of deepcopy
            Employee employeeDeep = (Employee)employee.DeepCopy();
            employeeDeep.empId = 22;
            employeeDeep.description.name = "Manoj pawane";
            employeeDeep.description.company = "Bridgelabz";
            employeeDeep.description.salary = 50000;

            Console.WriteLine("Employee ID of DeepCopy :: " + employeeDeep.empId);
            Console.WriteLine("Employee Name of DeepCopy :: " + employeeDeep.description.name);
            Console.WriteLine("Employee Company of DeepCopy :: " + employeeDeep.description.company);
            Console.WriteLine("Employee Salary of DeepCopy :: " + employeeDeep.description.salary);
        }
    }
}
