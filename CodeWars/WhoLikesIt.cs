using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeWars
{
    internal class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            int lengthOfName = name.Length;
            StringBuilder result = new StringBuilder();

            if (lengthOfName == 0)
            {
                return result.Append("no one likes this").ToString();
            }

                switch (lengthOfName)
                {
                    case 1:
                        result.Append(name[0]);
                        return result.Append(" likes this").ToString();
                    case 2:
                        result.Append(name[0]);
                        result.Append(" and " + name[1]);
                        return result.Append(" like this").ToString();
                    case 3:
                        result.Append(name[0] + ", ");
                        result.Append(name[1] + " and ");
                        result.Append(name[2]);
                        return result.Append(" like this").ToString();
                    case > 4:
                        result.Append(name[0] + ", ");
                        result.Append(name[1] + " and ");
                        result.Append($"{lengthOfName - 2} others");
                        return result.Append(" like this").ToString();
                }

            return result.ToString();
        }
    }
}


/* 
   public static string Likes(string[] names)
  {
    switch (names.Length)
    {
      case 0: return "no one likes this"; // :(
      case 1: return $"{names[0]} likes this";
      case 2: return $"{names[0]} and {names[1]} like this";
      case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
      default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
    }
  }
 
  public static string Likes(string[] name)
    => name.Length switch
    {
      0 => "no one likes this",
      1 => $"{name[0]} likes this",
      2 => $"{name[0]} and {name[1]} like this",
      3 => $"{name[0]}, {name[1]} and {name[2]} like this",
      _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
    };

    public static string Likes(string[] name)
    {
        string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };

        return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
    }
 
 */