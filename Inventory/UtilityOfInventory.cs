using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Inventory
{
   public class UtilityOfInventory
    {
        public IList<Rice> Rice { get; set; }
        public IList<Wheats> wheats { get; set; }
        public IList<Pulses> pulses { get; set; }
        public  void FileJson()
        {
            InventoryDetails details = new InventoryDetails();
            double totalRicePrice = 0;
            double totalWheatsPrice = 0;
            double totalPulsesPrice = 0;

            string path = "C://Users//User//source//repos//ObjectOriented//ObjectOriented//bin//Debug//netcoreapp3.0//inventory.json";
            StreamReader reader = new StreamReader(path);

            string readString = reader.ReadToEnd();
            UtilityOfInventory utility = (UtilityOfInventory)JsonConvert.DeserializeObject(readString, typeof(UtilityOfInventory));

            foreach (Rice rice in utility.Rice)
            {
                string name = rice.name;
                double price =  rice.price;
                totalRicePrice = totalRicePrice + price * rice.weight;
                double weight = rice.weight;
                Console.WriteLine("Name Of Rice " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n");
            }

            Console.WriteLine("Total Amount Of Rice  " + totalRicePrice);

            foreach (Wheats wheat in utility.wheats)
            {
                string name = wheat.name;
                double price = wheat.price;
                totalWheatsPrice = totalWheatsPrice + price * wheat.weight;
                double weight = wheat.weight;
                Console.WriteLine("Name Of wheat " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n");
            }

            Console.WriteLine("Total Amount Of Wheats  " + totalWheatsPrice);

            foreach (Pulses pulses in utility.pulses)
            {
                string name = pulses.name;
                double price = pulses.price;
                totalPulsesPrice = totalPulsesPrice + price * pulses.weight;
                double weight = pulses.weight;
                Console.WriteLine("Name Of beans " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n");
            }

            Console.WriteLine("Total Amount Of Pulses   " + totalPulsesPrice);
        }
    }
}
