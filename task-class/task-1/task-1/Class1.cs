using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_class1
{
    internal class InputAnalyzer
    {
        public string Input { get; set; }

        public InputAnalyzer(string input)
        {
            Input = input;
        }

        public void Analyze()
        {
            if (int.TryParse(Input, out int id))
            {
                Console.WriteLine($"{id} ededi tam ededdir");
            }
            else if (double.TryParse(Input, out double d))
            {
                Console.WriteLine($"{d} ededi heqiqi ededdir");
            }
            else
            {
                Console.WriteLine($"{Input} stringdir");
            }
        }
    }
}
