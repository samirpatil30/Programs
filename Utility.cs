using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FellowShip_Program
{
    public class Utility
    {

        //******************Function to check percentage of coin Flipping*******************************
        public void coin()
        {

            Console.WriteLine(" how many times you want to toss coin");

            int toss_time = Convert.ToInt32(Console.ReadLine());
            //  int head[] = new int[toss_time];
            // Console.WriteLine(toss_time);
            int head = 0;
            int tail = 0;

            Random random = new Random();
            for (int i = 0; i < toss_time; i++)
            {
                double number = random.NextDouble();
                if (number > 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;

                }
            }
            Console.WriteLine(head + "  " + tail);

            int percentage_of_head = head * 100 / toss_time;
            int percentage_of_tail = tail * 100 / toss_time;

            Console.WriteLine("percentage of head  " + percentage_of_head + "%");

            Console.WriteLine("percentage of tail  " + percentage_of_tail + "%");
        }

        //***************Function to check year is leap year or not****************************
        public void leap_year()
        {
            Console.WriteLine(" Enter Year");
            Boolean flag = false;
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                flag = true;
            }
            else if (year % 4 == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("Year {0} is leap year", year);
            }
            else
            {
                Console.WriteLine(" year {0} is not leap year", year);
            }
        }

        //**********Function to check power of number***********************
        public void power_of()
        {
            double n = 2;

            Console.WriteLine(" upto how many power of table you want: ");
            int power = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < power; i++)
            {
                double temp = Math.Pow(n, i);
                Console.WriteLine(temp);
            }
        }

        //**********Function to print addition of number*************************
        public void addi()
        {
            int a = 10, b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }

        //**************Function to find Harmonic of Nth number*******************
        public void harmonic()
        {
            Console.WriteLine("Enter the number upto which you want to find Harmonic number");
            double number = Convert.ToDouble(Console.ReadLine());
            double harmonic = 0.0;

            double i, start = 0.0;
            for (i = 1; i <= number; i++)
            {
                start = start + 1 / i;
            }

            Console.WriteLine(start);
        }

        //*************Gambler Function To determine how many times user win or lose*****************
        public void Gambler_Game()
        {
            double cash = 0, stake, trials, goal, bet = 0, win = 0, lose = 0;

            Console.WriteLine(" Enter the stake or Cash");
            stake = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the goal upto which you want to reach");
            goal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" How many times you want to play or trials");
            trials = Convert.ToDouble(Console.ReadLine());

            Random random = new Random();
            for (int i = 1; i < trials; i++)
            {
                cash = stake;

                while (cash > 0 && cash < goal)
                {
                    bet++;
                    double number = random.NextDouble();
                    if (number > 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }

                }
                if (cash == goal)
                {
                    win++;
                }
                else
                {
                    lose++;
                }
            }
            Console.WriteLine("cash " + cash);
            Console.WriteLine("win " + win + " lose " + lose);
        }

        //***********Function to print prime Factors of number*******************
        public void prime_factor()
        {
            Console.WriteLine("Enter the number of which you want to print prime factor");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=2;i<=number;i++)
            {
                while(number%i==0)
                {
                    Console.WriteLine(i + " ");
                    number = number / i;
                }
               
            }
            
         
        }

        //***************Function to Generate Coupons***************
        public void coupon()
        {
            char []chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            String[] output = new String[10];
            Random random = new Random();
            Console.WriteLine(" How many coupon you want");
            int number = Convert.ToInt32(Console.ReadLine());
            String str = "";
            HashSet<String> hashSet = new HashSet<string>();
            for(int i=0;i<number;i++)
            {
                for(int j=0;j<10;j++)
                {
                    char c = chars[random.Next(chars.Length)];
                    str = str+c;
                }
                
                    hashSet.Add(str);
                    str = "";       
            }
           
            foreach(String string_fetch in hashSet)
            {
                Console.WriteLine(string_fetch);
            } 
        }

        //*************Function to print 2D Array of different data types********************
        public void add_in_Array()
        {
            Console.WriteLine("1)Integer \n 2)String \n 3)Double");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[,] array = new int[3,3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            array[i,j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(array[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    String[,] array1 = new String[3, 3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j <3; j++)
                        {
                            array1[i, j] = Convert.ToString(Console.ReadLine());
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(array1[i, j]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    double[,] array2 = new double[3, 3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j <3; j++)
                        {
                            array2[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(array2[i, j]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }

        //*****************Function to find array triplets which is equal to zero**********************
        public void Array_Triplets()
        {
            int[] array = { 0, -1, 2, -3, 1 };
            int i, j, k;
            for( i=0;i<array.Length;i++)
            {
                for(j=i+1;j<array.Length;j++)
                {
                    for(k=j+1;k<array.Length;k++)
                    {
                        if(array[i]+array[j]+array[k]==0)
                        {
                            Console.WriteLine("{0},{1},{2}", array[i], array[j], array[k]);
                        }
                    }
                }
            }
        }


        //******************Function to Check given Strings are anagram or not************************
       public void Anagram_checker()
        {
            String string1 = "java";
            String string2 = "sjav";
            char[] array1 = string1.ToCharArray();
            char[] array2 = string2.ToCharArray();
            Boolean flag = false;
            Array.Sort(array1);
            Array.Sort(array2);

            for(int i=0;i<array1.Length;i++)
            {
                for(int j=0;j<array2.Length;j++)
                {
                    if (array1[i] == array2[j])
                        flag = true;
                    
                }
                if (flag)
                {
                    Console.WriteLine("String Are anagram");
                }
                else
                {
                    Console.WriteLine("Not anagram");
                }
            }  
        }

        //****************Find prime number in range***************
        public void prime_Range()
        {
            int number = 50;

            for(int i=2;i<number;i++)
            {
                Boolean isPrime = true;
               for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
               if(isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //*************Binary Search on Integers****************
        public void binarySearch()
        {     
                int[] arr = { 2, 3, 5, 15, 45, 113, 210, 330 };
            int key = 3;
            int last = arr.Length - 1;
            int first = 0;
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (arr[mid] < key)
                {
                    first = mid + 1;
                }
                else if (arr[mid] == key)
                {
                    Console.WriteLine("Element is found at index: " + mid);
                    break;
                }
                else
                {
                    last = mid - 1;
                }
                mid = (first + last) / 2;
                Console.WriteLine("new mid" + mid);
            }
            if (first > last)
            {
               Console.WriteLine("Element is not found!");
            }
        }

        //***************Function to perform Bubble Sort on Integer AND Using String****************************
        public void bubble_sort()
        {
            Console.WriteLine("1) Bubble sort using integer" +
                "\n 2)Bubble sort using string");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[] array = { 2, 4, 1, 5, 7, 6, 3 };
                    int temp;
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[i] > array[j])
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("after Sorting");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    break;
                case 2:
                    String[] array2 = { "abc", "def", "pqr", "add", "abb" };
                    for (int i = 0; i < array2.Length; i++)
                    {
                        for (int j = i + 1; j < array2.Length; j++)
                        {
                            if (array2[i].CompareTo(array2[j]) > 0)
                            {
                                String temp2 = array2[i];
                                array2[i] = array2[j];
                                array2[j] = temp2;
                            }
                        }
                        Console.WriteLine(array2[i]);
                    }
                    break;
            }
        }

        //***************Function to print day of week*****************************
        public void day()
        {
            int m0 = 0, y0, d0, x;
            int year, month, day;

          
            Console.WriteLine("\n enter day");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter month");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter year");
            year = Convert.ToInt32(Console.ReadLine());

            y0 = year - (14 - month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (day + x + 31 * m0 / 12) % 7;

            if (d0 == 0)
            {
                Console.WriteLine("The is sunday");
            }
            else if (d0 == 1)
            {
                Console.WriteLine("The is Monday");
            }
            else if (d0 == 2)
            {
                Console.WriteLine("The is Tuesday");
            }
            else if (d0 == 3)
            {
                Console.WriteLine("The is Wedday");
            }
            else if (d0 == 4)
            {
                Console.WriteLine("The is Thrusday");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("The is Friday");
            }
            else if (d0 == 6)
            {
                Console.WriteLine("The is Saturday");
            }
        }

        //**********Function to find Binary of number******************
        public void binary(int number)
        {
            int[] binaryNum = new int[10];

            // counter for binary array 
            int i = 0;
            while (number > 0)
            {
                // storing remainder in binary array 
                binaryNum[i] = number % 2;
                number = number / 2;
                i++;                          // Here At last i will be 8
            }

            // printing binary array in reverse order 
            for (int j = i - 1; j >= 0; j--)                //i=8;
            {
                Console.Write(binaryNum[j] + " ");
            }
            Console.WriteLine("\n");
            int[] array = new int[binaryNum.Length];  

            for(int k=1;k<100;k*=2)
            {
                array[k] = k;
            }   
        }

        //**************Function for Tempeature Conversion********************
        public void tempeature()
        {
            int tempeature = 0, celsius = 0, fahrenheit = 0;
            
            Console.WriteLine("\n Enter your choice 1) celsius_to_fahrenheit 2) fahrenheit_to_celsius");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("\n enter the tempeature in celsius");
                    tempeature = Convert.ToInt32(Console.ReadLine());
                    celsius = tempeature * 9 / 5 + 32;
                    Console.WriteLine("\n tempeature in fahrenheit is " + celsius);
                    break;

                case 2:
                    Console.WriteLine("\n enter the tempeature fahrenheit");
                    tempeature = Convert.ToInt32(Console.ReadLine());
                    fahrenheit = ((tempeature - 32) * 5) / 9;
                    Console.WriteLine("\n tempeature in celsius is" + fahrenheit);
                    break;
                default:
                    Console.WriteLine("\n enter correct choice");
                    break;
            }
        }

        //***************Function to print Monthly Payment*********************
        public void Monthly_Payment()
        {
            double year = 0, rate = 0, principal = 0;
            double n = 12;
           
            Console.WriteLine("\n enter principal amount ");
            principal =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n enter number of years ");
            year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n enter rate ");
            rate = Convert.ToDouble(Console.ReadLine());



            double r = (rate / 100) / 12;   // monthly interest rate
            n = 12 * year;

            double payment = principal * r / (1 - Math.Pow(1 + r, -n));
            double interest = payment * n - principal;
            
            Console.WriteLine("Monthly payments = " + payment);
            Console.WriteLine("Total interest   = " + interest);
        }

        //***************Function for Inseration sort****************
        public void inseration_sort()
        {
            Console.WriteLine("1) inseration sort on integer \n 2) inseration sort on string");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int temp;
                    int[] array = { 5, 1, 6, 2, 3, 4 };

                    for (int i = 1; i < array.Length; i++)
                    {
                        temp = array[i];
                        int j = i;
                        while (j > 0 && array[j - 1] > temp)
                        {
                            array[j] = array[j - 1];
                            j = j - 1;
                        }
                        array[j] = temp;
                    }
                    Console.WriteLine("After Sorting");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    break;

                case 2:
                    String[] array2 = { "samir", "rahul", "abhi", "sujit", "ganesh" };
                    String str = "";
                    for (int i = 1; i < array2.Length; i++)
                    {
                        str = array2[i];
                        int j = i;
                        while (j > 0 && array2[j - 1].CompareTo(str) > 0)    // CompareTo() return 3 val are= 0(if both str is equal), 1(if 1st str is greater), -1(if 2nd str is greater)
                        {
                            array2[j] = array2[j - 1];
                            j = j - 1;
                        }
                        array2[j] = str;
                    }

                    for (int i = 0; i < array2.Length; i++)
                    {
                        Console.WriteLine(array2[i]);
                    }
                    break;
            }
        }

        //************Function to search the word from flie******************
        public void vending_Machine()
        {
            int[] note = { 2000, 500, 100 };
            int[] note_count = { 20, 30, 40 };
            int[] getting_notes = new int[3];
            int[] remaining_notes = new int[3];

            Console.WriteLine("Enter withdraw amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            while(amount>0)
            {
                for (int i = 0; i < note.Length; i++)
                {
                    getting_notes[i] = amount / note[i];
                    amount = amount % note[i];
                    remaining_notes[i] = note_count[i] - getting_notes[i];
                }
            }

            for(int i=0;i<getting_notes.Length;i++)
            {
                Console.WriteLine(note[i] + " x " + getting_notes[i]);

            }
            for (int i = 0; i < getting_notes.Length; i++)
            {
                Console.WriteLine(note[i] + "remaining notes are " + remaining_notes[i]);
            }            
        }
        //*****************Function to create file and search in file***************
        public void file_Operation()
        {
            String textFile = "./Test_File.txt";
            IList<String> list = new List<string>();
            using (StreamWriter streamWriter = File.CreateText(textFile))
            {
                streamWriter.WriteLine("Hello how are you");
               
            }
            StreamReader stream = File.OpenText(textFile);
            String str = stream.ReadLine();
           String []arr= str.Split(' ');
            foreach(String s in arr)
            {
                list.Add(s);
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

                Console.WriteLine("Enter the to be search in file:");
            String search = Convert.ToString(Console.ReadLine());
           if(list.Contains(search))
            {
                Console.WriteLine("Wrod is present in file:: " + search);
            }
            else
            {
                Console.WriteLine("Word is not present in file");
            }
        }
    }
}