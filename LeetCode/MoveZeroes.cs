using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LeetCode
{
    internal class MoveZeroes
    {
       //Given an integer array nums, move all 0's to the end of it while maintaining
       //the relative order of the non-zero elements.
       //Note that you must do this in-place without making a copy of the array.
       public int[] MoveZeroesM(int[] nums)
       {
            int lengthOfArray = nums.Length;
            int count = 1;
            int writer = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {
                 if (nums[i] != 0)
                 {
                    nums[writer] = nums[i];
                    writer++;
                 }
            }
            for (int i = writer; i < lengthOfArray; i++)
            {
                nums[i] = 0;
            }

            return nums;
       }
    }
}


/*
     public void MoveZeroes(int[] nums) {
        int j=0;
        int temp;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
                j++;
                
            }
        }
        GC.Collect();
    }
*/

/*
 *     public void MoveZeroes(int[] nums) {
        int l = 0;
        int r = 0;

        while (r < nums.Length)
        {
            if (nums[l] != 0)
            {
                l++;
                r++;
            }
            else if (nums[r] != 0)
            {
                nums[l] = nums[r];
                nums[r] = 0;
                l++;
                r++;
            }
            else
                r++;
                
        }
*/

/*
    public void MoveZeroes(int[] nums) {
        var temp = nums.OrderBy(x => x == 0).ToArray();
        for (var i = 0; i < temp.Length; i++) {
            nums[i] = temp[i];
        }
    }
 
 */