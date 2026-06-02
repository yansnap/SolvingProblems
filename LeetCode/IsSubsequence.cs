using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class IsSubsequence
    {
        public bool IsSubsequenceM(string s, string t)
        {
            if (s.Length == 0)
                return true;

            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }

            return sIndex == s.Length;
        }
    }
}
