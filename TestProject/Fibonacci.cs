using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Fibonacci
    {
        public void GenerateFibonacciSeries(int limit)
        {
            int num1 = 0, num2 = 1;
            for(int i = 0; i < limit; i++)
            {
                int num3 = num1 + num2;
                Console.Write(num1 + " ");

                num1 = num2;
                num2 = num3;
            }
        }
    }
}
