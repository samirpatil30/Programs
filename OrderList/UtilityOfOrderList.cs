using System;

namespace FellowShip_DataStructure.OrderList
{
    class UtilityOfOrderList
    {
        NodeInt head;
       // Node SortNode;
        public void InsertIntoList(int data)
        {
            NodeInt node = new NodeInt();
            node.data = data;

            if(head == null)
            {
                head = node;
            }
            else
            {
                NodeInt node1 = head;
                while(node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
          //  PrintList();
        }

        public int SizeOfLinkedList()
        {
            int counter = 1;
            NodeInt node1 = head;
            while (node1.next != null)
            {
                counter++;
                node1 = node1.next;
            }
            Console.WriteLine();
            Console.WriteLine("Size of linkedList is " + counter);
            return counter;
        }

        public void SortList()
        {
            NodeInt node = head;
            NodeInt node1 = null;
            // Node node2 = null; 
            int value = 0;
           while(node != null)
           {
                node1 = node.next;
                while (node1 != null)
                {
                    if(node.data > node1.data)
                    {
                        value = node1.data;
                        node1.data = node.data;
                        node.data = value;
                    }
                    node1 = node1.next;
                }
                node = node.next;
           }
        }

        public void InsertAtPosition(int number)
        {
            NodeInt CurrentNode = new NodeInt();
            CurrentNode.data = number;
            NodeInt node = head;
            NodeInt node1; 
            while(node.next != null)
            {
                node1 = node.next;
                if (node.data < CurrentNode.data && CurrentNode.data < node1.data)
                {
                    node.next = CurrentNode;
                    CurrentNode.next = node1;
                }
                node = node.next;
            }
        }
        public void PrintList()
        {
            NodeInt node = head;
            while (node.next != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }            
            Console.Write(node.data + " ");

        }
    }
}
