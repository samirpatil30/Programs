// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyInitialization.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.NewFolder
{
    using System;

    /// <summary>
    /// Lazy Initialization
    /// </summary>
    public class LazyInitialization
    {
        /// <summary>
        /// counter
        /// </summary>
        private int counter = 0;
        //// Create the instance of lazy function
        public static readonly Lazy<LazyInitialization> lazy = new Lazy<LazyInitialization>(() => new LazyInitialization());

        /// <summary>
        /// LazyInitialization constructor
        /// </summary>
        private LazyInitialization()
        {
            this.counter++;
            Console.WriteLine("Counter :: " + this.counter);
        }

        public static LazyInitialization GetInstanceOfLazyInitialization
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// Lazy
        /// </summary>
        /// <param name="message"></param>
        public void Lazy(string message)
        {
            Console.WriteLine("Lazy :: " + message);
        }
    }
}
