using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    internal class ReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            char[] newS = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
              while(left < right && !vowels.Contains(s[left]))
              {
                  left++;
              }
              while (left < right && !vowels.Contains(s[right]))
              {
                  right--;
              }
              if (left < right)
              {
                  newS[left] = s[right];
                  newS[right] = s[left];
                  left++;
                  right--;
              }
            }
            return new string(newS);
        }


    }


    /* 
     *  public string ReverseVowels(string s)
        => string.Create(s.Length, s, (span, input) =>
            {
                input.AsSpan().CopyTo(span);

                var left = 0;
                var right = input.Length - 1;

                while (left < right)
                {
                    while (left < right && !IsVowel(span[left])) left++;
                    while (left < right && !IsVowel(span[right])) right--;

                    if (left == right) return;

                    var tmp = span[left];
                    span[left] = span[right];
                    span[right] = tmp;
                    left++;
                    right--;
                    
                }
            }
        );
    
    private bool IsVowel(char c)
    => c switch
        {
            'a' or 'e' or 'i' or 'o' or 'u' or 'A'or 'E' or 'I' or 'O' or 'U' => true,
            _ => false
        };
    */
}


