using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int largestAmount = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= largestAmount)
                {
                    result.Add(true);
                    continue;
                }
                result.Add(false);
            }

            return result;
        }
    }
}


/* 
     public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int target = 0;
        foreach (int candy in candies)
        {
            target = Math.Max(candy, target);
        }

        bool[] results = new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++)
        {
            results[i] = candies[i] + extraCandies >= target;
        }

        return results;
    }
 
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = 0;
        int n = candies.Length;
        IList<bool> rtn = new List<bool>(); 

        for (int i = 0; i < n; i++) {
            if (candies[i] > max) {
                max = candies[i];
            }
        }
        for (int i = 0; i < n; i++) {
            if (candies[i] + extraCandies >= max) {
                rtn.Add(true);
            }
            else {
                rtn.Add(false);
            }
        }
        return rtn;
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

        bool[] results = new bool[candies.Length]; 
        // Need to do one pass at minimum
        // One pass to populate dict, then targeted pass at only values that need updating.
        // Might be able to do faster

        Dictionary<int, List<int>> Sweets = new(candies.Length);

        int highest = 0;

        // Populate dictionary of indexes at each candies value.
        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] > highest) highest = candies[i];

            ref var list = ref CollectionsMarshal.GetValueRefOrAddDefault(Sweets, candies[i], out bool exists);
            if (!exists)
            {
                list = new List<int>();
            }
            list.Add(i);
        }

        int lowestPotentialLargest = highest - extraCandies; // no -1 because multiple kids can win, even if they started with the winning number

        for (int i = lowestPotentialLargest; i <= highest; i++)
        {
            if (Sweets.TryGetValue(i, out var value))
            {
                foreach (var index in value)
                {
                    results[index] = true;
                }
            }
        }

        return results;




    }
 
 
 */