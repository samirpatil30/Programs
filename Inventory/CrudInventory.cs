// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CrudInventory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Inventory
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Crud Inventory
    /// </summary>
    public class CrudInventory
    {
        string InventoryFile = "C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\inventory.json";

        /// <summary>
        /// This Method Getting All Details Of Report.
        /// </summary>
        public void GetDetails()
        {
            var json = File.ReadAllText(InventoryFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray riceArrary = (JArray)jObject["Rice"];
                    if (riceArrary != null)
                    {
                        foreach (var item in riceArrary)
                        {
                            Console.WriteLine("Rice Name :" + item["name"].ToString());
                            Console.WriteLine("Rice Price :" + item["price"]);
                            Console.WriteLine("Rice Weight :" + item["weight"]);
                        }

                    }
                    ///This Method print the Wheats Details.
                    ///
                    JArray wheatsArrary = (JArray)jObject["Wheats"];
                    if (riceArrary != null)
                    {
                        foreach (var item in wheatsArrary)
                        {
                            Console.WriteLine("Wheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"]);
                            Console.WriteLine("Wheats Weight :" + item["weight"]);
                        }

                    }
                    ///This Method print the Pulses Details.
                    ///
                    JArray pulsesArrary = (JArray)jObject["Wheats"];
                    if (riceArrary != null)
                    {
                        foreach (var item in pulsesArrary)
                        {
                            Console.WriteLine("Pulses Name :" + item["name"].ToString());
                            Console.WriteLine("Pulses Price :" + item["price"]);
                            Console.WriteLine("Pulses Weight :" + item["weight"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This Method Add The Item into the List.
        /// </summary>
        public void AddItem()
        {
            Console.WriteLine("Enter Name of Inventory  : ");
            var itemName = Console.ReadLine();
            Console.WriteLine("Enter Type Of Item Name : ");
            string itemTypeName = Console.ReadLine();
            Console.WriteLine("\nEnter Item Price : ");
            var itemPrice = Console.ReadLine();
            Console.WriteLine("\nEnter Item Weight : ");
            var itemWeight = Console.ReadLine();
            var newItem = "{ 'name': " + itemTypeName + ",  'price': '" + itemPrice + "'}";

            var json = File.ReadAllText(InventoryFile);
            Console.WriteLine(json);
            var jsonObj = JObject.Parse(json);
            var itemArrary = jsonObj.GetValue("Rice") as JArray;
            var newItemObj = JObject.Parse(newItem);
            Console.WriteLine("newitem " + newItemObj);
            itemArrary.Add(newItemObj);
            Console.WriteLine("Name " + itemArrary);
            jsonObj["Rice"] = itemArrary;

            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                   Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(InventoryFile, newJsonResult);

        }
        public void UpdateFile()
        {
            string json = File.ReadAllText(InventoryFile);
            Console.WriteLine("1) Rice \n 2)Wheats \n 3) Pulses");
            var jObject = JObject.Parse(json);          
            label: Console.WriteLine("Enter Name of Inventory in which you want to make updation");
            string itemNameToUpdate = Console.ReadLine();
            JArray riceArrary = (JArray)jObject[itemNameToUpdate];
            if (jObject.ContainsKey(itemNameToUpdate))
            {            
                switch (itemNameToUpdate)
                {
                    case "Rice":
                        Console.Write("Enter Rice Name to Update : ");
                        var RiceName = Console.ReadLine();

                        Console.Write("Enter new Item name : ");
                        var newRiceName = Convert.ToString(Console.ReadLine());

                        foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(RiceName)))
                        {
                            item["name"] = !string.IsNullOrEmpty(newRiceName) ? newRiceName : "";
                        }

                        jObject["name"] = riceArrary;
                        string outputOfRice = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(InventoryFile, outputOfRice);
                        Console.WriteLine("Rice Name has been Updated");
                        break;

                    case "Wheats":

                        Console.Write("Enter Wheat Name to Update : ");
                        var WheatName = Console.ReadLine();

                        Console.Write("Enter new Item name : ");
                        var newWheatName = Convert.ToString(Console.ReadLine());

                        foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(WheatName)))
                        {
                            item["name"] = !string.IsNullOrEmpty(newWheatName) ? newWheatName : "";
                        }

                        jObject["name"] = riceArrary;
                        string outputOfWheat = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(InventoryFile, outputOfWheat);
                        Console.WriteLine("Wheat Name has been Updated");
                        break;

                    case "Pulses":
                        Console.Write("Enter Pulses Name to Update : ");
                        var PulsesName = Console.ReadLine();

                        Console.Write("Enter new Item name : ");
                        var newPulsesName = Convert.ToString(Console.ReadLine());

                        foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(PulsesName)))
                        {
                            item["name"] = !string.IsNullOrEmpty(newPulsesName) ? newPulsesName : "";
                        }

                        jObject["name"] = riceArrary;
                        string outputOfPulses = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(InventoryFile, outputOfPulses);
                        Console.WriteLine("Pulses Name has been Updated");
                        break;
                }               
            }
            else
            {
                Console.WriteLine("plsease enter valid inventory name");
                goto label;
            }  
        }
        
        public void DeleteFileItem()
        {
            var jsonFileRead = File.ReadAllText(InventoryFile);
            try
            {
                var jsonObjectConvert = JObject.Parse(jsonFileRead);
                Console.WriteLine("Enter Item Name ");
                string itemNameToDelete = Console.ReadLine();
                JArray itemsArrary = (JArray)jsonObjectConvert[itemNameToDelete];
                Console.Write("Enter Name to Delete Item : ");
                var itemName = Console.ReadLine();


                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemName));

                itemsArrary.Remove(itemToDeleted);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObjectConvert, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(InventoryFile, output);

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs : " + e);
            }
        }

        public void AddInventory()
        {
            Console.WriteLine("Enter Rice Name : ");
            var riceName = Console.ReadLine();
            Console.WriteLine("\nEnter Rice Price : ");
            var ricePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice weight");
            var riceWeight = Convert.ToInt32(Console.ReadLine());

            var newRiceMember = "{ 'name': " + riceName + ", 'price': '" + ricePrice + ", 'weight': '" + riceWeight + "'}";
            try
            {
                string tempJson = File.ReadAllText(InventoryFile);
                var jObject = JObject.Parse(tempJson);
                var RiceArrary = jObject.GetValue("Rice") as JArray;
                var newRice = JObject.Parse(newRiceMember);
                RiceArrary.Add(newRice);
                jObject["Rice"] = RiceArrary;

                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(InventoryFile,
                              Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(InventoryFile, newJsonResult);
                Console.WriteLine("Data Added");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "::");
            }
        }
    }
}
