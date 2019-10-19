using DesignPattern.Decorator_Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator_Pattern
{
   public abstract class RestaurantDish
    {
        public abstract void Display();
    }
}

public class Salad : RestaurantDish
{
    private string saladIngridientsOne;
    private string saladIngridientsTwo;
    private string saladDressing;
    public Salad(string nameOfvegi, string cheese, string dressing)
    {
        saladIngridientsOne = nameOfvegi;
        saladIngridientsTwo = cheese;
        saladDressing = dressing;
    }
   
    public override void Display()
    {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", saladIngridientsOne);
        Console.WriteLine(" Cheese: {0}", saladIngridientsTwo);
        Console.WriteLine(" Dressing: {0}", saladDressing);
    }
}

public class Vadapav : RestaurantDish
{
    private string vadaIngridientsOne;
    private string vadaIngridientsTwo;
    private readonly string vadaDressing;
    public Vadapav(string nameOfvegi, string cheese, string dressing)
    {
        vadaIngridientsOne = nameOfvegi;
        vadaIngridientsTwo = cheese;
        vadaDressing = dressing;
    }

    public override void Display()
    {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", vadaIngridientsOne);
        Console.WriteLine(" Cheese: {0}", vadaIngridientsTwo);
        Console.WriteLine(" Dressing: {0}", vadaDressing);
    }
}