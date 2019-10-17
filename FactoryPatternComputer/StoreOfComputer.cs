// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoreOfComputer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryPatternComputer
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Store Of Computer
    /// </summary>
    public class StoreOfComputer
    {
        /// <summary>
        /// Computer Store
        /// </summary>
        public void ComputerStore()
        {
            try
            {
                Regex regex = new Regex("[a-zA-z]");
            label: Console.WriteLine("Enter the Computer type");
                string type = Console.ReadLine();
                bool result = regex.IsMatch(type);

                if (result == true)
                {
                }
                else
                {
                    goto label;
                }
                ////Create the instance of ComputerInterFace
                ComputerInterFace i1 = ComputerFactory.GetType(type);
                Console.WriteLine(i1.Produce());
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
