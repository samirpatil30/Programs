// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlightBooking.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    using System;

    /// <summary>
    /// Flight Booking
    /// </summary>
    public interface FlightBooking
    {
        /// <summary>
        /// Books the specified flight name.
        /// </summary>
        /// <param name="flightname">The flight name.</param>
        /// <param name="seat">The seat.</param>
        /// <param name="classType">Type of the class.</param>
        void Book(string flightname, string seat, string classType);
    }

    /// <summary>
    /// Flight
    /// </summary>
    /// <seealso cref="DesignPattern.FacedePattern.FlightBooking" />
    public class Flight : FlightBooking
    {
        /// <summary>
        /// Books the specified flightname.
        /// </summary>
        /// <param name="flightname">The flightname.</param>
        /// <param name="seat">The seat.</param>
        /// <param name="classType">Type of the class.</param>
        public void Book(string flightname, string seat, string classType)
        {
            Console.WriteLine("Flight book Suceessfully");
            Console.WriteLine("Flight Name :: " + flightname + " Seat number is :: " + seat + " Class type :: " + classType);
        }
    }
}