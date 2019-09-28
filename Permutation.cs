// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace FellowShip_Program
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Permutation on Strings
    /// </summary>
    public class Permutation
    {
        /// <summary>
        /// permute the specified string.
        /// </summary>
        /// <param name="string3">The string3.</param>
        public static void PermuteString(string string3)
        {
            char[] chararray2 = string3.ToCharArray();
            HashSet<string> myhash1 = new HashSet<string>();
            for (int i = 1; i < chararray2.Length; i++)
            {
                for (int j = i; j < chararray2.Length; j++)
                {
                    char[] temparray = new char[chararray2.Length];
                    Array.Copy(chararray2, temparray, chararray2.Length);
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                    string string4 = new string(temparray);
                    myhash1.Add(string4);
                }
            }
            //// iterate HashSet
            foreach (string str in myhash1)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// String permutation.
        /// </summary>
        public void StringPermutation()
        {
            string string1 = "abc";
            char[] array = string1.ToCharArray();

            //// iterate the array
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    char[] array2 = new char[array.Length];
                    Array.Copy(array, array2, array.Length);
                    char temp = array2[i];
                    array2[i] = array2[j];
                    array2[j] = temp;

                    string string2 = new string(array2);
                   //// Console.WriteLine(string2);
                    PermuteString(string2);
                }

                break;
            }         
        }  
    }
}
