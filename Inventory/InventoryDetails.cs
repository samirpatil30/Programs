// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Inventory
{
    using System.Collections.Generic;

    /// <summary>
    /// InventoryDetails
    /// </summary>
    public class InventoryDetails
    {
        public IList<Rice> rice { get; set; }
        public IList<Wheats> wheats { get; set; }
        public IList<Pulses> pulses { get; set; }
    }
    public class Rice
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Wheats
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Pulses
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
}

