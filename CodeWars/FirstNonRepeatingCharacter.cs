using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class FirstNonRepeatingCharacter
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            string newS = s.ToLower();
            for (int i = 0; i < s.Length; ++i)
            {
                if (newS.LastIndexOf(newS[i]) == newS.IndexOf(newS[i]))
                {

                    return s[i].ToString();
                }
            }
                return "";
        }
    }
}


/* ANOTHERS SOLUTIONS
  public static string FirstNonRepeatingLetter(string s)
  {
    return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
  }

  public static string FirstNonRepeatingLetter(string s)
  {
    var ret = s.GroupBy(z => char.ToLower(z)).Where(g => g.Count() == 1).FirstOrDefault();
    return (ret != null) ? ret.First().ToString() : string.Empty;
  }

  public static string FirstNonRepeatingLetter(string s)
  { 
    return s.GroupBy(char.ToLower).FirstOrDefault(_ => _.Count() == 1)?.First().ToString() ?? string.Empty;
  }
*/