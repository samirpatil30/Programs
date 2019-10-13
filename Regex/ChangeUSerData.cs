// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeUserData.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented
{
    using System;
    using System.Text.RegularExpressions;
    /// <summary>
    /// Change User Data
    /// </summary>
    public class ChangeUserData
    {
        /// <summary>
        /// Replace Name
        /// </summary>
        public void ReplaceName()
        {
            ////Create instance of Regex
            Regex regex = new Regex("[a - zA - Z][a-zA-Z]");
            Regex regexForMobile = new Regex(("(0/91)?[7-9][0-9]{9}"));
            string userString = " Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you";
            Console.WriteLine(userString);
            Console.WriteLine();    
            Console.WriteLine("User enter your full name");      
            string userName = Console.ReadLine();          
            bool result = true;
            result = regex.IsMatch(userName);          
            do
            {
            lable: if (result == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("User enter your full name");
                    userName = Console.ReadLine();
                    result = regex.IsMatch(userName);
                    goto lable;
                }              
            } while (result == true);

            char[] array = userName.ToCharArray();
            string firstName = string.Empty;

            ////Iterate array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != ' ')
                {
                    firstName += array[i];
                }
                else
                {
                    break;
                }
            }

            string nameInstring = "<<name>>";
            string fullName = "<<full name>>";
            string userMobleNumber = "91-xxxxxxxxxx.";

            Console.WriteLine("Enter mobile number of user");
            string userNumber = Console.ReadLine();

            bool result1 = true;
            result1 = regexForMobile.IsMatch(userNumber);
            do
            {
                lable1: if (result1 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("User enter your mobile number");
                    userNumber = Console.ReadLine();
                    result1 = regexForMobile.IsMatch(userNumber);
                    goto lable1;
                }
            } while (result1 == true);

            regex = new Regex(nameInstring);
            string updatedUserResult = regex.Replace(userString, firstName);

            regex = new Regex(fullName);
            string newUpadatedResult = regex.Replace(updatedUserResult, userName);

            regex = new Regex(userMobleNumber);
            string finalResult = regex.Replace(newUpadatedResult, userNumber);

            Console.WriteLine();
            Console.WriteLine(finalResult);
        }           
   }
}
