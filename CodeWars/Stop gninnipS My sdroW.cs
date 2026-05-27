using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class Stop_gninnipS_My_sdroW
    {
        public static string SpinWords(string sentence)
        {
            string[] strings = sentence.Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length < 5)
                {
                    list.Add(strings[i]);
                }
                else
                {
                    string reversedWord = new string(strings[i].Reverse().ToArray());
                    list.Add(reversedWord);

                }
            }


            return string.Join(' ', list);
        }
    }
}

/* 
 *   public static string SpinWords(string sentence)
  {
    return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
  }
*/

/* 
 *   public static string SpinWords(string sentence)
  {
    return Regex.Replace(sentence, @"\w{5,}", m => string.Concat(m.Value.Reverse()));
  }
*/

/*
 * public static class StringJoinExtension
{
  public static string StringJoin(this IEnumerable<string> stringList, string seperator = "") => string.Join(seperator, stringList);
    
  public static string StringJoin(this IEnumerable<char> stringList, string seperator = "") => string.Join(seperator, stringList);  
}

public class Kata
{
  public static string SpinWords(string sentence) => 
      sentence
         .Split(' ')
         .Select(word => word.Length < 5 ? word : word.Reverse().StringJoin())
         .StringJoin(" ");              
}
*/