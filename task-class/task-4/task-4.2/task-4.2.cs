using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._2
{
    internal class Sum
    {
        public int Number {  get; set; }

        public Sum(int number) 
        {
            Number = number;
        }

        public int sumDigits()
        {
            int sum = 0;
            do
            {
                int digit = Number % 10;
                sum += digit;
                Number /= 10;
            }
            while (Number != 0);

            return sum;
        }
    }
}
