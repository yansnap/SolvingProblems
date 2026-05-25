using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class CanIPlaceFlowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {

                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (flowerbed.Length - 1 == i || flowerbed[i + 1] == 0))
                {
                    n -= 1;
                    flowerbed[i] = 1;
                }              
            }

            return n <= 0;

        }
    }
}
