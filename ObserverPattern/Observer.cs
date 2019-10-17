// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverPattern
{
    using System;

    /// <summary>
    /// IObserver
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update();
    }

    /// <summary>
    /// Observer
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Gets the name of the observer.
        /// </summary>
        /// <value>
        /// The name of the observer.
        /// </value>
        public string ObserverName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Observer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Observer(string name)
        {
            this.ObserverName = name;
        }

        /// <summary>
        /// Update this instance.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("{0}: A new product has arrived at the store", this.ObserverName);
        }
    }
}
