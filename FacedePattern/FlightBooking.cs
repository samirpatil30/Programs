// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlightBooking.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    using System;

   public interface FlightBooking
    {
        void Book(string flightname, string seat, string classType);
    }

    public class Flight : FlightBooking
    {
        public void Book(string flightname, string seat, string classType)
        {
            Console.WriteLine("Flight book Suceessfully");
            Console.WriteLine("Flight Name :: " + flightname + " Seat number is :: " + seat + " Class type :: " + classType);
        }
    }
}