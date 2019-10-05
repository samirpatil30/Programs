using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_DataStructure.PrimeNumber
{
    public class PrimeUtility
    {
        List<int> list = new List<int>();
        int[,] array = new int[10, 100];
        int[] one = new int[20];
        int count = 0;
        public void PrimeNumber()
        {           
            int[,] Array = new int[10, 100];
            Console.WriteLine("Enter the range upto which you want to find prime number");
            int range = Convert.ToInt32(Console.ReadLine());
            int tempNumber = 0;
            bool flag = false;
            for (int i = 0; i <= range; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    tempNumber = i;
                    Console.WriteLine(i + " ");
                    count++;
                    one[i] = tempNumber;
                    // PrimePalindrome(tempNumber);
                    TwoD(i);
                }
                  
            }
            Console.WriteLine("Count" + count);
        }

      /*  public void PrimePalindrome(int number)
        {
            List<int> list1 = new List<int>();
            int sum = 0;
            int len = list.Capacity;
            int[,] ArrayOfPrimePalindrome = new int[10, 100];
            int temp = number;
            int[] IntArray = new int[count]; 

            while (number > 0)
            {
                int reminder = number % 10;
                sum = (sum * 10) + reminder;
                number = number / 10;
            }

            int l = IntArray.Length;
           
            if (temp == sum)
            {
                for (int i = 0; i < ArrayOfPrimePalindrome.Length; i++)
                { 
                        IntArray[i] = sum;
                }
            }

            for(int i=0; i<IntArray.Length;i++)
            {
                Console.WriteLine(IntArray[i]);
            }
        }*/

        public void TwoD(int number)
        {
          //  int[,] arr = new int[10, 10];

          //  for(int i = 0; i < arr.Length; i++)
          //  {
            //    for (int j = i; j < arr.Length; j++)
               // {
              //      arr[i, j] = number;
              //  }
           // }

            for (int i = 0; i < one.Length; i++)
            {
                Console.WriteLine(one[i]);
            }
        }
    }
}


