// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonThredSafety.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.NewFolder
{
    using System;

    /// <summary>
    /// Singleton Thread Safety
    /// </summary>
    public class SingletonThredSafety
    {
        /// <summary>
        /// The singleton thread
        /// </summary>
        public static SingletonThredSafety singletonThread = null;

        /// <summary>
        /// The object
        /// </summary>
        public static readonly object obj = new object();

        /// <summary>
        /// The counter
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Singleton Thread Safety
        /// </summary>
        private SingletonThredSafety()
        {
            this.counter++;
            Console.WriteLine("Object created :: ");       
        }

        /// <summary>
        /// Singleton Thread Safety
        /// </summary>
        public static SingletonThredSafety GetInstance
        {
            get
            {
                lock (obj)
                {
                    if (singletonThread == null)
                    {
                        singletonThread = new SingletonThredSafety();
                    }
                }
                    
                return singletonThread;
            }     
        }

        /// <summary>
        /// Singleton Method
        /// </summary>
        /// <param name="message">message</param>
        public void SingletonMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}