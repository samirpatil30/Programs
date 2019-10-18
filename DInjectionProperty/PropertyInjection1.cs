using System;
using System.Collections.Generic;

namespace DesignPattern.DInjectionProperty
{
    interface Employee
    {
        List<EmployeeDetails> SelectAllEmployees();
    }

    public class EmployeeData : Employee
    {
        public List<EmployeeDetails> SelectAllEmployees()
        {
            Console.WriteLine("How many employee details you want to add");
            int number = Convert.ToInt32(Console.ReadLine());
            EmployeeDetails[] emp = new EmployeeDetails[number];
            for(int i = 0; i < number; i++)
            {
                emp[i] = new EmployeeDetails();
                emp[i].EnterDetails();
                
            }

            List<EmployeeDetails> list = new List<EmployeeDetails>();
            for (int i = 0; i < number; i++)
            {
                list.Add(emp[i]);
            }
                return list;
        }
    }
    internal class PropertyInjection
    {
        private Employee employee;
        
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

        public List<EmployeeDetails> GetAllEmployeeDetails()
        {
             return employee.SelectAllEmployees();
        }
    }
}