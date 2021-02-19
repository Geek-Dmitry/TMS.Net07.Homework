using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculation___middle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Salata Dmitry - TMS.Net07.Homework3.Middle level.";
            double inputNum1, inputNum2, output;
            bool checkInput1IsOk, checkInput2IsOk, checkSignIsOk;
            char sign;

            while (true) 
            {
                //Check input. If input not a number cycle for use.
                Console.WriteLine("Please, enter first number");
                checkInput1IsOk = Double.TryParse(Console.ReadLine(), out inputNum1) == true;

                for (; !checkInput1IsOk; checkInput1IsOk = Double.TryParse(Console.ReadLine(), out inputNum1)) 
                {
                    Console.WriteLine("Please, enter only a number value.");
                }
                //Check input. If input not a number, cycle for use.
                Console.WriteLine("Please, enter second number");
                checkInput2IsOk = Double.TryParse(Console.ReadLine(), out inputNum2) == true;

                for (; !checkInput2IsOk; checkInput2IsOk = Double.TryParse(Console.ReadLine(), out inputNum2))
                {
                    Console.WriteLine("Please, enter only a number value.");
                }
                //Check input. If input not a char, cycle for use.
                Console.WriteLine("Please, enter operation in format +, -, /, *, %.");
                checkSignIsOk = Char.TryParse(Console.ReadLine(), out sign) == true;

                for (; !checkSignIsOk; checkSignIsOk = Char.TryParse(Console.ReadLine(), out sign))
                {
                    if (sign.Equals('+') || sign.Equals('-') || sign.Equals('/') || sign.Equals('*') || sign.Equals('%'))
                    {
                        switch (sign)
                        {
                            case '+':
                                output = inputNum1 + inputNum2;
                                Console.WriteLine($"{inputNum1} {sign} {inputNum2} = {output}");
                                break;

                            case '-':
                                output = inputNum1 - inputNum2;
                                Console.WriteLine($"{inputNum1} {sign} {inputNum2} = {output}");
                                break;

                            case '/':
                                output = inputNum1 / inputNum2;
                                Console.WriteLine($"{inputNum1} {sign} {inputNum2} = {output}");
                                break;

                            case '*':
                                output = inputNum1 * inputNum2;
                                Console.WriteLine($"{inputNum1} {sign} {inputNum2} = {output}");
                                break;

                            case '%':
                                output = inputNum1 % inputNum2;
                                Console.WriteLine($"{inputNum1} {sign} {inputNum2} = {output}");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Check your enter. Use operation in format +, -, /, *, %");
                    }
                }
                Console.WriteLine($"{inputNum1}{inputNum2}");
            }
        }
    }
}
