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
    using DesignPattern.Annotation;
    using DesignPattern.D_InjectionConstructor;
    using DesignPattern.DInjectionMethod;
    using DesignPattern.DInjectionProperty;
    using DesignPattern.FacedePattern;
    using DesignPattern.FactoryPatternComputer;
    using DesignPattern.NewFolder;
    using DesignPattern.ObserverPattern;
    using DesignPattern.PrototypePattern;
    using DesignPattern.ProxyPattern;
    using DesignPattern.Reflection;

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
                    Console.WriteLine(" 1) Factory Pattern \n 2) Singleton Pattern \n 3) prototype Pattern \n 4) Adapter Pattern" +
                        "\n 5) Facade Pattern \n 6) Proxy Pattern \n 7) Observer Pattern \n 8) Depedency injection Constructors" +
                        "\n 9) Depedency injection property \n 10) Depedency injection method \n 11) Reflection \n 12) Annotation  ");

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
                        case 5:
                            FacadeClient client = new FacadeClient();
                            client.Client();
                            break;

                        case 6:
                            ProxyPattern proxyPattern = new ProxyPattern();
                            proxyPattern.Proxy();
                            break;

                        case 7:

                            OberverOperation operation = new OberverOperation();
                            operation.Oberve();
                            break;

                        case 8:
                            ConstructorOperation operation1 = new ConstructorOperation();
                            operation1.Injection();
                            break;

                        case 9:
                            PropertyOperation propertyInjection = new PropertyOperation();
                            propertyInjection.EmployeeProperties();
                            break;

                        case 10:
                            MethodInjectionOperation method = new MethodInjectionOperation();
                            method.OPeration();
                            break;

                        case 11:
                            Coustmer coustmer = new Coustmer();                           
                            coustmer.get();
                            break;

                        case 12:
                            AnnotationChecker checker = new AnnotationChecker();
                            checker.Checker();
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

            Console.ReadKey();
        }  
    }
}
