using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Text;

namespace CodeWars
{
    internal class SplitStrings
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
            {
                str += '_';
            }
            List<string> splitedStrings = new List<string>();
            for (int i = 0; i < str.Length; i+=2)
            {
                splitedStrings.Add(str.Substring(i,2));
            }

            return splitedStrings.ToArray();
        }
    }
}
