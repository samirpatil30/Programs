using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Commericial_data
{
   public class AccountOfUser
    {
        public string name;
        public int amont;

        public void getDeatils()
        {
            Console.WriteLine("Enter the name of coustmer ::");
            name = Console.ReadLine();

            Console.WriteLine("Enter the amount ");
            amont = Convert.ToInt32(Console.ReadLine());
        }
    }
}
