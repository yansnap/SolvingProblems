using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LeetCode
{
    /* 
    You are given an integer array height of length n. There are n vertical lines drawn such
    that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    Find two lines that together with the x-axis form a container, such that the container
    contains the most water. Return the maximum amount of water a container can store.
    Notice that you may not slant the container.
    */ 
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int startIndex = 0;
            int lastIndex = height.Length - 1;
            int areOfWater = 0;
            int result = 0;
            int width = 0;
            
            while (startIndex < lastIndex)
            {
                width = lastIndex - startIndex;
                areOfWater = width * Math.Min(height[startIndex], height[lastIndex]);
                if (areOfWater > result)
                    result = areOfWater;
                if (height[startIndex] < height[lastIndex])
                {
                    startIndex++;
                }
                else
                {
                    lastIndex--;
                }
            }


            return result;
        }
    }
}

/*
     public int MaxArea(int[] height) {
        var left = 0;
        var right = height.Length - 1;

        var best = 0;

        while (left < right) {
            best = Math.Max(best, (Math.Min(height[left], height[right])) * (right - left));

            if (height[right] >= height[left]) {
                left++;
            } else {
                right--;
            }
        }
        GC.Collect();
        return best;
    }
*/