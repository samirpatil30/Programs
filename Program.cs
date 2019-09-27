using FellowShip_Program.Coin_Percentage;
using System;

namespace FellowShip_Program.Add
{
    /// <summary>
    /// Main
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
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
               "");

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
                    two.TwoD_Array();
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
                    Tempeature_Conversion tempeature_Conversion = new Tempeature_Conversion();
                    tempeature_Conversion.ConvertTemperature();
                    break;
                case 17:
                    MonthlyPayment payment = new MonthlyPayment();
                    payment.Car_loan();
                    break;
                case 18:
                    Inseration_Sort inseration_ = new Inseration_Sort();
                    inseration_.InsertionSort();
                    break;
                case 19:
                    Vending_machine vending = new Vending_machine();
                    vending.VendingMachine();
                    break;
                case 20:
                    File_Operation operation = new File_Operation();
                    operation.Operation_File();
                    break;
                case 21:
                    Permutation permutation = new Permutation();
                    permutation.StringPermutation();                  
                    break;
                case 22:
                    TicTacToe ticTacToe = new TicTacToe();
                    ticTacToe.PlayGame();
                    break;
            }
           
            Console.ReadKey();
        }
    }
}
