// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure
{
    using System;
    using System.IO;

    /// <summary>
    /// Utility
    /// </summary>
   public class Utility1
    {
        public static Node Head;

        /// <summary>
        /// Insert specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Insert(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node node1 = Head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }

                node1.next = newNode;
            }


        }

        /// <summary>
        /// Searches in list.
        /// </summary>
        public void SearchInList()
        {
            Node node1 = Head;
            Console.WriteLine();
            Console.WriteLine("Enter the data you want to search in list");
            string word = Console.ReadLine();
            object data1 = (object)Convert.ChangeType(word, typeof(object));
            while (node1.next != null)
            {
                if (node1.data.Equals(data1))
                {
                    Console.WriteLine("Data found");
                }

                node1 = node1.next;
            }
        }

        /// <summary>
        /// Size of linked list.
        /// </summary>
        public void SizeOfLinkedList()
        {
            int counter = 1;
            Node node1 = Head;
            while (node1.next != null)
            {
                counter++;
                node1 = node1.next;
            }

            Console.WriteLine();
            Console.WriteLine("Size of linkedList is " + counter);
        }

        /// <summary>
        /// Append the at last.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AppendAtlast(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            Node node1 = Head;
            while (node1.next != null)
            {
                node1 = node1.next;
            }

            node1.next = newNode;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Inserts at position
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        public void InsertAt(int position, object data)
        {
            Node node = new Node();
            node.data = data;
            Node traversalNode = Head;

            for (int i = 1; i < position - 1; i++)
            {
                traversalNode = traversalNode.next;
            }

            node.next = traversalNode.next;
            traversalNode.next = node;           
        }

        /// <summary>
        /// Delete the last node.
        /// </summary>
        public void DeleteLastNode()
        {
            Node currentNode = Head;
            Node previousNode = Head;

            while (currentNode.next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }

            previousNode.next = null;
        }

        /// <summary>
        /// Deletes at position.
        /// </summary>
        /// <param name="position">The position.</param>
        public void DeleteAtPosition(int position)
        {
            Node node = Head;
            Node node1 = null;

            for (int i = 0; i < position - 2; i++)
            {
                node = node.next;
            }

            node1 = node.next;
            node.next = node1.next;
        }

        /// <summary>
        /// Searches the index of node.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>index</returns>
        public int SearchIndexOfNode(object searchItem)
        {
            Node node = Head;
            int index = 1;
            while (node.next != null)
            {
                if (node.data.Equals(searchItem))
                {
                    return index;
                }

                node = node.next; 
                index++;
            }

            return -1;
        }

        /// <summary>
        /// Prints the list.
        /// </summary>
        public void PrintList()
        {
            Node node = Head;
            while (node.next != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }

            Console.Write(node.data + " ");
        }

    }
}
