using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    internal class ReverseWordsInAString
    {
        public static string ReverseWords(string s) => 
            string.Join(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        
    }
}


/* Other solutions */

/*
     public string ReverseWords(string s) {
        var sb = new StringBuilder();

        var fast = s.Length - 1;

        while (s[fast] == ' ' && fast >= 0) fast--;
        var slow = fast;

        while (fast >= 0)
        {
            if (s[fast] == ' ')
            {
                while (fast >= 0)
                {
                    if (fast < 0 || (fast > 0 && s[fast - 1] != ' '))
                    {
                        sb.Append(' ');
                        fast--;
                        slow = fast;
                        break;
                    }

                    fast--;
                }
            }
            else
            {
                while (fast >= 0)
                {
                    if (fast <= 0 || (fast > 0 && s[fast - 1] == ' '))
                    {
                        var lastIndex = fast - 1;

                        while (fast <= slow)
                        {
                            sb.Append(s[fast]);
                            fast++;
                        }

                        fast = lastIndex;
                        slow = lastIndex;

                        break;
                    }

                    fast--;
                }
            }
        }

        return sb.ToString();
    }

*/

/*
    public string ReverseWords(string s) {

        char[] arr = s.ToCharArray();
        int n = arr.Length;

        // Reverse Entire Array
        Reverse(arr, 0, n-1);

        int left = 0, right = 0, i = 0;

        while(i<n)
        {
            while(i<n && arr[i] == ' ') i++;
            if( i == n) break;

            while(i<n && arr[i] != ' ')
            arr[right++] = arr[i++];

            Reverse(arr, left, right-1);
            
            
        while (i < n && arr[i] == ' ') i++;

        // Step 6: add ONE space only if another word exists
        if (i < n) arr[right++] = ' ';

        left = right;

        }

        return new string(arr, 0, right);      
    }

    
    static void Reverse(char[] arr, int l, int r)
    {
        while (l < r)
        {
            char temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            l++;
            r--;
        }
    }
 */

/*
 *     public string ReverseWords(string s) {
        var sb = new System.Text.StringBuilder();
        int i = s.Length - 1;

        while (i >= 0) {
            // Skip trailing spaces
            while (i >= 0 && s[i] == ' ') i--;
            if (i < 0) break;

            // Find the end of the current word
            int end = i;
            while (i >= 0 && s[i] != ' ') i--;

            // Extract word and append with a space if needed
            if (sb.Length > 0) sb.Append(" ");
            sb.Append(s.Substring(i + 1, end - i));
        }

        return sb.ToString();
    }
*/