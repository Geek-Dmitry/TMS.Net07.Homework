using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Algoritms___factorial_cycle
{
    class Program
    {
        const string errorMessage = "Please, check your input";
        static void Main(string[] args)
        {
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
                if(!isOk) 
                {
                    Console.WriteLine($"{errorMessage}");
                }
                if (index == 0)
                {
                    Console.WriteLine("1");
                }
                int result = resultValue (index);
                Console.WriteLine($"{Environment.NewLine}{result}");
            }
        }
        //method for factorial
        static int resultValue (int index)
        {
            int i = 1;
            int result;
            int interValue = 1;
            do
            {
                result = interValue * i;
                interValue = result;
                i++;
            }
            while (i != index + 1);
            return result; 
        }
    }
}
