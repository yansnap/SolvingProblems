using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class StringCompression
    {
        public int Compress(char[] chars)
        {
            int read = 0;
            int write = 0;
            while (read < chars.Length)
            {
                char currentChar = chars[read];
                int count = 0;

                while (read < chars.Length && chars[read] == currentChar)
                {
                    read++;
                    count++;
                }

                chars[write] = currentChar;
                write++;
                
                if (count > 1)
                {
                    foreach(char c in count.ToString())
                    {
                        chars[write] = c;
                        write++;
                    }
                }
            }


            return write;
        }
    }
}


/*
 * public int Compress(char[] chars) 
    {
        var write = 0;

        for (int read = 0, count = 0; read < chars.Length; read++)
        {
            count++;

            if (read == chars.Length - 1 || chars[read] != chars[read + 1])
            {
                chars[write++] = chars[read];

                if (count > 1)
                {
                    foreach (var c in count.ToString())
                    {
                        chars[write++] = c;
                    }
                }

                count = 0;
            }
        }        

        return write;
    }
*/

/*
 *     public int Compress(char[] chars) {
        int n = chars.Length;
        int read = 0;
        int write = 0;

        while (read < n) {
            char ch = chars[read];
            int count = 0;

            // count same consecutive chars
            while (read < n && chars[read] == ch) {
                read++;
                count++;
            }

            chars[write] = ch;
            write++;

            if (count == 1) {
                continue;
            }

            // find max divider. count = 123 -> div = 100
            int div = 1;
            while (count / div >= 10) {
                div *= 10;
            }

            // write digits of the count from left to right
            while (div > 0) {
                int digit = count / div;
                chars[write] = (char)('0' + digit);
                write++;

                count %= div;
                div /= 10;
            }
        }

        return write;
    }
*/

/*
 *     public int Compress(char[] chars) {
        if( chars.Length <= 1) return chars.Length;
        int j = 1;
        int start = 0;
        int end = chars.Length - 1;
        int count = 1;
        string s = "";
        while(start < end && j<=end){
            if(chars[start] == chars[j]){
                count++;
                j++;
                
            }else{
                if(count == 1){
                s = s+chars[start];
                start = j;
                j++;
                count = 1;
                }else{
                s = s+chars[start]+count;
                start = j;
                j++;
                count = 1;
                }
                
            }
        }
        
        if(count == 1){
            s = s+chars[start];
        }else{
            s = s+chars[start]+count;
        }
        Console.WriteLine(s);
        for(int i = 0; i<s.Length; i++){
             chars[i] = s[i];
        }
        return s.Length;
    }
*/