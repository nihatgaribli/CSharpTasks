using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._1
{
    internal class Months
    {
        public int Number {  get; set; }

        public Months(int number) 
        {
            Number = number;
        }

        public string monthsName()
        {
            switch (Number)
            {
                case 12:
                case 1:
                case 2:
                    return "Qish";
                case 3:
                case 4:
                case 5:
                    return "Yaz";
                case 6:
                case 7:
                case 8:
                    return "Yay";
                case 9:
                case 10:
                case 11:
                    return "Payiz";
                default:
                    return "Daxil etdiyiniz eded bir aya aid deyil";
            }
        }
    }
}
