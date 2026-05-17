using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace CodeWars
{
    internal class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            string[] words = str.Split(' ');
            List<string> newList = new List<string>();
            for (int i = 0; i < words.Length; ++i)
            {
                if (Char.IsLetter(words[i].First())) 
                {
                    newList.Add(words[i].Substring(1) + words[i].First() + "ay");
                } 
                else  
                {
                    newList.Add(words[i]);
                }

            }

            return string.Join(' ', newList);
        }
    }
}
