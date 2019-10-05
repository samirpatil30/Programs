// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListFileOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure
{
    using System;
    /// <summary>
    /// 
    /// </summary>
    public class LinkedListBasic
    {
        /// <summary>
        /// List operation.
        /// </summary>
        public void ListOperation()
        {
            Utility1 utility = new Utility1();


            int choice1 = 1;
                do
                {
                Console.WriteLine();
                     Console.WriteLine("1)Insert into linkedList" +
                                       "\n 2)Search Node" +
                                       "\n 3)Check for Empty LinkedList" +
                                       "\n 4)Size of LinkedList" +
                                       "\n 5)Inser At Last Position" +
                                       "\n 6)Insert Node at particular position" +
                                       "\n 7)Delete last node" +
                                       "\n 8)Delete at particular position" +
                                       "\n 9) Exit");
                     Console.WriteLine();
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("How many nodes you want");
                            int number = Convert.ToInt16(Console.ReadLine());
                            string Stringdata;
                            object objectType;
                            Console.WriteLine("Enter the data into LinkedList");
                            for (int i = 0; i < number; i++)
                            {
                                Console.WriteLine("Enter data");
                                Stringdata = Console.ReadLine();
                                objectType = (object)Convert.ChangeType(Stringdata, typeof(object));
                                utility.Insert(objectType);
                            }
                            utility.PrintList();
                            break;

                        case 2:
                            utility.SearchInList();
                            break;

                        case 3:
                            Console.WriteLine("Check weather the linked list is empty or not");
                            bool result = utility.IsEmpty();
                            Console.WriteLine("LinkedList is empty::" + result);
                            break;

                        case 4:
                            Console.WriteLine("Print the size of linked list");
                            utility.SizeOfLinkedList();
                            break;

                        case 5:
                            Console.WriteLine("Append the node at last position in linked list");
                            Console.WriteLine("Enter the data which you want to append at last");
                            string NewData = Console.ReadLine();
                            object NewObjectData = (object)Convert.ChangeType(NewData, typeof(object));
                            utility.AppendAtlast(NewObjectData);
                            utility.PrintList();
                            break;

                        case 6:
                            Console.WriteLine("Put the node at particular position in linked list");
                            Console.WriteLine("Enter position AND data");
                            int position = Convert.ToInt32(Console.ReadLine());
                            string data1 = Console.ReadLine();
                            object NewData1 = (object)Convert.ChangeType(data1, typeof(Object));
                            utility.InsertAt(position, NewData1);
                            utility.PrintList();
                            break;

                        case 7:
                            Console.WriteLine("Deletion of last node");
                            utility.DeleteLastNode();
                            utility.PrintList();
                            break;

                        case 8:
                            Console.WriteLine("Delete node at specific position");
                            Console.WriteLine(" Enter position ");
                            int Deleteposition = Convert.ToInt32(Console.ReadLine());
                            utility.DeleteAtPosition(Deleteposition);
                            utility.PrintList();
                            break;
                        case 9:
                            Console.WriteLine("Thank you for using linkedList");
                            break;
                    }
                } while (choice1 != 9);
            }
        }
   }

