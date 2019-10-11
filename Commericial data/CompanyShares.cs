using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Commericial_data
{
   public class CompanyShares
    {
        public string nameOfCompany;
        public int sharesPrice;
        public int totalShares;

        public void CompanyDetails()
        {
            Console.WriteLine("Enter the name of Company ::");
            nameOfCompany = Console.ReadLine();

            Console.WriteLine("Enter the total shares ");
            totalShares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter single share price");
            sharesPrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
