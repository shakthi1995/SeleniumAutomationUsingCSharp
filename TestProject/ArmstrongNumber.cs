using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ArmstrongNumber
    {
        public void FindArmstrongNumber(int num)
        {
            int sum = 0, res, temp;
            temp = num;
            while(num > 0)
            {
                res = num % 10;
                num = num / 10;
                sum = sum + (res * res * res);

            }

            if(temp == sum)
            {
                Console.Write($"{temp} is Armstrong Number");
            }
            else
            {
                Console.Write($"{temp} is not Armstrong Number");
            }
        }

    }
}
