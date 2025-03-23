using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class PyramidProgram
    {
        public void PrintPyramid(int levels)
        {
            int space = levels;
            for(int i = 1; i<= space; i += 2)
            {
                PrintRow(i, space);
            }

            for(int i = space-2; i >=1; i -= 2)
            {
                PrintRow(i, space);
            }
            
        }

        public void PrintRow(int count, int space)
        {
            for(int s =0; s< (space-count) * 2; s++)
            {
                Console.Write(" ");
            }
            for(int j=0; j<count; j++)
            {
                Console.Write("*");
                if (j < count - 1) Console.Write("   ");
            }
            Console.WriteLine();
        }
    }
}
