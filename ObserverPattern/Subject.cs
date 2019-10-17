// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface
    /// </summary>
    interface InterFace
    {
        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        void Add(Observer name);
        /// <summary>
        /// Removes the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        void Remove(Observer name);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }

    /// <summary>
    /// Subject
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverPattern.InterFace" />
    public class Subject : InterFace
    {
        /// <summary>
        /// The observers
        /// </summary>
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// The value
        /// </summary>
        private int value = 0;

        /// <summary>
        /// Gets or sets the inventory.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public int Inventory
        {
            get
            {
                return this.value;
            }

            set
            {
                //// Just to make sure that if there is an increase in inventory then only we are notifying 

                if (value > this.value)
                {
                    Notify();
                    this.value = value;
                }
            }
        }

        /// <summary>
        /// Add the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Add(Observer name)
        {
            observers.Add(name);
        }

        /// <summary>
        /// Subscribe the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Unsubscribe the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifie this instance.
        /// </summary>
        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }

        /// <summary>
        /// Remove the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(Observer name)
        {
            throw new NotImplementedException();
        }
    }
}
