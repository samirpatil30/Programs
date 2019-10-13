using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOriented.Inventory;

namespace ObjectOriented.InventoryManagement
{
    public class UtilityOfInventory
    {
        public IList<Rice> rice { get; set; }
        public IList<Wheats> wheats { get; set; }
        public IList<Pulses> pulses { get; set; }
        public void InventoryManagementReport()
        {
            double totalRicePrice = 0;
            double totalWheatsPrice = 0;
            double totalPulsesPrice = 0;

            string path = "C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\inventory.json";
            StreamReader streamReader = new StreamReader(path);
           
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            UtilityOfInventory utility = (UtilityOfInventory)JsonConvert.DeserializeObject(readString, typeof(UtilityOfInventory));

            foreach (Rice objeRice in utility.rice)
            {
                string name = objeRice.name;
                double price = objeRice.price;
                totalRicePrice = totalRicePrice + price;
                double weight = objeRice.weight;
                Console.WriteLine("Name Of Rice " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }

            Console.WriteLine("Total Amount Of Rice  " + totalRicePrice);
            Console.WriteLine("*********************");
            foreach (Wheats objWheats in utility.wheats)
            {
                string name = objWheats.name;
                double price = objWheats.price;
                totalWheatsPrice = totalWheatsPrice + price;
                double weight = objWheats.weight;
                Console.WriteLine("Name Of Wheats " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }

            Console.WriteLine("Total Amount Of Wheats  " + totalWheatsPrice);
            Console.WriteLine("*********************");
            foreach (Pulses objPulses in utility.pulses)
            {
                string name = objPulses.name;
                double price = objPulses.price;
                totalPulsesPrice = totalPulsesPrice + price;
                double weight = objPulses.weight;
                Console.WriteLine("Name Of Pulses " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }

            Console.WriteLine("Total Amount Of Pulses   " + totalPulsesPrice);
        }
    }
}