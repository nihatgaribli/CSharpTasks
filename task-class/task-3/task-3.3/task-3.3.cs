using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._3
{
    internal class Numbers
    {
        public int Number {  get; set; }

        public Numbers(int number) 
        {
            Number = number;
        }

        public string Check()
        {
            if (Number < 0) return "Menfi";
            else if (Number > 0) return "Musbet";
            else return "Sifir";
        }
    }
}
