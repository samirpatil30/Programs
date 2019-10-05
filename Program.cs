// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FellowShip_DataStructure
{
    using FellowShip_DataStructure.Balanced_Parentheses;
    using FellowShip_DataStructure.Bank;
    using FellowShip_DataStructure.LinkedList_Using_File;
    using FellowShip_DataStructure.OrderList;
    using FellowShip_DataStructure.PrimeNumber;
    using FellowShip_DataStructure.Stack_Using_LinkedList;
    using System;

    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("1)Basic LinkedList Operation" +
                "\n 2)LinkedList using file3" +
                "\n 3)OrderList" +
                "\n 4)stack" +
                "\n 5)PalindromeQueue" +
                "\n 6)Balance Parentheses" +
                "\n 7)Bank Problem");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 0)
            {
                do
                {
                    switch (choice)
                    {
                        case 1:
                            LinkedListBasic linkedListBasic = new LinkedListBasic();
                            linkedListBasic.ListOperation();
                            break;

                        case 2:
                            LinkedListUsingFile linkedListUsingFile = new LinkedListUsingFile();
                            linkedListUsingFile.ListOperation();
                            break;

                        case 3:
                            OrderListOperation orderListOperation = new OrderListOperation();
                            orderListOperation.SortedList();
                            break;

                        case 4:
                            StackOperation stack = new StackOperation();
                            stack.Stack();
                            break;

                        case 5:
                            QueuePalindromes ququq = new QueuePalindromes();
                            ququq.QueueOperation();
                            break;

                        case 6:
                            BalanceParentheses balance = new BalanceParentheses();
                            bool result = balance.Parentheses();
                            Console.WriteLine("Expression is balanced :: " + result);
                            break;

                        case 7:
                            BankTransaction transaction = new BankTransaction();
                            transaction.Transaction();
                            break;

                        case 8:
                            Prime prime = new Prime();
                            prime.PrimeOperation();

                            break;
                    }
                } while (i != 15);

            }
            else
            {
                Console.WriteLine("enter valid choice");
            }

            Console.ReadKey();
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class Node
    {
        public object data;
        public Node next;
    }

    /// <summary>
    /// 
    /// </summary>
    public class NodeInt
    {
        public int data;
        public NodeInt next;
    }

    /// <summary>
    /// 
    /// </summary>
    public class NodeQ
    {
        public char data;
        public NodeQ next;
        // public NodeQ front;
    }
}
