using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._3
{
    internal class oddNumber
    {
        public string Print()
        {
            string str = "";
            for (int i = 1; i < 100; i+=2)
            {
                str += i+" " ;
            }
            return str;
        }

    }
}
