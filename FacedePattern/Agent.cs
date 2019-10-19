// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Agent.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Agent
    /// </summary>
    public interface Agent
    {
        /// <summary>
        /// Books
        /// </summary>
        public void Book();
    }

    /// <summary>
    /// Agent Booking
    /// </summary>
    /// <seealso cref="DesignPattern.FacedePattern.Agent" />
    public class AgentBooking : Agent
    {
        /// <summary>
        /// Book
        /// </summary>
        public void Book()
        {
            ////Create the instance of Flight
            Regex regex = new Regex("[a-zA-z][a-zA-Z]");
            FlightBooking flight = new Flight();
            Console.WriteLine("1)Indigo 2)AirIndia 3)SpiceJet 4)QutarAirways");
            label: Console.WriteLine("Please select your flight");
            string flightname = Console.ReadLine();
            bool result = true;
            result = regex.IsMatch(flightname);
            if(result == true)
            {  
            }
            else
            {
                goto label;
            }

            flight.Book(flightname, "A-12", "Buissness class");
            Console.WriteLine();
            ////Create the instance of Hotel
            HotelBooking hotel = new Hotel();
            hotel.Book("Sun&Sea", "Suite");
            Console.WriteLine();
            ////Create the instance of Car
            Carbooking car = new Car();
            car.book("VoklsWagon vento");
        }
    }
}
