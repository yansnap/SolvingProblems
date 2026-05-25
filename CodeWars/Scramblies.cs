using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class Scramblies
    {
        public bool Scrable(string str1, string str2)
        {
            Dictionary<char, int> valuePairs = [];

            for (int i = 0; i < str1.Length; i++)
            {
                if (!valuePairs.ContainsKey(str1[i]))
                {
                    valuePairs.Add(str1[i], 1);
                }

                else
                {
                    valuePairs[str1[i]] += 1;
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (!valuePairs.ContainsKey(str2[i]))
                {
                    return false;
                }
                if (valuePairs.ContainsKey(str2[i]))
                {
                    valuePairs[str2[i]] -= 1;
                    if (valuePairs[str2[i]] < 0)
                    {
                        return false;
                    }
                }
            }


            return true;
        }
    }
}



/* others solutions */
/*
    public static bool Scramble(string str1, string str2) 
    {
        return str2.All(x=>str1.Count(y=>y==x)>=str2.Count(y=>y==x));
    }
 * 
 * 
    public static bool Scramble(string str1, string str2)
    { 
		var possible = str1.ToList();

		foreach (var c in str2)
	  {
			if (!possible.Remove(c))
				return false;
		}

		return true;
	 }
 * 
 * 
 *  public static bool Scramble(string str1, string str2) 
    {
        return str2.GroupBy(c => c).All(g => str1.Where(c => c == g.Key).Count() >= g.Count());
    }
 * 
 * 
 *  public static bool Scramble(string str1, string str2)
    {
      return !str1.Aggregate(str2, (s, c) => new Regex($"{c}").Replace(s, "", 1)).Any();
    }
 * 
 * 
 * 
 */