﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._2
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

        public void OutputReverseArray()
        {
            Console.Write($"\n Array[{Array.Length}] = [");
            for (int i = Array.Length - 1 ; i > 0 ; i--)
            {
                Console.Write($"{Array[i]}, ");
            }
            Console.Write($"{Array[0]}]");
        }
    }
}