// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelBooking.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    using System;

    /// <summary>
    /// Hotel Booking
    /// </summary>
   public interface HotelBooking
    {
        /// <summary>
        /// Books the specified hotel name.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="roomType">Type of the room.</param>
        public void Book(string hotelName, string roomType);
    }

    /// <summary>
    /// Hotel
    /// </summary>
    /// <seealso cref="DesignPattern.FacedePattern.HotelBooking" />
    public class Hotel : HotelBooking
    {
        /// <summary>
        /// Book the specified hotel name.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="roomType">Type of the room.</param>
        public void Book(string hotelName, string roomType)
        {
            Console.WriteLine("Hotel booking successful");
            Console.WriteLine("Hotel name :: " + hotelName + " Roome type :: " + roomType);
        }
    }
}
