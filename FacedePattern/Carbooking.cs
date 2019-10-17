﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Carbooking.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    using System;

    /// <summary>
    /// Car booking
    /// </summary>
    interface Carbooking
    {
        public void book(string carName);
    }

    /// <summary>
    /// Car
    /// </summary>
    /// <seealso cref="DesignPattern.FacedePattern.Carbooking" />
    public class Car : Carbooking
    {
        public void book(string carName)
        {
            Console.WriteLine("Car booking successful");
            Console.WriteLine("car name :: " + carName);
        }
    }
}