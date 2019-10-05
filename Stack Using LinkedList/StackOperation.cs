using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.Stack_Using_LinkedList
{
    public class StackOperation
    {
        public void Stack()
        {
            StackUtility utility = new StackUtility();
            Console.WriteLine();
            int choice1 = 1;
            do
            {
                Console.WriteLine("1)Push into stack" +
                    "\n 2) Pop" +
                    "\n 3)IsEmpty" +
                    "\n 4)Peek" +
                    "");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How Many elements you want to push in stack");
                        int NumberOfElement = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter element into stack");
                        for(int i = 0; i < NumberOfElement; i++)
                        {
                            int element = Convert.ToInt32(Console.ReadLine());
                            utility.Push(element);
                        }
                        Console.WriteLine();
                        utility.PrintStack();
                        break;

                    case 2:
                        utility.Pop();
                        utility.PrintStack();
                        break;
                    case 3:
                        Console.WriteLine("Stack is empty :: "+ utility.IsEmpty());
                        break;
                    case 4:
                        Console.WriteLine("Peek element :: " + utility.Peek());
                        break;

                }

            } while (choice1 != 5);
        }
    }
}
