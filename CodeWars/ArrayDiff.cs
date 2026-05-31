using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace CodeWars
{
    internal class ArrayDiff
    {
        public static int[] ArrayDiffM(int[] a, int[] b)
        {
            int[] tempArray = new int[a.Length];
            int arrayALength = a.Length;
            int arrayBLength = b.Length;

            if (arrayBLength == 0)
                return a;

            int count = 0;
            for (int i = 0; i < arrayALength; i++)
            {
                if (!CustomContains(b, a[i]))
                {
                    tempArray[count] = a[i];
                    count++;
                }
            }


            return CustomToArray(tempArray, count);
        }

        public static bool CustomContains(int[] array, int target)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] == target)
                    return true;

            }       
            return false;
        }

        public static int[] CustomToArray(int[] array, int actualCount)
        {
            int[] finalArray = new int[actualCount];

            for (int i = 0; i < actualCount; i++)
            {
                finalArray[i] = array[i];
            }

            return finalArray;
        }
    }           
       
}

/*
 * return a.Where(n => !b.Contains(n)).ToArray();
 */

/*
 *     // With a hashset, we won't have to iterate over b for every item in a.
    // Instead, we can check if an item exists in constant time
    HashSet<int> bSet = new HashSet<int>(b);
    
    return a.Where(v => !bSet.Contains(v)).ToArray();
*/

/*
 * 
 *     var sb = new HashSet<int>(b);
    return Array.FindAll(a, x => !sb.Contains(x));
*/