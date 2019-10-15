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
    /// Singleton Thred Safety
    /// </summary>
    public class SingletonThredSafety
    {  
        public static SingletonThredSafety singletonThread = null;
        public static readonly object obj = new object();
         int counter = 0;

        /// <summary>
        /// Singleton Thread Safety
        /// </summary>
        private SingletonThredSafety()
        {    
            counter++;
            Console.WriteLine("Counter :: " + counter.ToString());
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
        /// <param name="message"></param>
        public void SingletonMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}