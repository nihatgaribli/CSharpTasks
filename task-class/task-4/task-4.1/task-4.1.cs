using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    internal class Factorial
    {

        public int Number {  get; set; }
        public Factorial(int number) 
        {
            Number = number;
        }

        public int fac()
        {
            int S = 1;
            while(Number > 0) 
            {
                S *= Number;
                Number--;
            }
            return S;
        }
    }
}
