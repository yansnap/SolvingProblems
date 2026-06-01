using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {

            int arrayLengh = seq.Length;

            for (int i = 0; i < arrayLengh; i++)
            {
                int count = 0;
                for (int j = 0; j < arrayLengh; j++)
                {
                    if (seq[i] == seq[j])
                        count++;
                }
                if (count % 2 != 0)
                    return seq[i];
            }

            return -1;
        }
    }
}

/*
      public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
*/


/*
 *         public static int find_it(int[] seq)
        {
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }
*/


/*
 *     public static int find_it(int[] seq) 
      {
        return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
      }
*/