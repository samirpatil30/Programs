// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Decorator.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Decorator_Pattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Decorator
    /// </summary>
    /// <seealso cref="DesignPattern.Decorator_Pattern.RestaurantDish" />
    public abstract class Decorator : RestaurantDish
    {
        /// <summary>
        /// The dish
        /// </summary>
       public RestaurantDish dish;

        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="restaurantDish">The restaurant dish.</param>
        public Decorator(RestaurantDish restaurantDish)
        {
            this.dish = restaurantDish;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            this.dish.Display();
        }
    }

    /// <summary>
    /// Avaiable Dishes
    /// </summary>
    /// <seealso cref="DesignPattern.Decorator_Pattern.Decorator" />
    public class AvaiableDishes : Decorator
    {
        /// <summary>
        /// The number of dishes
        /// </summary>
        int numberOfDishes;

        /// <summary>
        /// The list
        /// </summary>
        public List<string> list = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvaiableDishes"/> class.
        /// </summary>
        /// <param name="dish">The dish.</param>
        /// <param name="number">The number.</param>
        public AvaiableDishes(RestaurantDish dish, int number) : base(dish)
        {
            numberOfDishes = number;
        }

        /// <summary>
        /// Orders the item.
        /// </summary>
        /// <param name="name">The name.</param>
        public void OrderItem(string name)
        {
            if (this.numberOfDishes > 0)
            {
                list.Add(name);
                this.numberOfDishes--;
            }
            else
            {
                Console.WriteLine("sorry " + name + " we dont have enough ingridients to make your dish");
            }
        }

        /// <summary>
        /// Display
        /// </summary>
        public override void Display()
        {
            base.Display();

            foreach (var coustmerName in list)
            {
                Console.WriteLine("Dish Order By :: " + coustmerName);
            }
        }
    }
}