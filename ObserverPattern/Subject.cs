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

    interface InterFace
    {
        void Add(Observer name);
        void Remove(Observer name);

        void Notify();
    }
    public class Subject : InterFace
    {

        public List<Observer> observers = new List<Observer>();

        private int value = 0;
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
        public void Add(Observer name)
        {
            observers.Add(name);
        }
        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
        public void Remove(Observer name)
        {
            throw new NotImplementedException();
        }

    }
}
