// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ----------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Inventory
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class ManagementOfInventory
    {
        /// <summary>
        /// Menu
        /// </summary>
        public void Menu()
        {
            char character = ' ';
            do
            {
                Console.WriteLine("1) Read Inventory \n 2) Update Inventory \n 3)Delete From Inventory");
                int choice = Convert.ToInt32(Console.ReadLine());
                CrudInventory crud = new CrudInventory();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Read Inventory");
                        Console.WriteLine("---------------------------------------");
                        crud.GetDetails();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("Update Inventory");
                        Console.WriteLine("---------------------------------------");
                        crud.UpdateFile();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case 3:
                        Console.WriteLine("Delete from Inventory");
                        Console.WriteLine("---------------------------------------");
                        crud.DeleteFileItem();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case 4:
                        Console.WriteLine("Add in inventory");
                        Console.WriteLine("---------------------------------------");
                        crud.AddInventory();
                        Console.WriteLine("---------------------------------------");
                        break;
                }

                 Console.WriteLine("Do you want to contionoue y or n ");
                character = Convert.ToChar(Console.ReadLine());
            } while (character == 'y');
        }

    }
}
