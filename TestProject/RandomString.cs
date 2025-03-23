using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class RandomString
    {
        public string GenerateRandomString(int size)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i=0; i<size; i++)
            {
                int num = random.Next(chars.Length);
                result.Append(chars[num]);
               
            }

            return result.ToString();
        }
    }
}
