using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class EmptyFile
    {
        public void CreateEmptyFile(string path)
        {
            using (FileStream fs = File.Create(path))
            {
                //Creates a empty file
            }
        }
    }
}
