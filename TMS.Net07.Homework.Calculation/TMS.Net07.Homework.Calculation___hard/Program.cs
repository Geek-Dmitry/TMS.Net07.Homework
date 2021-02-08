using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculation___hard
{
    class Program
    {
        const string errorMessage = "Please, check your entered value";
        static void Main(string[] args)
        {
            Console.WriteLine("For close program enter exit");
            while (true)
            {
                Console.Title = "Salata Dmitry - TMS.Net07.Homework3. Hard level.";
                Console.WriteLine(@"Calculator provide next function: +, -, /, *, %, sqr, sqrt, pow.
Enter value in next format: number operation number or operation number");
                string value = Console.ReadLine().Trim().ToLower();
                if (value == "exit")
                {
                    return;
                }
                double[] enterValue = parseEnterValue(value);
                double result;

                if (enterValue == null)
                {
                    Console.WriteLine($"{errorMessage}");
                }
                //summ
                if (value == $"{enterValue[0]}+{enterValue[1]}")
                {
                    result = enterValue[0] + enterValue[1];
                    Console.WriteLine($"{enterValue[0]} + {enterValue[1]} = {result}");
                }
                //substraction
                if (value == $"{enterValue[0]}-{enterValue[1]}")
                {
                    result = enterValue[0] - enterValue[1];
                    Console.WriteLine($"{enterValue[0]} - {enterValue[1]} = {result}");
                }
                //division
                if (value == $"{enterValue[0]}/{enterValue[1]}")
                {
                    try
                    {
                        result = enterValue[0] / enterValue[1];
                        Console.WriteLine($"{enterValue[0]} / {enterValue[1]} = {result}");
                    }
                    catch 
                    {
                        Console.WriteLine($"{errorMessage}");
                    }
                }
                //multiplication
                if (value == $"{enterValue[0]}*{enterValue[1]}")
                {
                    result = enterValue[0] * enterValue[1];
                    Console.WriteLine($"{enterValue[0]} * {enterValue[1]} = {result}");
                }
                //remainder
                if (value == $"{enterValue[0]}%{enterValue[1]}")
                {
                    result = enterValue[0] % enterValue[1];
                    Console.WriteLine($"{enterValue[0]} % {enterValue[1]} = {result}");
                }
                //square
                if (value == $"sqr{enterValue[1]}")
                {
                    result = enterValue[1] * enterValue[1];
                    Console.WriteLine($"sqr{enterValue[1]} = {result}");
                }
                //square root
                if (value == $"sqrt{enterValue[1]}")
                {
                    result = 1;
                    for (double i = 1, check = 1; enterValue[1] - 0.01 > check && check < enterValue[1] + 0.01; i += 0.01)
                    {
                        check = i * i;
                        result = i;
                    }
                    Console.WriteLine($"sqrt{enterValue[1]} = {result}");
                }
                //exponentiation
                if (value == $"{enterValue[0]}pow{enterValue[1]}")
                {
                    double i = 1;
                    double nextValue = enterValue[0];
                    do
                    {
                        result = nextValue * enterValue[0];
                        nextValue = result;
                        i++;
                    }
                    while (i != enterValue[1]);
                    Console.WriteLine($"{enterValue[0]} pow {enterValue[1]} = {result}");
                }
            }
        }
        //method for parsing enter string value in double for calculation;
        static double[] parseEnterValue (string value)
        {
            string[] operationSeparator = { "+", "-", "/", "*", "%", "sqrt", "sqr", "pow" };
            try
            {
                string[] enterValueString = value.Split(operationSeparator, StringSplitOptions.None);
                double[] enterValueDouble = new double[enterValueString.Length];
                for (int i = 0; i < enterValueString.Length; i++)
                {
                    {
                        double.TryParse(enterValueString[i], out enterValueDouble[i]);
                    }
                }
                return enterValueDouble;
            }
            catch
            {
                return null;

            }
           
        }
    }
}
