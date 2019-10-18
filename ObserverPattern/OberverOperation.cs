// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OberverOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverPattern
{
    /// <summary>
    /// OberverOperation
    /// </summary>
    public class OberverOperation
    {
        /// <summary>
        /// Observe this instance.
        /// </summary>
        public void Oberve()
        {
            Subject subject = new Subject();
            //// Observer1 takes a subscription to the store
            Observer observer1 = new Observer("Observer 1");
            subject.Subscribe(observer1);
            //// Observer2 also subscribes to the store
            subject.Subscribe(new Observer("Observer 2"));
            subject.Inventory++;
            //// Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new Observer("Observer 3"));
            subject.Inventory++;

        }
    }
}
