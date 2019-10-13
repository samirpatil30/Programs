using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Commericial_data
{
    public class StockAccountOperation
    {
        /// <summary>
        /// this method take choice from user
        /// </summary>
        public static void StockAccountChoice()
        {
            SharePurchases stockOne = new SharePurchases();
            char again;
            do
            {
                ////here print list of operation which is goining to perform
                
                Console.WriteLine("1. Create Account \n" + "2. Print Report\n" + "3. Buy Shares\n"
                    + "4. Show My Account \n");
                

                ////take choice from user
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stockOne.StockAcountCreation();
                        break;
                    case 2:
                        stockOne.GetReport();
                        break;

                    case 3:
                        stockOne.buyShears();
                        break;
                    
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');
        }
    }
}
