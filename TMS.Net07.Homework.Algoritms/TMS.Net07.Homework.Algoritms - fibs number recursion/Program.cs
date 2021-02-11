using System;

namespace TMS.Net07.Homework.Algoritms___fibs_number_recursion
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
                int result = resultValue(index);
                Console.WriteLine($"{Environment.NewLine}{result}");
            }
        }
        //method for factorial
        static int resultValue(int index)
        {
            if (index == 1 || index == 2)
            {
                return 1;
            }
            else return resultValue(index - 1) + resultValue(index - 2);
        }
    }
}
