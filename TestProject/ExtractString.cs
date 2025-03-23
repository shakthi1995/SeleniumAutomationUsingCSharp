using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ExtractString
    {
        public void SegregateStringDigits(string str)
        {
            StringBuilder num = new StringBuilder();
            StringBuilder alpha = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsAsciiDigit(str[i]))
                {
                    num.Append(str[i]);
                }
                else if (char.IsAsciiLetter(str[i]))
                {
                    alpha.Append(str[i]);
                }
                else
                {
                    special.Append(str[i]);
                }
            }

            Console.WriteLine($"{num}");
            Console.WriteLine($"{alpha}");
            Console.WriteLine($"{special}");
        }
    }
}
