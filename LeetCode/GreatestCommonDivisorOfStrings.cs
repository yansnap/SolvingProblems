using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCode
{
    class GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return String.Empty;
            }

            return str1.Substring(0, GCD(str1.Length, str2.Length));
        }

        public int GCD(int a, int b)
        {

            return b == 0 ? a : GCD(b, a % b);
        }
    }

    /* ANOTHERS SOLUTIONS
    public string GcdOfStrings(string str1, string str2) {
        if(str1+str2!=str2+str1)
        {
            return "";
        }
        int gcd=GCD(str1.Length,str2.Length);
        return str1.Substring(0,gcd);
    }
    private int GCD(int a, int b)
    {
        while(b!=0)
        {
            int temp=b;
            b=a%b;
            a=temp;
        }
        return a;

     }

        public string GcdOfStrings(string str1, string str2) {
            for (int len = Math.Min(str1.Length, str2.Length); len >= 1; len--)
            {
                if (str1.Length % len == 0 && str2.Length % len == 0)
                {
                    string candidate = str2.Substring(0, len);
                    if (str1 == string.Concat(Enumerable.Repeat(candidate, str1.Length / len)) &&
                        str2 == string.Concat(Enumerable.Repeat(candidate, str2.Length / len)))
                        return candidate;
                }
            }
            return "";
        }
     * 
     */
}
