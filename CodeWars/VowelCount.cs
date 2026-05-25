using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelCount++;
                }
            }


            return vowelCount;
        }


        /* Others solutions*/

        /*     
         public static int GetVowelCount(string str)
         {
         return str.Count(i => "aeiou".Contains(i));
         }
         public static int GetVowelCount(string str)
         {
         return str.ToLower().Count(c=> "aeiou".IndexOf(c) != -1);
         }
         public static int GetVowelCount(string str)
         {
         return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
         }
         
         */
    }
}
