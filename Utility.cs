// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Utility class which contains all generic(s) methods.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Calculates the square root.
        /// </summary>
        public static void CalculateSquareRoot()
        {
            ///// Console.WriteLine(" Enter the frist value");
            //// double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the second value");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the third value");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4.0 * c);
            double sqroot = Math.Sqrt(discriminant);

            double root1 = (-b + sqroot) / 2.0;
            double root2 = (-b - sqroot) / 2.0;

            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }

        /// <summary>
        /// Calculate(s) the percentage for coin tossed.
        /// </summary>
        public void CalculatesPercentageForCoinTossed()
        {
            Console.WriteLine("How many times you want to toss coin");
            int noOfCoinedTossed = Convert.ToInt32(Console.ReadLine());
            ////  int head[] = new int[toss_time];
            //// Console.WriteLine(toss_time);
            int head = 0;
            int tail = 0;

            //// Creates the instance of random function.
            Random random = new Random();

            //// iterates the number of coin tossed
            for (int i = 0; i < noOfCoinedTossed; i++)
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

            int percentage_of_head = head * 100 / noOfCoinedTossed;
            int percentage_of_tail = tail * 100 / noOfCoinedTossed;

            Console.WriteLine("percentage of head  " + percentage_of_head + "%");

            Console.WriteLine("percentage of tail  " + percentage_of_tail + "%");
        }

        /// <summary>
        /// Converts the type of the temperature from celsius to other and vice versa.
        /// </summary>
        public void ConvertTemperatureFromCelsiusToOtherType()
        {
            int tempeature = 0, celsius = 0, fahrenheit = 0;

            Console.WriteLine("\n Enter your choice 1) celsius_to_fahrenheit 2) fahrenheit_to_celsius");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n enter the tempeature in celsius");
                    tempeature = Convert.ToInt32(Console.ReadLine());
                    celsius = (tempeature * 9) / 5 + 32;
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

        /// <summary>
        /// Print the day of week.
        /// </summary>
        public void PrintDayOfWeek()
        {
            int monthM = 0, yearY, dayD, x;
            int year, month, day;

            Console.WriteLine("\n enter day");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter month");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter year");
            year = Convert.ToInt32(Console.ReadLine());

            yearY = year - (14 - month) / 12;
            x = (yearY + yearY) / (4 - yearY) / (100 + yearY) / 400;             
            monthM = month + 12 * ((14 - month) / 12) - 2;
             dayD = ((day + x) + ((31 * monthM) / 12)) % 7;
            ////   dayD = ((day + x) + 31 * (monthM / 12)) % 7;

            if (dayD == 0)
            {
                Console.WriteLine("The is sunday");
            }
            else if (dayD == 1)
            {
                Console.WriteLine("The is Monday");
            }
            else if (dayD == 2)
            {
                Console.WriteLine("The is Tuesday");
            }
            else if (dayD == 3)
            {
                Console.WriteLine("The is Wedday");
            }
            else if (dayD == 4)
            {
                Console.WriteLine("The is Thrusday");
            }
            else if (dayD == 5)
            {
                Console.WriteLine("The is Friday");
            }
            else if (dayD == 6)
            {
                Console.WriteLine("The is Saturday");
            }
        }

        /// <summary>
        /// operation on file if the word is available in file then print it.
        /// </summary>
        public void File_Operation()
        {
            string textFile = "./Test_File.txt";
            IList<string> list = new List<string>();
            using (StreamWriter streamWriter = File.CreateText(textFile))
            {
                streamWriter.WriteLine("Hello how are you");
            }
            //// Create the instance of StreamReader function
            StreamReader stream = File.OpenText(textFile);
            string str = stream.ReadLine();
            string[] array = str.Split(' ');
            
            //// iterate(s) till length of string array
            foreach (string string1 in array)
            {
                list.Add(string1);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Enter the to be search in file:");
            string search = Convert.ToString(Console.ReadLine());
            if (list.Contains(search))
            {
                Console.WriteLine("Wrod is present in file:: " + search);
            }
            else
            {
                Console.WriteLine("Word is not present in file");
            }
        }

        /// <summary>
        /// Vending the machine for getting notes.
        /// </summary>
        public void VendingMachineForGettingNotes()
        {
            int[] note = { 2000, 500, 100 };
            int[] note_count = { 20, 30, 40 };
            int[] getting_notes = new int[3];
            int[] remaining_notes = new int[3];
           
            ////iterates till given amount become zero   
            try
            {
                Console.WriteLine("Enter withdraw amount");
                int amount = Convert.ToInt32(Console.ReadLine());

                while (amount > 0)
                {
                   ////iterates the notes
                   for (int i = 0; i < note.Length; i++)
                   {
                      getting_notes[i] = amount / note[i];
                      amount = amount % note[i];
                      remaining_notes[i] = note_count[i] - getting_notes[i];
                   }                   
                }
                //// iterate the getting notes
                for (int i = 0; i < getting_notes.Length; i++)
                {
                    Console.WriteLine(note[i] + " x " + getting_notes[i]);
                }
                ////  iterate(s) the remaining notes
                for (int i = 0; i < remaining_notes.Length; i++)
                {
                    Console.WriteLine(note[i] + "remaining notes are " + remaining_notes[i]);
                }
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("Enter Correct value  " + exception);
            }
            finally
            {
                for (int i = 0; i < note_count.Length; i++)
                {
                    Console.WriteLine(note[i] + " x " + note_count[i]);
                }
            }         
        }

        /// <summary>
        /// Sorts the array using bubble sort.
        /// </summary>
        public void SortArrayUsingBubbleSort()
        {
            Console.WriteLine("1) Bubble sort using integer" +
                     "\n 2)Bubble sort using string");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IntegerSort();
                    break;
                case 2:
                    StringSorting();
                    break;
            }
            /////Function to sort integer array
            void IntegerSort()
            {
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
            }
            ////Function to sort String array
            void StringSorting()
            {
                string[] array2 = { "abc", "def", "pqr", "add", "abb" };
                for (int i = 0; i < array2.Length; i++)
                {
                    for (int j = i + 1; j < array2.Length; j++)
                    {
                        if (array2[i].CompareTo(array2[j]) > 0)
                        {
                            string temp2 = array2[i];
                            array2[i] = array2[j];
                            array2[j] = temp2;
                        }
                    }

                    Console.WriteLine(array2[i]);
                }
            }           
        }

        /// <summary>
        /// Sorts the array using insertion sort.
        /// </summary>
        public void SortArrayUsingInserationsort()
        {
            Console.WriteLine("1) inseration sort on integer \n 2) inseration sort on string");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int temp;
                    int[] array = { 5, 1, 6, 2, 3, 4 };

                    //// iterate array
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
                    StringSort();
                    break;
            }

            void StringSort()
            {
                string[] array2 = { "samir", "rahul", "abhi", "sujit", "ganesh" };
                //// Declareing empty string str="";
                string str = string.Empty;
                ////Iterate the Array2
                for (int i = 1; i < array2.Length; i++)
                {
                    str = array2[i];
                    int j = i;

                    //// CompareTo() return 3 val are= 0(if both str is equal), 1(if 1st str is greater), -1(if 2nd str is greater)
                    while (j > 0 && array2[j - 1].CompareTo(str) > 0)
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
            }
        }

        /// <summary>
        /// Prints the binary of number.
        /// </summary>
        /// <param name="number">The number.</param>
        public void PrintBinaryOFNumber(int number)
        {
            int[] binaryNumber = new int[10];
            int i = 0;
            while (number > 0)
            {
                //// storing remainder in binary array 
                binaryNumber[i] = number % 2;
                number = number / 2;
                //// Here At last i will be 8
                i++;
            }

            ////iterate BinaryNumber array
            //// printing binaryNumber array in reverse order 
            for (int j = i - 1; j >= 0; j--)               
            {
                Console.Write(binaryNumber[j] + " ");
            }

            Console.WriteLine("\n");
            int[] array = new int[binaryNumber.Length];

            for (int k = 1; k < 100; k *= 2)
            {
                array[k] = k;
            }
        }

        /// <summary>
        /// Prints the leap year.
        /// </summary>
        public void PrintLeapyear()
        {
            Console.WriteLine(" Enter Year");
            bool flag = false;
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

        /// <summary>
        /// Prints the table of number power.
        /// </summary>
        public void PrintTableOfNumberPower()
        {
            double n = 2;

            Console.WriteLine(" upto how many power of table you want: ");
            int powerNumber = Convert.ToInt32(Console.ReadLine());
            
            ////iterate the power number
            for (int i = 1; i < powerNumber; i++)
            {
                double temp = Math.Pow(n, i);
                Console.WriteLine(temp);
            }
        }

        /// <summary>
        /// Prints the harmonic series of number.
        /// </summary>
        public void PrintHarmonicSeriesOfNumber()
        {
            Console.WriteLine("Enter the number upto which you want to find Harmonic number");
            double number = Convert.ToDouble(Console.ReadLine());

            double i, start = 0.0;
            ////iterate the number
            for (i = 1; i <= number; i++)
            {
                start = (start + 1) / i;
            }

            Console.WriteLine(start);
        }

        /// <summary>
        /// Gambler game problem.
        /// </summary>
        public void GamblerGameProblem()
        {
            double cash = 0, stake, trials, goal, bet = 0, win = 0, lose = 0;
            Console.WriteLine(" Enter the stake or Cash");
            stake = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the goal upto which you want to reach");
            goal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" How many times you want to play or trials");
            trials = Convert.ToDouble(Console.ReadLine());

            //// create instance of Random function
            Random random = new Random();
            //// iterate the trials
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

        /// <summary>
        /// Print the prime factor of number.
        /// </summary>
        public void PrintPrimeFactorOfNumber()
        {
            Console.WriteLine("Enter the number of which you want to print prime factor");
            int number = Convert.ToInt32(Console.ReadLine());

            ////iterate the number
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                    number = number / i;
                }
            }
        }

        /// <summary>
        /// Generates the coupons.
        /// </summary> 
        public void GenerateCoupons()
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            string[] output = new string[10];
            Random random = new Random();
            Console.WriteLine(" How many coupon you want");
            int numberOfCoupons = Convert.ToInt32(Console.ReadLine());
            //// Declareing empty string str="";
            string str = string.Empty;
            HashSet<string> hashSet = new HashSet<string>();
            ////Iterate the number of coupons
            for (int i = 0; i < numberOfCoupons; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    char c = chars[random.Next(chars.Length)];
                    str = str + c;
                }

                hashSet.Add(str);
                ////Empty string str="";
                str = string.Empty;
            }
            ////iterate the HashSet values
            foreach (string string_fetch in hashSet)
            {
                Console.WriteLine(string_fetch);
            }
        }

        /// <summary>
        /// print the 2D Array of data type
        /// </summary>
        public void PrintThe2DArrayOfDataType()
        {
            Console.WriteLine("1)Integer \n 2)String \n 3)Double");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[,] arrayOfInteger = new int[3, 3];
                    ////iterate the array of integer
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            arrayOfInteger[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    //// iterate and print the array of integer
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arrayOfInteger[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    break;

                case 2:
                    string[,] arrayOfString = new string[3, 3];
                    ////iterate the array of string
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            arrayOfString[i, j] = Convert.ToString(Console.ReadLine());
                        }
                    }

                    ////iterate and print the array of string Type
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arrayOfString[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    break;

                case 3:
                    double[,] arrayOfDouble = new double[3, 3];
                    ////iterate the array of double
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            arrayOfDouble[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    ////iterate and print array of double Type
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arrayOfDouble[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    break;
            }
        }

        /// <summary>
        /// Prints the array triplets equals to zero.
        /// </summary>
        public void PrintArrayTripletsEqualsToZero()
        {
            int[] array = { 0, -1, 2, -3, 1 };
            int i, j, k;
            //// iterate the array
            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    for (k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine("{0},{1},{2}", array[i], array[j], array[k]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Strings the is anagram or not.
        /// </summary>
        public void StringIsAnagramOrNot()
        {
            string string1 = "java";
            string string2 = "sjav";
            char[] chararray1 = string1.ToCharArray();
            char[] chararray2 = string2.ToCharArray();
            bool flag = false;
            Array.Sort(chararray1);
            Array.Sort(chararray2);
            
            ////iterate CharArray1
            for (int i = 0; i < chararray1.Length; i++)
            {
                ////iterate charArray2
                for (int j = 0; j < chararray2.Length; j++)
                {
                    ////Check the characters in CharArray1 and CharArray2
                    if (chararray1[i] == chararray2[j])
                    {
                        flag = true;
                    }
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

        /// <summary>
        /// Prints the prime number in given range.
        /// </summary>
        public void PrintPrimeNumberInGivenRange()
        {
            int number = 50;
            //// iterate the number
            for (int i = 2; i < number; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                    this.PrintPrimePalindrome(i);
                }
            }
        }

        /// <summary>
        /// Binary search of given number.
        /// </summary>
        public void BinarySearchOfGivenNumber()
        {
            int[] arr = { 2, 3, 5, 15, 45, 113, 210, 330 };
            int key = 3;
            int last = arr.Length - 1;
            int first = 0;
            int mid = (first + last) / 2;
            //// iterate till first is less than or equal to Last
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

                if (first > last)
                {
                    Console.WriteLine("Element is not found!");
                }
            }
        }

        /// <summary>
        /// Monthly payment.
        /// </summary>
        public void MonthlyPayment()
        {
            double year = 0, rateOfInterest = 0, principalAmount = 0;
            double n = 12;
            Console.WriteLine("\n enter principal ");
            principalAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n enter year ");
            year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n enter rate ");
            rateOfInterest = Convert.ToDouble(Console.ReadLine());

            //// monthly interest rate
            double monthlyInterestRate = (rateOfInterest / 100) / 12;   
            n = 12 * year;

            double payment = principalAmount * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -n));
            double interest = (payment * n) - principalAmount;

            Console.WriteLine("Monthly payments = " + payment);
            Console.WriteLine("Total interest   = " + interest);   
        }

        /// <summary>
        /// Distances the between point.
        /// </summary>
        public void DistanceBetweenPoint()
        {
            int pointx1 = 0, pointx2 = 0, pointy1 = 0, pointy2 = 0;
            
           Console.WriteLine(" enter the x1 value");
            pointx1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the x2 value");
            pointx2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the y1 value");
            pointy1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the y2 value");
            pointy2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(pointx2 - pointx1, 2) + Math.Pow(pointy2 - pointy1, 2));
            Console.WriteLine("Eculidian distance of point is " + distance);
        }

        /// <summary>
        /// Find the magic number.
        /// </summary>
        public void FindMagicNumber()
        {
            int low = 0, high = 127, mid;
            Console.WriteLine("\n enter the number betwwen 1 to 127");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (number > 1 && number < 127)
                {
                    while (low != high)
                    {
                        mid = (low + high) / 2;
                        Console.WriteLine("enter 1 if no is between " + low + " - " + mid + "\nEnter 2 if no is between "
                                + (mid + 1) + " - " + high);
                        int c = Convert.ToInt32(Console.ReadLine());
                        mid = (low + high) / 2;
                        if (c == 1)
                        {
                            high = mid;
                        }
                        else
                        {
                            low = mid + 1;
                        }      
                       //// return low;
                       //// return low;
                    }

                    Console.WriteLine("Gussed number " + low);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" Enter the number between 1-127 " + exception);
            }            
        }

        /// <summary>
        /// Strings the replace.
        /// </summary>
        public void StringReplace()
        {
            string string1 = "hello, username how are you.";
            string string2 = "ABC";
            Console.WriteLine("Before replaceing \n" + string1);
            string string3 = string1.Replace("username", string2);
            Console.WriteLine("after replaceing \n" + string3);
        }

        /// <summary>
        /// Prints the prime palindrome.
        /// </summary>
        /// <param name="number">The number.</param>
        public void PrintPrimePalindrome(int number)
        {
            int reminder, sum = 0, temp;        
            temp = number;
            while (number > 0)
            {
                reminder = number % 10;  
                sum = (sum * 10) + reminder;
                number = number / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("palindrome number " + sum);
            }                
            else
            {
                Console.WriteLine("not palindrome");
            }              
        }     
    }
}