// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.NewFolder
{
    using System;

    /// <summary>
    /// Singleton
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// The get instance of object
        /// </summary>
        public static Singleton getInstanceOfObject = null;

        /// <summary>
        /// The count
        /// </summary>
        int count = 1;

        /// <summary>
        /// "Singleton"
        /// </summary>
        private Singleton()
        {
            this.count++;
            Console.WriteLine("Counter :: " + this.count);
        }

        /// <summary>
        /// My method.
        /// </summary>
        /// <returns></returns>
        public static Singleton MyMethod()
        {
            if (getInstanceOfObject == null)
            {
                return new Singleton();
            }

            return getInstanceOfObject;
        }

        /// <summary>
        /// Singletons the method.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SingletonMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
