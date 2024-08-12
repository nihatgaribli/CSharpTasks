using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._6
{
    internal class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Calculator(int number1, int number2) 
        {
            Number1 = number1;
            Number2 = number2;
        }

        public void Funcsion()
        {
            if(Number2 != 0)
            {
                Console.WriteLine(Number1 % Number2);
            }
            else
            {
                Console.WriteLine("0-a bolme emeliyyati mumkun deyil");
            }
        }
    }
}
