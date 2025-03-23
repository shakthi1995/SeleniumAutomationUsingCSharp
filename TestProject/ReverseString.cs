using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ReverseString
    {
        public string ReverseAString(string input)
        {
            char[] charArray = input.ToCharArray();  // Convert the string to a character array
            Array.Reverse(charArray);  // Reverse the character array
            return new string(charArray);  // Convert the reversed array back to a string
        }

        public string ReverseAStringLogic(string input)
        {
            char[] reversedArray = new char[input.Length];

            // Loop through the input string in reverse order and populate the reversedArray
            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[i] = input[input.Length - 1 - i];
            }

            // Convert the reversed character array back to a string
            return new string(reversedArray);
        }

        public string ReverseAStringWithoutLoop(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }

            return ReverseAStringWithoutLoop(input.Substring(1)) + input[0];
        }

        public string ReverseASentence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            string[] reversedWords = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(reversedWords);
            return string.Join(" ", reversedWords);
        }

        public string ReverseASentenceWithLoop(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            string[] words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int left = 0;
            int right = words.Length - 1;

            while (left < right)
            {
                // Swap words
                string temp = words[left];
                words[left] = words[right];
                words[right] = temp;

                left++;
                right--;
            }

            return string.Join(" ", words);

        }

        public string ReverseEachWordLogic(string input)
        {
            if(input == null || input.Length == 0)
            {
                Console.WriteLine("Enter a valid string to reverse");
                //return input;
            }
            string[] words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> reversedWords = new();

            StringBuilder sb = new StringBuilder();
            

            foreach (string word in words)
            {
                for(int i = word.Length-1; i>=0 ; i--)
                {
                    sb.Append(word[i]);
                    
                }
                
                reversedWords.Add(sb.ToString());
                sb.Clear();

            }

            // Convert the reversed character array back to a string
            return string.Join(" ", reversedWords);
        }
    }
}
