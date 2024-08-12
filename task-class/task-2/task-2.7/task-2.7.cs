using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._7
{
    internal class Calculator
    {
        public int Number1;
        public int Number2;

        public Calculator(int number1, string number2)
        {
            Number1 = number1;
            Number2 = Convert.ToInt32(number2);
        }

        public int Add()
        {
            return Number1 + Number2;
        }
    }
}
