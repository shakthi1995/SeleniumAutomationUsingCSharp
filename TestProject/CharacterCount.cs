using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CharacterCount
    {
        public Dictionary<char, int> CharacterOccurenceCount(string input)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach(var ch in input)
            {
                if (!characterCount.ContainsKey(ch))
                {
                    characterCount.Add(ch, 1);
                }
                else
                {
                    characterCount[ch]++;
                }
            }
            return characterCount;
        }
    }
}
