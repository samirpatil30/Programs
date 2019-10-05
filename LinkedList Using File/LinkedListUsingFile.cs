using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.LinkedList_Using_File
{
   public class LinkedListUsingFile
    {
        Utility utility = new Utility();
        public void ListOperation()
        {
            int ch = 1;
            do
            {
                Console.WriteLine("1)Write in file " +
               "\n 2)Read data in file" +
               "\n 3)search the position of word" +
               "\n 4)search and delete node" +
               "\n 5) Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.WriteIntoFile();
                        utility.printNodes();
                        break;
                    case 2:
                        utility.ReadIntoFile();
                        utility.printNodes();
                        break;
                    case 3:
                        //Console.WriteLine("Enter the data of which you want to find position");
                        //string word = Console.ReadLine();
                      // Console.WriteLine(utility.Search(word));
                        break;
                    case 4:
                        Console.WriteLine("Enter the data of which you want to find position");
                        string word = Console.ReadLine();
                        utility.SearchAndDelete(word);
                        utility.printNodes();
                        break;
                    case 5:
                        break;
                }
            } while (ch != 2);
           
        }
    }
}
