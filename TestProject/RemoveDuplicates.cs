using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class RemoveDuplicates
    {
        public string RemoveDuplicateCharacters(string input)
        {
            // Using a StringBuilder to construct the result
            StringBuilder result = new StringBuilder();

            // HashSet to keep track of characters we've already added
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in input)
            {
                // Skip spaces and duplicates
                if (c != ' ' && !seen.Contains(c))
                {
                    result.Append(c);
                    seen.Add(c);
                }
            }

            return result.ToString();
        }

        public string[] RemoveDuplicatesInAnArray(string[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array must contain 2 elements");

            return array.Distinct().ToArray();
        }

        public string[] RemoveDuplicatesInAnArrayLogic(string[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array must contain 2 elements");

            List<string> result = new List<string>();
            HashSet<string> unique = new HashSet<string>();

            foreach (string s in array)
            {
                if(s != " " && !unique.Contains(s))
                {
                    unique.Add(s);
                    result.Add(s);
                }
            }

            return result.ToArray();
        }

        public string[] RemoveDuplicatesInArrayLogic2(string[] input)
        {
            if (input == null || input.Length == 0)
                return Array.Empty<string>();

            HashSet<string> uniqueSet = new(input);
            return uniqueSet.ToArray();
        }

    }
}
