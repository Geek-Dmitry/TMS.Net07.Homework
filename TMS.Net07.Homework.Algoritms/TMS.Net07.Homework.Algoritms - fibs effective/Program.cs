using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Algoritms___fibs_effective
{
    class Program
    {
        static void Main(string[] args)
        {
            const string errorMessage = "Please, check your input";
            while (true)
            {
                int index;
                string input = Console.ReadLine();
                //check input value
                if (input == "exit")
                {
                    return;
                }
                bool isOk = Int32.TryParse(input, out index);
                if (!isOk)
                {
                    Console.WriteLine($"{errorMessage}");
                }
                else if (index < 0)
                {
                    Console.WriteLine($"{errorMessage}");
                }
                else
                {
                    int[] intermediate = new int [index + 1];
                    int result = resultValue(index, intermediate);
                    Console.WriteLine($"{Environment.NewLine}{result}");
                }
            }
        }
        //method for fibonacci
        static int resultValue (int index, int [] intermediate)
        {
            if (index == 0 || index == 1)
            {
                intermediate[index] = index;
                return index;
            }

            if (intermediate[index] == 0) 
            {
                intermediate [index] = resultValue(index - 1, intermediate) + resultValue(index - 2, intermediate);
            }
            return intermediate[index];
        }
    }
}
