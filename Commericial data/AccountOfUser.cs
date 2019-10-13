// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountOfUser.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Commericial_data
{
    using System;

    /// <summary>
    /// AccountOfUser
    /// </summary>
    public class AccountOfUser
    {
        /// <summary>
        /// 
        /// </summary>
        public string nameOfUSer;
        /// <summary>
        /// 
        /// </summary>
        public int amount;

        /// <summary>
        /// get deatils
        /// </summary>
        public void getDeatils()
        {
            Console.WriteLine("Enter the name of coustmer ::");
            nameOfUSer = Console.ReadLine();

            Console.WriteLine("Enter the amount ");
            amount = Convert.ToInt32(Console.ReadLine());
        }

        internal void getReport()
        {
            throw new NotImplementedException();
        }
    }
}
