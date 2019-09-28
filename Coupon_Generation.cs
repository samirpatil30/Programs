// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon_Generation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program
{
    /// <summary>
    /// Program to Generates a Coupons
    /// </summary>
    public class Coupon_Generation
    {
        /// <summary>
        /// Generates the coupon.
        /// </summary>
        public void GenerateCoupon()
        {
            Utility utility = new Utility();
            utility.GenerateCoupons();
        }
    }
}
