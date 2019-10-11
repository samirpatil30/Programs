using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOriented.Inventory_Management
{
    public class InventoryOperation
    {
        public string file = "./MyInventory.json";
        StreamWriter streamWriter;
        StreamReader streamReader;
        public void CreateInventory()
        {
            Console.WriteLine("How many items you want to add in your inventory ::");
            int items = Convert.ToInt32(Console.ReadLine());

            InventoryItems[] addInInventory = new InventoryItems[items];

            for (int i = 0; i < items; i++)
            {
                addInInventory[i] = new InventoryItems();
                addInInventory[i].FillDetails();
            }

            List<InventoryItems> list = new List<InventoryItems>();
            for (int i = 0; i < items; i++)
            {
                list.Add(addInInventory[i]);
            }

            string inventory = JsonConvert.SerializeObject(list);

            streamWriter = new StreamWriter(file);
            streamWriter.Write(inventory);
            streamWriter.Close();

        }

        public void ReadInventory()
        {
            streamReader = new StreamReader(file);
            string Myinventory = streamReader.ReadLine();

            List<InventoryItems> listOne = JsonConvert.DeserializeObject<List<InventoryItems>>(Myinventory);

            foreach (InventoryItems inventoryOne in listOne)
            {
                Console.WriteLine("Name Of Inventory : " + inventoryOne.nameOfInventory);
                Console.WriteLine("i have " + inventoryOne.totalAvaiableStock + " " + inventoryOne.nameOfInventory);
                Console.WriteLine("Price of single " + inventoryOne.nameOfInventory + " is " + inventoryOne.priceOfInventory);
            }
        }

        
    }
}
