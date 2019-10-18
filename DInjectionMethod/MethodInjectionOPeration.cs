using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DInjectionMethod
{
   public class MethodInjectionOPeration
    {
        public void OPeration()
        {
            MethodInjection methodInjection = new MethodInjection();
            List<EmployeeDetails> list = methodInjection.GetEmployee(new EmployeeData());

            foreach(EmployeeDetails employee in list)
            {
                Console.WriteLine("id = {0}, name = {1}, department = {2}, salary = {3}", employee.id, employee.name, employee.department, employee.salary);
            }
        }
    }
}
