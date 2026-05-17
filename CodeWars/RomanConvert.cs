using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    internal class RomanConvert
    {
        public static string Solution(int n)
        {
            Dictionary<int, string> romanNumbers = new Dictionary<int, string>();
            romanNumbers.Add(1, "I");
            romanNumbers.Add(4, "IV");
            romanNumbers.Add(5, "V");
            romanNumbers.Add(9, "IX");
            romanNumbers.Add(10, "X");
            romanNumbers.Add(40, "XL");
            romanNumbers.Add(50, "L");
            romanNumbers.Add(90, "XC");
            romanNumbers.Add(100, "C");
            romanNumbers.Add(400, "CD");
            romanNumbers.Add(500, "D");
            romanNumbers.Add(900, "CM");
            romanNumbers.Add(1000, "M");

            string romanNumber = "";
            
            foreach (int coin in romanNumbers.Keys.Reverse())
            {
                while (n >= coin)
                {
                    n -= coin;

                    romanNumber += romanNumbers[coin];
                }
            }

            return romanNumber;
        }
    }
}
