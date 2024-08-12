using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._3
{
    internal class Arrays
    {
        public int[] Array { get; set; }

        public Arrays(int size)
        {
            Array = new int[size];
        }

        public void InputArray()
        {
            Console.WriteLine("Arrayin elementlerini daxil edin: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double AverageArray()
        {
            int sum = 0;
            foreach (int i in Array)
            {
                sum += i;
            }
            return (double)sum/Array.Length;
        }
    }
}
