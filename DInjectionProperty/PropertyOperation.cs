using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DInjectionProperty
{
   public class PropertyOperation
    {
        public void EmployeeProperties()
        {
            PropertyInjection injection = new PropertyInjection();
            //// Here we inject the object through the public property of PropertyInjection class
            injection.employeeVariable = new EmployeeData();
            List<EmployeeDetails> ListEmployee = injection.GetAllEmployeeDetails();

            foreach(EmployeeDetails emp in ListEmployee)
            {
                Console.WriteLine("id = {0}, name = {1}, department = {2}, salary = {3}", emp.id, emp.name, emp.department, emp.salary);
            }
        }
    }
}
