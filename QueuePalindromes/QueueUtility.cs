// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueUtility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure.QueuePalindrome
{
    using System;

    /// <summary>
    /// Queue Utility
    /// </summary>
    public class QueueUtility
    {
        //// Create instance of NodeQ
       public NodeQ Rear, Front;
        public int Counter = 0;
        public string ReverseString = string.Empty;

        /// <summary>
        /// Insert Into Queue
        /// </summary>
        /// <param name="charData">charData</param>
        public void InsertIntoQueue(char charData)
        {
            //// Create instance of NodeQ
            NodeQ newNode = new NodeQ();
            newNode.data = charData;

            if (this.Rear == null)
            {
                this.Front = this.Rear = newNode;
            }
            else
            {
                //// Add the new node at the end of queue and change rear  
                this.Rear.next = newNode;
                this.Rear = newNode;
            }

            Console.WriteLine("{0} inserted into Queue", charData);
        }

        /// <summary>
        /// Dequeue From Linked List
        /// </summary>
        /// <param name="string1"></param>
        /// <returns>ReverseString</returns>
        public string DequeueFromLinkedList(string string1)
        {
            if (this.Front == null)
            {
                Console.WriteLine("The Queue is empty");
            }

            //// Create instance of NodeQ
            NodeQ node = this.Front;
            Console.WriteLine("Item deleted is {0}", node.data);
            ReverseString += node.data;
            this.Front = this.Front.next;
            return this.ReverseString;
        }

        /// <summary>
        /// print node
        /// </summary>
        public void PrintNode()
        {
            NodeQ node = this.Front;
            //// iterate node
            while (node.next != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }

            Console.Write(node.data);
        }

        /// <summary>
        /// Size Of Queue
        /// </summary>
        public void SizeOfQueue()
        {
            NodeQ node = this.Front;
            int counter = 0;
            ////iterate front
            while (this.Front != null)
            {
                counter++;
                this.Front = this.Front.next;
            }

            Console.WriteLine("Size of Linked List is :: " + counter);
        }
    }
}
