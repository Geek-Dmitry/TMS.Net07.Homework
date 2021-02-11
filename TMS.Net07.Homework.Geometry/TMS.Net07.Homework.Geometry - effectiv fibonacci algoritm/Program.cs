using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Geometry___effectiv_fibonacci_algoritm
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
                int[] result = resultValue(index);
                Console.WriteLine($"{Environment.NewLine}{result[index]}");
            }
        }
        //method for factorial
        static int[] resultValue(int index)
        {
            int[] fibs = new int [index + 1];
            for (int i = 0; i < fibs.Length; i++)
            {
                if (index == 0 || index == 1)
                {
                    fibs[i] = 1;
                }
                else
                {
                    fibs[i] = fibs[i - 1] + fibs[i - 2];
                    return fibs;
                }
            }
            return fibs;
        }
    }
}
