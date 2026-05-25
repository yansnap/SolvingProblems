using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class ReversedStrings
    {
        public string Solution(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

    }
}
