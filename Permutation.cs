using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_Program
{
    public class Permutation
    {
        public void StringPermutation()
        {
            string string1 = "abc";
            char[] array = string1.ToCharArray();

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
                   // Console.WriteLine(string2);
                    swap(string2);
                }
                break;
            }         
        }

        public static void swap(string s)
        {
            char[] c = s.ToCharArray();
            HashSet<string> myhash1 = new HashSet<string>();
            for (int i = 1; i < c.Length; i++)
            {
                for (int j = i; j < c.Length; j++)
                {
                    char[] temparray = new char[c.Length];
                    Array.Copy(c, temparray, c.Length);
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                    string s1 = new string(temparray);
                    myhash1.Add(s1);
                }
            }
            foreach (string str in myhash1)
            {
                Console.WriteLine(str);
            }
        }
    }
}
