using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Anagram
    {
        public List<List<string>> FindAnagrams(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                Console.Write("Array has no elements");
                return new List<List<string>>();
            }
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach(string word in words)
            {
                string normalizedString = word.ToLower();
                string sortedWord = new string(normalizedString.OrderBy(c => c).ToArray());

                if (!anagramGroups.ContainsKey(sortedWord))
                {
                    anagramGroups[sortedWord] = new List<string>();
                }

                anagramGroups[sortedWord].Add(word);
            }

            return anagramGroups.Values.Where(group => group.Count > 1).ToList();
        }
    }
}
