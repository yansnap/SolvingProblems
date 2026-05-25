using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int[] array = new int[arr.Length];

            int j = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                
                if (arr[i] != 0)
                {
                    array[j] = arr[i];
                    j++;
                }
                
            }
            return array;
        }
    }
}

/* 
  public static int[] MoveZeroes(int[] arr)
  {
     return arr.OrderBy(x => x==0).ToArray();
  }

  public static int[] MoveZeroes(int[] arr)
  {
    return arr.Where(x=>x!=0).Concat(arr.Where(x=>x==0)).ToArray();
  }

  public static int[] MoveZeroes(int[] arr)
  {
    var ret = new int[arr.Length];
    var index = 0;
    
    foreach (var item in arr)
    {
      if (item == 0) continue;
      ret[index] = item;
      index++;
    }
    return ret;
  }

*/