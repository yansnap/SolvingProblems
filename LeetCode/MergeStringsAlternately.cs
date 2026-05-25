using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int theLargestWord = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < theLargestWord; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}
