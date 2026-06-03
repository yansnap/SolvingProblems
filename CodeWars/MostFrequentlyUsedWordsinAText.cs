using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    internal class MostFrequentlyUsedWordsinAText
    {
        /*
         * Write a function that, given a string of text (possibly with punctuation and line-breaks), 
         * returns an array of the top-3 most occurring words, in descending order of the number of 
         * occurrences.
         */
        public static List<string> Top3(string s)
        {

            Dictionary<string, int> storage = CountWords(s);

            List<string> winners = FindTopThree(storage);

            return winners;
        }
        private static Dictionary<string, int> CountWords(string text)
        {
            StringBuilder sb = new();
            string word = String.Empty;
            Dictionary<string, int> storage = [];

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]) || text[i] == '\'')
                    sb.Append(text[i]);
                else
                {
                    ProcessBufferAndAddToStorage();
                }

            }

            ProcessBufferAndAddToStorage();

            void ProcessBufferAndAddToStorage()
            {
                if (sb.Length > 0)
                {
                    word = sb.ToString().ToLower();
                    if (word.Any(Char.IsLetter))
                    {
                        storage.TryGetValue(word, out int currentCount);
                        storage[word] = currentCount + 1;
                    }
                    sb.Clear();

                }
            }
            return storage;
        }

        private static List<string> FindTopThree(Dictionary<string, int> storage)
        {
            List<string> winners = new();

            int first = 0;
            int second = 0;
            int third = 0;
            string gold = String.Empty;
            string silver = String.Empty;
            string bronze = String.Empty;
            foreach (var pair in storage)
            {
                if (pair.Value > first)
                {
                    third = second;
                    second = first;
                    first = pair.Value;

                    bronze = silver;
                    silver = gold;
                    gold = pair.Key;

                }
                else if (pair.Value > second)
                {
                    third = second;
                    second = pair.Value;

                    bronze = silver;
                    silver = pair.Key;


                }
                else if (pair.Value > third)
                {
                    third = pair.Value;
                    bronze = pair.Key;
                }

            }
            if (!string.IsNullOrEmpty(gold))
                winners.Add(gold);
            if (!string.IsNullOrEmpty(silver))
                winners.Add(silver);
            if (!string.IsNullOrEmpty(bronze))
                winners.Add(bronze);

            return winners;

        }
    }
}

/*
 *     public static List<string> Top3(string s)
    {
        return Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
            .GroupBy(match => match.Value)
            .OrderByDescending(g => g.Count())
            .Select(p => p.Key)
            .Take(3)
            .ToList();
    }
*/

/*
 *     var alphabets = new HashSet<char>(Enumerable.Range('a', 26).Select(i => (char)i));
    var separators = Enumerable.Range(0, 256).Select(i => (char)i).Where(c => !alphabets.Contains(c) && c != '\'').ToArray();

    return s.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries)
          .Select(word => new string(word.Where(alphabets.Append('\'').Contains).ToArray()))
          .Where(word => alphabets.Any(word.Contains))
          .GroupBy(word => word)
          .OrderByDescending(group => group.Count())
          .Take(3)
          .Select(group => group.Key)
          .ToList();
  }
*/


/*
 *         struct countWord
        {
            public countWord(string word, int count)
            {
                Word = word;
                myCount = count;
            }

            public string Word;
            public int myCount;

        }

        public static List<string> Top3(string s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
                s = s.Replace("  ", " ");

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] == 39)
                    continue;
                s = s.Replace(s[i], ' ');
            }

            if (String.IsNullOrEmpty(s))
                return new List<string>();

            string[] words = s.Split(' ');
            List<countWord> countWordList = new List<countWord>();

            bool isAlready = false;
            for (int i = 0; i < words.Length; i++)
            {
                isAlready = false;
                for (int j = 0; j < countWordList.Count; j++)
                {
                    if (!String.IsNullOrEmpty(words[i]) && words[i] == countWordList[j].Word)
                    {
                        countWordList[j] = new countWord(words[i], countWordList[j].myCount + 1);
                        isAlready = true;
                    }
                }
                if (isAlready == false && !String.IsNullOrEmpty(words[i]))
                    countWordList.Add(new countWord(words[i], 1));
            }

            countWordList = countWordList.OrderByDescending((el) => el.myCount).ToList();

            List<string> result = new List<string>();
            for (int i = 0; i < countWordList.Count && i < 3; i++)
            {
                if (countWordList[i].Word != new string('\'', countWordList[i].Word.Length))
                    result.Add(countWordList[i].Word);
            }

            return result;
        }

*/