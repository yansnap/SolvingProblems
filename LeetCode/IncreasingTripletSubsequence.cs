using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int smallest = int.MaxValue;
            int middle = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
               if (nums[i] <= smallest)
               {
                    smallest = nums[i];
               }
               else if (nums[i] >= smallest && nums[i] <= middle)
               {
                    middle = nums[i];
               }
               else
               {
                    return true;
               }
            }
            return false;
        }
    }
}
