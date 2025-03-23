using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Factorial
    {
        public int FactorialNumber(int num)
        {
            int fact = 1;
            for(int i = 1; i<=num; i++)
            {
                fact = fact * i;
            }

            return fact;
            
        }
    }
}
