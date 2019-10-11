using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Inventory_Management
{
    class InventoryItems
    {
        public string nameOfInventory;
        public int priceOfInventory;
        public int totalAvaiableStock;

        public void FillDetails()
        {
            Console.WriteLine("Enter the Name Of Inventory ::");
            nameOfInventory = Console.ReadLine();

            Console.WriteLine("Enter the price Of Inventory ::");
            priceOfInventory = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the avaiable Of Inventory ::");
            totalAvaiableStock = Convert.ToInt32(Console.ReadLine());
        }
    }
}
