using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Converter
    {
        public double ToDouble(float input)
        {
            return input; 
        }

        public decimal ToDecimal(double input) 
        {
            return (decimal)input;
        }

        public float ToFloat(decimal input) 
        {
            return (float)input;
        }

        public int ToInt(string input) 
        {
            int.TryParse(input, out int result);
            return result;
        }

        public byte ToByte(int input) 
        {
            return (byte)input;
        }
    }
}
