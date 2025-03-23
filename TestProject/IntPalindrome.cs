using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class IntPalindrome
    {
        public void CheckPalindromeNumber(int num)
        {

            int rev = 0, rem, temp;
            temp = num;
            while(num > 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }

            if ( temp == rev)
            {
                Console.Write($"{temp} is palindrome");
            }
            else
            {
                Console.Write($"{temp} is not palindrome");
            }
        }
    }
}
