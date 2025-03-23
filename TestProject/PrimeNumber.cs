using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class PrimeNumber
    {
        public bool FindPrimeNumber(int num)
        {
            int count = 0;
            bool flag = false;
            if(num <= 1)
            {
                return flag;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count > 0)
            {
                return flag;
            }
            else
            {
                flag = true;
                return flag;
            }
        }

        public void GetPrimeNumberInRange(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                if (FindPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
