using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Algoritms___factorial_recursion
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
                if (index < 0)
                {
                    Console.WriteLine($"{errorMessage}");
                }
                else 
                {
                    int result = ResultValue(index);
                    Console.WriteLine($"{Environment.NewLine}{result}");
                }
            }
        }
        //method for factorial
        static int ResultValue (int index)
        {
            if (index == 0)
            {
                return 1;
            }
            else return index * resultValue(index - 1);
        }
    }
}
