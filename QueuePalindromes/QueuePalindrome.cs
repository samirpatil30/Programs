// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueuePalindromes.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure
{
    using System;
    using FellowShip_DataStructure.QueuePalindrome;

    /// <summary>
    /// QueuePalindromes
    /// </summary>
    public class QueuePalindromes
    {
        /// <summary>
        /// Queue operation.
        /// </summary>
        public void QueueOperation()
        {
            QueueUtility utility = new QueueUtility();
            int ch1 = 1;
            string string1 = string.Empty;
            string stringByDequeue = string.Empty;
            string reverse = string.Empty;

            do
            {
                Console.WriteLine("1) Enqueue" +
               "\n 2)Dequeue" +
               "\n 3)Resulr" +
               "\n 4)Size of Queue");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the String ");
                        string1 = Console.ReadLine();
                        string1= string1.ToLower();
                        Console.WriteLine("MY string " + string1);
                        char[] charArray = string1.ToCharArray();
                        foreach (char character in charArray)
                        {
                            utility.InsertIntoQueue(character);
                        }

                        Console.WriteLine();
                        utility.PrintNode();
                        break;

                    case 2:
                        stringByDequeue = utility.DequeueFromLinkedList(string1);
                        Console.WriteLine("REverse string is :: " + stringByDequeue);
                        break;

                    case 3:
                        for (int i = stringByDequeue.Length - 1; i >= 0; i--)
                        {
                            reverse += stringByDequeue[i].ToString();
                        }

                        if (string1 == reverse)
                        {
                            Console.WriteLine("String is palindrome :: " + reverse);
                        }
                        else
                        {
                            Console.WriteLine("String is not palindrome :: " + reverse);
                        }

                        break;

                    case 4:
                        utility.SizeOfQueue();
                        break;
                }
            } while (ch1 != 2);
        }
    }
}
