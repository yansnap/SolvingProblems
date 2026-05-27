using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Text;

namespace LeetCode
{
    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];
            int[] left = new int[n];
            int[] right = new int[n];

            left[0] = 1;
            for (int i = 1; i < n; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }

            right[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                answer[i] = left[i] * right[i];
            }

            return answer;
        }
    }
}

/*
 *     public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int left = 1;

        //get  product of right of the array
        for (int i = 0; i < nums.Length; i++)
        {
           result[i] = left;
           left = left * nums[i];
        }
        
        int right = 1 ;
        //multiply left with right to get
        for (int i = result.Length -1; i >=0; i--)
        {
            result[i] *= right;
            right = right * nums[i]; 
        }

        return result;
    }
*/

/*
 *     public int[] ProductExceptSelf(int[] nums) {
        int N = nums.Length;
        List<int> prefix = new(){1};
        List<int> suffix = new(){1};

        for(int i=1;i<N;i++){
            prefix.Add(prefix.Last() * nums[i-1]);
        }

        for(int i=N-2;i>=0;i--){
            suffix.Insert(0,suffix.First() * nums[i+1]);
        }

        for(int i=0;i<N;i++){
            prefix[i]*=suffix[i];
        }

        return prefix.ToArray();
    }
*/