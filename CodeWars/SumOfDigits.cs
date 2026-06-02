using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class SumOfDigits
    {
        //Digital root is the recursive sum of all the digits in a number.
        // Given n, take the sum of the digits of n.If that value has more than one digit,
        // continue reducing in this way until a single-digit number is produced.The input
        // will be a non-negative integer.
        public static int DigitalRoot(long n)
        {
            while (n > 9)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (int) (n % 10);
                    n = n / 10;
                }
                n = sum;
            }

            return (int)n;
        }
    }
}

/* 
 * if (n == 0) return 0;
    return (int)(1 + (n - 1) % 9);
*/

/*
 *     var number = n.ToString().Sum(e => int.Parse(e.ToString()));

            return number > 9 ? DigitalRoot(number) : number;
*/