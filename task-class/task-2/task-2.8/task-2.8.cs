using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._8
{
    internal class Convertor
    {
        public string Number { get; set; }

        public Convertor(string number)
        {
            Number = number;
        }

        public void Convert() 
        {
            if(int.TryParse(Number, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Melumati tam eded kimi gostermek olmur");
            }
        }

    }
}
