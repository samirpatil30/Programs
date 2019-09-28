// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program.Add
{
    using System;
    using FellowShip_Program.Coin_Percentage;

    /// <summary>
    /// Main: Entry point in program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("1)FlipCoin" +
                "\n 2)Gambler_problem" +
               "\n 3)Harmonic Sreies" +
               "\n 4)Prime Factor" +
               "\n 5)Leap Year" +
               "\n 6)power table" +
               "\n 7)Coupon Generation" +
               "\n 8) 2D Array" +
               "\n 9)Array_Triplets" +
               "\n 10)Anagram of string" +
               "\n 11)Print prime number in range" +
               "\n 12)Binary search integer" +
               "\n 13)Bubble Sort" +
               "\n 14)Day_Of_week" +
               "\n 15)Binary Of number" +
               "\n 16)Tempeature Conversion" +
               "\n 17)Monthly Payment" +
               "\n 18)Inseration Sort" +
               "\n 19)Vending Machine" +
               "\n 20)File operation" +
               "\n 21)String Permutation" +
               "\n 22)Euclidean Distance" +
               "\n 23)Magic number" +
               "\n 24)Quadratic" +
               "\n 25)String Repalce");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CoinPercentage1();
                    break;
                case 2:
                    GamblerProblem gamblerProblem = new GamblerProblem();
                    gamblerProblem.Gamblerproblem();
                    break;

                case 3:
                    Harmonic harmonic = new Harmonic();
                      harmonic.HarmonicSeries();
                    break;
                case 4:
                    Prime_Number prime = new Prime_Number();
                    prime.PrimeFactor();
                    break;
                case 5:
                    LeapYear leapYear = new LeapYear();
                    leapYear.LeapYearChecker();
                    break;
                case 6:
                    PowerTable powerTable = new PowerTable();
                    powerTable.Powertable();
                    break;
                case 7:
                    Coupon_Generation coupon = new Coupon_Generation();
                    coupon.GenerateCoupon();
                    break;
                case 8:
                    TwoDArray two = new TwoDArray();
                    two.Two_DArray();
                    break;
                case 9:
                    Array_Triplets array_Triplets = new Array_Triplets();
                    array_Triplets.Arraytriplets();
                    break;
                case 10:
                    Anagram anagram = new Anagram();
                    anagram.AnagramChecker();
                    break;
                case 11:
                    Prime_Range prime_Range = new Prime_Range();
                    prime_Range.PrimeRangePrinter();
                    break;
                case 12:
                    BinarySearchInteger binary = new BinarySearchInteger();
                    binary.BinarySearch();
                    break;
                case 13:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Bubblesort();
                    break;
                case 14:
                    DayOfweek day = new DayOfweek();
                    day.DayOfWeek();
                    break;
                case 15:
                    BinaryOfNumber binaryOfNumber = new BinaryOfNumber();
                    binaryOfNumber.BinaryOfDigit();
                    break;
                case 16:
                    TemperatureConversion tempeature_Conversion = new TemperatureConversion();
                    tempeature_Conversion.ConvertTemperature();
                    break;
                case 17:
                    MonthlyPayment payment = new MonthlyPayment();
                    payment.Car_loan();
                    break;
                case 18:
                    Insertion_Sort inseration_ = new Insertion_Sort();
                    inseration_.InsertionSort();
                    break;
                case 19:
                    Vendingmachine vending = new Vendingmachine();
                    vending.VendingMachine();
                    break;
                case 20:
                    FileOperation operation = new FileOperation();
                    operation.Operation_File();
                    break;
                case 21:
                    Permutation permutation = new Permutation();
                    permutation.StringPermutation();                  
                    break;
                case 22:
                    DistanceBetweenPoint distance = new DistanceBetweenPoint();
                    distance.CalculateDistance();
                    break;
                case 23:
                    MagicNumber magic = new MagicNumber();
                    magic.FindMagicNumber();
                    break;
                case 24:
                    Quadratic quadratic = new Quadratic();
                    quadratic.QuadraticMethod();
                    break;
                case 25:
                    StringReplace replace = new StringReplace();
                    replace.ReplaceString();
                    break;
            }
           
            Console.ReadKey();
        }
    }
}
