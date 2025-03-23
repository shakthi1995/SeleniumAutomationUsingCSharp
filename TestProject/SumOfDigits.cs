using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class SumOfDigits
    {
        public int FindSumOfDigits(int num)
        {
            int sum = 0, rem;
            while(num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            return sum;
        }
    }
}
