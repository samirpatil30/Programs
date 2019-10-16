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
        public static Singleton getInstanceOfObject = null;
        int count = 1;

        /// <summary>
        /// "Singleton"
        /// </summary>
        private Singleton()
        {
            this.count++;
            Console.WriteLine("Counter :: " + this.count);
        }

        public static Singleton MyMethod()
        {
            if (getInstanceOfObject == null)
            {
                return new Singleton();
            }

            return getInstanceOfObject;
        }
      
        public void SingletonMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
