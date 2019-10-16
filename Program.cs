// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ConsoleApp1
{
    using System;
    using DesignPattern.Adapter;
    using DesignPattern.FactoryPatternComputer;
    using DesignPattern.NewFolder;
    using DesignPattern.PrototypePattern;

    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
       public static void Main(string[] args)
        {
        label: try
            {
                string character;
                do
                {
                    Console.WriteLine(" 1)Factory Pattern \n 2)Singleton Pattern \n 3) prototype Pattern \n 4)Adapter Pattern");

                     int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //// Create instance of StoreComputer
                            StoreOfComputer computer = new StoreOfComputer();
                            computer.ComputerStore();
                            break;

                        case 2:
                            //// Create instance of SingletonOperation
                            SingletonOperation singletonOperation = new SingletonOperation();
                            singletonOperation.Singleton();
                            break;

                        case 3:
                            EmployeeOperation emp = new EmployeeOperation();
                            emp.EmployeeDetails();
                            break;

                        case 4:
                            Adapter adapter = new Adapter();
                            adapter.GetWebSeries();
                            break;
                    }

                    Console.WriteLine("Do you want to continoue :: yes or no");
                    character = Convert.ToString(Console.ReadLine());
                }
                while (character == "yes");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                goto label;
            }
        }   
    }
}
