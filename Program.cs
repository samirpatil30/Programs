using FellowShip_Program.Coin_Percentage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_Program.Add

{
    class Program
    {
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
               "\n 20)File operation");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.coin_percentage1();
                    break;
                case 2:
                    GamblerProblem gamblerProblem = new GamblerProblem();
                    gamblerProblem.Gambler_Problem();
                    break;

                case 3:
                    Harmonic harmonic = new Harmonic();
                      harmonic.Harmonic_Series();
                    break;
                case 4:
                    Prime_Number prime = new Prime_Number();
                    prime.Prime_Factor();
                    break;
                case 5:
                    LeapYear leapYear = new LeapYear();
                    leapYear.LeapYear_Checker();
                    break;
                case 6:
                    PowerTable powerTable = new PowerTable();
                    powerTable.Power_Table();
                    break;
                case 7:
                    Coupon_Generation coupon = new Coupon_Generation();
                    coupon.Generate_Coupon();
                    break;
                case 8:
                    TwoD_Array two= new TwoD_Array();
                    two.twoD_Array();
                    break;
                case 9:
                    Array_Triplets array_Triplets = new Array_Triplets();
                    array_Triplets.Array_triplets();
                    break;
                case 10:
                    Anagram anagram = new Anagram();
                    anagram.Anagram_checker();
                    break;
                case 11:
                    Prime_Range prime_Range = new Prime_Range();
                    prime_Range.prime_Range_Printer();
                    break;
                case 12:
                    BinarySearchInteger binary = new BinarySearchInteger();
                    binary.binarySearch();
                    break;
                case 13:
                    Bubble_Sort bubble = new Bubble_Sort();
                    bubble.bubble_sort();
                    break;
                case 14:
                    Day_Of_week day = new Day_Of_week();
                    day.day_Of_Week();
                    break;
                case 15:
                    Binary_Of_Number binary_Of_Number = new Binary_Of_Number();
                    binary_Of_Number.binary_of_digit();
                    break;
                case 16:
                    Tempeature_Conversion tempeature_Conversion = new Tempeature_Conversion();
                    tempeature_Conversion.Convert_tempeature();
                    break;
                case 17:
                    MonthlyPayment payment = new MonthlyPayment();
                    payment.car_loan();
                    break;
                case 18:
                    Inseration_Sort inseration_ = new Inseration_Sort();
                    inseration_.inseration_sort();
                    break;
                case 19:
                    Vending_machine vending = new Vending_machine();
                    vending.vending_Machine();
                    break;
                case 20:
                    File_Operation operation = new File_Operation();
                    operation.Operation_File();
                    break;
            }

            
            Console.ReadKey();
        }
    }
}
