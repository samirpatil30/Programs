// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListBasic.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure.Program1
{
    using System;

    /// <summary>
    /// LinkedListBasic
    /// </summary>
   public class LinkedListBasic
    {
       public Utility1 ListUtility = new Utility1();

        /// <summary>
        /// Basic this instance.
        /// </summary>
        public void Basic()
        {
            Utility1 listUtility = new Utility1();

            Console.WriteLine();
            int choice1 = 1;
            do
            {
                Console.WriteLine("1)Insert into linkedList" +
            "\n 2)Search Node" +
            "\n 3)Check for Empty LinkedList" +
            "\n 4)Size of LinkedList" +
            "\n 5)Inser At Last Position" +
            "\n 6)Insert Node at particular position" +
            "\n 7)Delete last node" +
            "\n 8)Delete at particular position" +
            "\n 9) search the position of node" +
            "\n 10)Exit");
                Console.WriteLine();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many nodes you want");
                        int number = Convert.ToInt16(Console.ReadLine());
                        string stringdata;
                        object objectType;
                        Console.WriteLine("Enter the data into LinkedList");
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine("Enter data");
                            stringdata = Console.ReadLine();
                            objectType = (object)Convert.ChangeType(stringdata, typeof(object));
                            listUtility.Insert(objectType);
                        }

                        listUtility.PrintList();
                        break;

                    case 2:
                        listUtility.SearchInList();
                        break;

                    case 3:
                        Console.WriteLine("Check weather the linked list is empty or not");
                        bool result = listUtility.IsEmpty();
                        Console.WriteLine("LinkedList is empty::" + result);
                        break;

                    case 4:
                        Console.WriteLine("Print the size of linked list");
                        listUtility.SizeOfLinkedList();
                        break;

                    case 5:
                        Console.WriteLine("Append the node at last position in linked list");
                        Console.WriteLine("Enter the data which you want to append at last");
                        string newData = Console.ReadLine();
                        object newObjectData = (object)Convert.ChangeType(newData, typeof(object));
                        listUtility.AppendAtlast(newObjectData);
                        listUtility.PrintList();
                        break;

                    case 6:
                        Console.WriteLine("Put the node at particular position in linked list");
                        Console.WriteLine("Enter position AND data");
                        int position = Convert.ToInt32(Console.ReadLine());
                        string data1 = Console.ReadLine();
                        object newData1 = (object)Convert.ChangeType(data1, typeof(object));
                        listUtility.InsertAt(position, newData1);
                        break;

                    case 7:
                        Console.WriteLine("Deletion of last node");
                        listUtility.DeleteLastNode();
                        break;

                    case 8:
                        Console.WriteLine("Delete node at specific position");
                        Console.WriteLine(" Enter position ");
                        int deleteposition = Convert.ToInt32(Console.ReadLine());
                        listUtility.DeleteAtPosition(deleteposition);
                        listUtility.PrintList();
                        break;

                    case 9:
                        Console.WriteLine("Enter the data of which you want to find position");
                        string word = Console.ReadLine();
                        object wordObject = (object)Convert.ChangeType(word, typeof(object));
                        Console.WriteLine(listUtility.SearchIndexOfNode(wordObject));
                        break;

                    case 10:
                        Console.WriteLine("Thank you for using linkedList");
                        break;
                }
            } while (choice1 != 9);
        }      
    }
}
