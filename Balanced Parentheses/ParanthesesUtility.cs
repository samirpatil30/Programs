using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.Balanced_Parentheses
{
   public class ParanthesesUtility
    {
        public Node top;

        public void Push(object data)
        {
           Node node = new Node();
           node.data = data;

           if (top == null)
           {
             Console.WriteLine("Stack underflow");
           }

           node.data = data;
           node.next = top;
           top = node;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow");
            }
            top = top.next;
            Console.WriteLine("Pop element:: " + top.data);
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}   
