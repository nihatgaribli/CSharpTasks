using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._2
{
    internal class Calculate
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Calculate(int number1, int number2) 
        {
            Number1 = number1;
            Number2 = number2;
        }

        public int Sum()
        {
            return Number1 + Number2;
        }
    }
}
