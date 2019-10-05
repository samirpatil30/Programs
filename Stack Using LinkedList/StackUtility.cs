using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.Stack_Using_LinkedList
{
    class StackUtility
    {
       public Node top ;

        public void Push(object data)
        {
            Node node = new Node();
            node.data = data;

            if(top == null)
            {
                Console.WriteLine("Stack underflow");
            }
            node.data = data;
            node.next = top;
            top = node;
        }

        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack underflow");
            }
            top = top.next;
            Console.WriteLine("Pop element:: " + top.data);
        }

        public  bool IsEmpty()
        {
            return top == null;
        }

        public object Peek()
        {
            return top.data;
        }

        public void PrintStack()
        {
            Node node = top;
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }                    
        }
    }
}
