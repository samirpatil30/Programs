// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RestaurantDish.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
using DesignPattern.Decorator_Pattern;
using System;

namespace DesignPattern.Decorator_Pattern
{
    /// <summary>
    /// Restaurant Dish
    /// </summary>
    public abstract class RestaurantDish
    {
        /// <summary>
        /// Display
        /// </summary>
        public abstract void Display();
    }
}

/// <summary>
/// Salad
/// </summary>
public class Salad : RestaurantDish
{
    /// <summary>
    /// The salad ingredients one
    /// </summary>
    private string saladIngridientsOne;

    /// <summary>
    /// The salad ingridients two
    /// </summary>
    private string saladIngridientsTwo;

    /// <summary>
    /// The salad dressing
    /// </summary>
    private string saladDressing;
    public Salad(string nameOfvegi, string cheese, string dressing)
    {
        this.saladIngridientsOne = nameOfvegi;
        this.saladIngridientsTwo = cheese;
        this.saladDressing = dressing;
    }

    /// <summary>
    /// Display
    /// </summary>
    public override void Display()
    {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", this.saladIngridientsOne);
        Console.WriteLine(" Cheese: {0}", this.saladIngridientsTwo);
        Console.WriteLine(" Dressing: {0}", this.saladDressing);
    }
}

/// <summary>
/// Vadapav
/// </summary>
public class Vadapav : RestaurantDish
{
    /// <summary>
    /// The vada ingridients one
    /// </summary>
    private string vadaIngridientsOne;

    /// <summary>
    /// The vada ingridients two
    /// </summary>
    private string vadaIngridientsTwo;

    /// <summary>
    /// The vada dressing
    /// </summary>
    private readonly string vadaDressing;

    /// <summary>
    /// Initializes a new instance of the <see cref="Vadapav"/> class.
    /// </summary>
    /// <param name="nameOfvegi">The name ofvegi.</param>
    /// <param name="cheese">The cheese.</param>
    /// <param name="dressing">The dressing.</param>
    public Vadapav(string nameOfvegi, string cheese, string dressing)
    {
        this.vadaIngridientsOne = nameOfvegi;
        this.vadaIngridientsTwo = cheese;
        this.vadaDressing = dressing;
    }

    /// <summary>
    /// Display the dish
    /// </summary>
    public override void Display()
    {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", this.vadaIngridientsOne);
        Console.WriteLine(" Cheese: {0}", this.vadaIngridientsTwo);
        Console.WriteLine(" Dressing: {0}", this.vadaDressing);
    }
}