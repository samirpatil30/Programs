using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FellowShip_DataStructure.Program1;
namespace FellowShip_DataStructure.LinkedList_Using_File
{
    class Utility
    {
        Node head;
        public string file = "./NewFile.txt";
        public StreamWriter streamWriter;
        public StreamReader streamReader;

       
        public IList<string> list = new List<string>();

        public void WriteIntoFile()
        {
            streamWriter = new StreamWriter(file);
            streamWriter.Write("Hello how are you ");
            streamWriter.Write("good bye");
            streamWriter.Close();
        }
        public void ReadIntoFile()
        {         
                streamReader = new StreamReader(file);
                string line = streamReader.ReadLine();
               // Console.WriteLine(line);
                string[] arrayOfString = line.Split(' ');
                foreach (string string1 in arrayOfString)
                {  
                   InsertLinkedList(string1);
                    list.Add(string1);
                }

            Console.WriteLine("This is list");
                foreach (var item in list)
                {
                  Console.WriteLine(item);
                }

        }

        public void InsertLinkedList(string data1)
        {
            Node NewNode = new Node();
            NewNode.data = data1;
            if(head == null)
            {
                head = NewNode;
            }
            else
            {
                Node node = head;
                while(node.next != null)
                {
                    node = node.next;
                }
                node.next = NewNode;
            }
        }

        public int Search(string word)
        {
            string searchWord = word;
            Node node = head;
            int count = 1;
            while(node.next != null)
            {
                if(node.data.Equals(searchWord))
                {
                    return count;
                }
                count++;
                node = node.next;
            }
            return -1;
        }

        public void SearchAndDelete(string word)
        {
           // Console.WriteLine(" Enter the word");
          //  string word = Console.ReadLine(); 
            if(list.Contains(word))
            {
                int pos = Search(word);
                DeleteNode(pos);
            }
            else
            {
                Console.WriteLine("Node is not present in linked list hense it node is added");
                InsertLinkedList(word);
            }
        }

        public void DeleteNode(int position)
        {
            Node node = head;
            Node node1 = null;

            for(int i=1; i < position-1; i++)
            {
                node = node.next;
            }
            node1 = node.next;
            node.next = node1.next;
        }
        public void printNodes()
        {
            Node node = head;
            while(node.next != null)
            {
                Console.Write(node.data+" ");
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
    }
}
