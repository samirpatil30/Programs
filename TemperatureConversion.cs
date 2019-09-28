// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program
{
    /// <summary>
    /// Temperature Conversion
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// ConvertTemperature() used to called function in Utility class i.e utility.Temperature
        /// </summary>
        public void ConvertTemperature()
        {
            Utility utility = new Utility();
            utility.ConvertTemperatureFromCelsiusToOtherType();
        }
    }
}
