// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.D_InjectionConstructor
{
    using System;

    /// <summary>
    /// InjectionInterface
    /// </summary>
    interface InjectionInterface
    {
        /// <summary>
        /// Get Details
        /// </summary>
        public void GetDetails();
    }

    /// <summary>
    /// ServiceOne
    /// </summary>
    public class ServiceOne : InjectionInterface
    {
        /// <summary>
        /// Get  Details
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Service1 Class Method");
        }
    }

    /// <summary>
    /// Service Two
    /// </summary>
    public class ServiceTwo : InjectionInterface
    {
        /// <summary>
        /// Get Details
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Serviced 2 class Method");
        }
    }

    /// <summary>
    /// Client
    /// </summary>
    class Client
    {
        InjectionInterface injection;
        public Client(InjectionInterface injectionInterface)
        {
            injection = injectionInterface;
        }

        /// <summary>
        /// serve Method
        /// </summary>
        public void serveMethod()
        {
            Console.WriteLine("Method belongs to client class");
            injection.GetDetails();
        }
    }
}
