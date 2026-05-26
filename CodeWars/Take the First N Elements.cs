using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class Take_the_First_N_Elements
    {
        public static int[] Take(int[] arr, int n)
        {
            List<int> ints = new List<int>();
            if (arr.Length == 0 || n == 0)
            {
                return ints.ToArray();
            }
            for(int i = 0; i < Math.Min(n, arr.Length); i++)
            {
                ints.Add(arr[i]);
            }

            return ints.ToArray();
        }
    }
}

/*
 *  public static int[] Take(int[] arr, int n) => arr[0..System.Math.Min(n,arr.Length)];
 */

/*
 *         n = Math.Min(arr.Length, n);
        var dest = new int[n];
        Array.Copy(arr, dest, n);
        return dest;
*/

/*
 *       if(arr.Length==0 )return new int[]{};
        return Enumerable.Range(0, n).Where(x=>x<arr.Length).Select(x => arr[x]).ToArray();
*/