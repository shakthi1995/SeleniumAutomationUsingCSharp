using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CountInteger
    {
        public int FindTheIntegerDigitCount(int num)
        {
            int count = 0;

            while(num > 0)
            {
                num = num / 10;
                count++;
            }

            return count;

        }

        public int FindTheIntegerDigitCountWithoutLoop(int num)
        {
            string numberStr = Convert.ToString(num);
            return numberStr.Length;

        }
    }
}
