using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._2
{
    internal class Exam
    {
        public int Result { get; set; }

        public Exam(int result)
        {
            Result = result;
        }

        public string ExamResult()
        {
            if(100 >= Result && Result > 80) 
            {
                return "Great";
            }

            else if(80 >= Result && Result > 60)
            {
                return "Good";
            }

            else if (60 >= Result && Result > 40)
            {
                return "Average";
            }

            else if (40 >= Result && Result >= 0)
            {
                return "Bad";
            }

            else
            {
                return "Bele bir qiymetlendirme yoxdur";
            }
        }
    }
}
