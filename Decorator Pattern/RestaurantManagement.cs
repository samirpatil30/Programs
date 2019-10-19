// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RestaurantManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Decorator_Pattern
{
    /// <summary>
    /// Restaurant Management
    /// </summary>
    public class RestaurantManagement
    {
        /// <summary>
        /// Managements this instance.
        /// </summary>
        public void Management()
        {
            //// create the instance of Salad
            Salad salad = new Salad("Spinach ", "Cheese", "serve with fresh curd");
            salad.Display();

            ////Create the instance of vadapav
            Vadapav vadapav = new Vadapav("potato", "cheese", "serve with fresh bread and green chutny");
            vadapav.Display();
            ////Create the instance of AvaivableDish
            AvaiableDishes saladAvaiable = new AvaiableDishes(salad, 3);
            AvaiableDishes vadapavAvaiable = new AvaiableDishes(vadapav, 3);

            saladAvaiable.OrderItem("Samir");
            saladAvaiable.OrderItem("Sathish");

            vadapavAvaiable.OrderItem("Rahul");
            vadapavAvaiable.OrderItem("Raju");
            vadapavAvaiable.OrderItem("sunny");
            vadapavAvaiable.OrderItem("Sanju");

            saladAvaiable.Display();
            vadapavAvaiable.Display();
        }
    }
}
