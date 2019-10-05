using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.OrderList
{
    public class OrderListOperation
    {
        public void SortedList()
        {
                UtilityOfOrderList listUtility = new UtilityOfOrderList();

                Console.WriteLine();
                int choice1 = 1;
                do
                {
                    Console.WriteLine("1)Insert into linkedList" +
                "\n 2)Size of LinkedListe" +
                "\n 3)Sort List" +
                "\n 4)Insert at position" +
                "\n 5)Exit");
                    Console.WriteLine();
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("How many nodes you want");
                            int number = Convert.ToInt16(Console.ReadLine());
                            int NumberData = 0; ;
                            //object objectType;
                            Console.WriteLine("Enter the data into LinkedList");
                            for (int i = 0; i < number; i++)
                            {
                                Console.WriteLine("Enter data");
                                NumberData =  Convert.ToInt32(Console.ReadLine());
                                //objectType = (object)Convert.ChangeType(Stringdata, typeof(object));
                                listUtility.InsertIntoList(NumberData);
                            }
                            listUtility.PrintList();
                            break;

                        case 2:
                                listUtility.SizeOfLinkedList();
                            break;

                        case 3:
                            Console.WriteLine("SORTED LIST IS");
                       // int counter = listUtility.SizeOfLinkedList();
                            listUtility.SortList();
                            listUtility.PrintList();
                            break;
                    case 4:
                        Console.WriteLine("Enter the data which you want to add");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        listUtility.InsertAtPosition(number1);
                        listUtility.PrintList();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("exit");
                        break;

                    }
                } while (choice1 != 3);
        }
    }
}

