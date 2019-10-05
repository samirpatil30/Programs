// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankTransaction.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure.Bank
{
    using System;

    public class BankTransaction
    {
        BankUtility bank = new BankUtility();
        public void Transaction()
        {
            string userName = string.Empty;

            Console.WriteLine("Enter the number of user");
            int userCount = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < userCount; i++)
            {
                Console.WriteLine("Enter user name");
                userName = Console.ReadLine();
                bank.Enqueue(userName);
            }

           

            for (int i = 0; i < userCount; i++)
            {
                bank.Dequeue();
                Console.WriteLine("**************************");
                bank.BankTransaction(userName);
                
            }
         

             Console.WriteLine();
            bank.PrintList();
        }
    }
}
