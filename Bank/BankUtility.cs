using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.Bank
{
    public class BankUtility
    {
        public Node head;

        public int bankBalance = 100000;
        public void Enqueue(string data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }

                node1.next = newNode;
            }
        }

        public void BankTransaction(string userName)
        {
            int deposit=0,withdraw=0;
            string character;

            do
            {
                Console.WriteLine("1)withdraw" +
                           "\n 2)Deposit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Withdraw amount");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        bankBalance = bankBalance - withdraw;
                        Console.WriteLine("Your Withdraw amount is :: " + withdraw);
                        Console.WriteLine("Upadated Bank balance is :: " + bankBalance);
                        break;

                    case 2:
                        Console.WriteLine("Enter deposit amount");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        bankBalance = bankBalance + deposit;
                        Console.WriteLine("Your deposit amount is :: " + deposit);
                        Console.WriteLine("Upadated Bank balance is :: " + bankBalance);
                        break;
                }
                Console.WriteLine("Do you want to continoue YES OR NO");
                character = Console.ReadLine();
            }while(character == "Yes");
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty");
            }

            //// Create instance of Node
            Node node1 = head;
            head = head.next;
            Console.WriteLine("Welcome {0}", node1.data);
        }
        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            //Console.Write(node.data + " ");
        }
    }
}
