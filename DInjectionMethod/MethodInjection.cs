using DesignPattern.DInjectionMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DInjectionMethod
{
    interface Employee
    {
        List<EmployeeDetails> SelectAllEmployees();
    }

    public class EmployeeData : Employee
    {
        public List<EmployeeDetails> SelectAllEmployees()
        {
            Console.WriteLine("*********** SelectAllEmployee method ***************");
            Console.WriteLine("How many employee details you want to add");
            int number = Convert.ToInt32(Console.ReadLine());
            EmployeeDetails[] emp = new EmployeeDetails[number];
            for (int i = 0; i < number; i++)
            {
                emp[i] = new EmployeeDetails();
                emp[i].EnterDetailsOfEmplloyee();

            }

            List<EmployeeDetails> list = new List<EmployeeDetails>();
            for (int i = 0; i < number; i++)
            {
                list.Add(emp[i]);
            }
            return list;
        }
    }
    public class MethodInjection
    {
        Employee employee;
       public List<EmployeeDetails> GetEmployee(EmployeeData refEmployee)
        {
            Console.WriteLine("********** Method Injection ************");
            employee = refEmployee;
            return employee.SelectAllEmployees();
        }
    }
}
