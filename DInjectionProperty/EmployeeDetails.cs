using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DInjectionProperty

{
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int salary { get; set; }

        public void EnterDetails()
        {
            Console.WriteLine("Enter id of employee ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name of employee ");
            name = Console.ReadLine();

            Console.WriteLine("Enter department of employee ");
            department = Console.ReadLine();

            Console.WriteLine("Enter salary of employee ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}
