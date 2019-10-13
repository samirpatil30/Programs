// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SharePurchases.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Commericial_data
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// inerface
    /// </summary>
    interface Shares
    {
        void buyShears();
        void sellShears();
    }

    /// <summary>
    /// SharePurchases
    /// </summary>
    public class SharePurchases : Shares
    {
        /// <summary>
        /// Stock Acount Create
        /// </summary>
        public void StockAcountCreation()
        {
            ////Create a file UserAccount
            string path = "./UserAccount.json";
            Console.WriteLine("How Many User Account you want to create ");
            int numberOfAccount = Convert.ToInt32(Console.ReadLine());
            AccountOfUser[] userAccount = new AccountOfUser[numberOfAccount];

            ////iterate the numberofAccount
            for (int i = 0; i < numberOfAccount; i++)
            {
                userAccount[i] = new AccountOfUser();
                userAccount[i].getReport();
            }

            ////Create the instance of List 
            List<AccountOfUser> writeUser = new List<AccountOfUser>();
            ////iterate the numberofAccount
            for (int i = 0; i < numberOfAccount; i++)
            {
                writeUser.Add(userAccount[i]);
            }

            string UserAccount = JsonConvert.SerializeObject(userAccount, Formatting.Indented);

            //// Create the instance of StreamWriter
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(UserAccount);
            streamWriter.Close();
        }

        /// <summary>
        /// buy shears
        /// </summary>
        public void buyShears()
        {
            int availableShareOfStock = 0;
            double sharePrice = 0.0;
            bool isValideUser = false;
            //// string nameOfStock = "";
            double ValideToBuy = 0.0;
            double totalAmountOfUser = 0;
            string name = string.Empty;
            string userName = string.Empty;
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();
            ////display Stock Report.
            GetReport();
            Console.WriteLine("Enter Stock Name To Buy Share");
            string stockName = Console.ReadLine();
            Console.WriteLine("How Many Share You Wnat To Buy ");
            int numberOfShareBuy = Convert.ToInt32(Console.ReadLine());

            ////This code get the stock details to update 
            string readPath = "C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\stockDetails.json";
            var json = File.ReadAllText(readPath);
            var jObject = JObject.Parse(json);
            string jsonPath = File.ReadAllText(readPath);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonPath);
            int i;
            //// iterate the for loop to retrieve the records
            for (i = 0; i < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];

                if (retriveName.Equals(stockName))
                {
                    sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                    availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                    name = jsonObj["stockReport"][i]["stockName"];
                    break;
                }
            }

            ///this code use to update where user want to buy the share
            ////Create the instance of StreamReader
            StreamReader streamReaderUser = new StreamReader("C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\UserAccount.json");
            string readUserFile = streamReaderUser.ReadToEnd();
            streamReaderUser.Close();
            ////Create the instance of List
            List<AccountOfUser> userList = JsonConvert.DeserializeObject<List<AccountOfUser>>(readUserFile);
            //// iterate the list
            foreach (AccountOfUser objUser in userList)
            {
                userName = objUser.nameOfUSer;

                if (objUser.nameOfUSer.Equals(accountHolderName))
                {
                    totalAmountOfUser = objUser.amount;
                    ValideToBuy = numberOfShareBuy * sharePrice;

                    if (totalAmountOfUser >= ValideToBuy)
                    {
                        // Console.WriteLine("Eligible");
                        isValideUser = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Dont Have Sufficient Dollers");
                    }

                    userName = objUser.nameOfUSer;
                }
            }

            ////After Eligible
            availableShareOfStock = availableShareOfStock - numberOfShareBuy;
            totalAmountOfUser = totalAmountOfUser - ValideToBuy;
            this.Save(name, availableShareOfStock, totalAmountOfUser);
            this.Save(userName, totalAmountOfUser);
        }

        /// <summary>
        /// sell Shears
        /// </summary>
        public void sellShears()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save Company detail
        /// </summary>
        /// <param name="nameOfStock"></param>
        /// <param name="availableShareOfStock"></param>
        /// <param name="totalAmountOfUser"></param>
        public void Save(string nameOfStock, int availableShareOfStock, double totalAmountOfUser)
        {
            string path = "C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\stockDetails.json";
            string json = File.ReadAllText(path);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            int i;

            //// iterate the json object
            for (i = 0; i < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];

                if (retriveName.Equals(nameOfStock))
                {
                    jsonObj["stockReport"][i]["noOfShare"] = availableShareOfStock;
                    break;
                }
            }

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);         
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="amount"></param>
        public void Save(string userName, double amount)
        {
            string path = "./UserAccount.json";
            string json = File.ReadAllText(path);
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            ////Create the instance of List
            List<AccountOfUser> userList = JsonConvert.DeserializeObject<List<AccountOfUser>>(readString);

            foreach (AccountOfUser objStock in userList)
            {
                string newUserUpdate = objStock.nameOfUSer;
                if (newUserUpdate.Equals(userName))
                {
                    int totalAmount = (int)amount;
                    userList.Remove(objStock);
                    userList.Add(new AccountOfUser { nameOfUSer = objStock.nameOfUSer, amount = totalAmount });
                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);

                    StreamWriter streamWriter = new StreamWriter("C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\UserAccount.json");
                    streamWriter.WriteLine(updateUserData);
                    streamWriter.Close(); 
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public  void GetReport()
        {
            ////this file path used to read the file.
            string path = "C:\\Users\\User\\source\\repos\\ObjectOriented\\ObjectOriented\\bin\\Debug\\netcoreapp3.0\\stockDetails.json";

            ////read all text start to end of file.
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);

            ////it create json array of object.
            JArray stockArrary = (JArray)jObject["stockReport"];

            ////if stock array not null then its true condition
            if (stockArrary != null)
            {
                ////this for loop print all record of stock details.
                foreach (var objStock in stockArrary)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.Write("\t Stock Name: " + objStock["stockName"].ToString());
                    Console.Write("\t Total Share: " + objStock["noOfShare"]);
                    Console.Write("\t Share Price: " + objStock["sharePrice"] + "\n\n");
                }
            }
        }

    }
}
