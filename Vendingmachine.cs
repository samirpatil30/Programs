// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vendingmachine.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program
{
    /// <summary>
/// Vending machine program
/// </summary>
    public class Vendingmachine
    {
        /// <summary>
        /// Vending machine print the count of notes.
        /// </summary>
        public void VendingMachine()
        {
            Utility utility = new Utility();
           utility.VendingMachineForGettingNotes();
        }
    }
}
