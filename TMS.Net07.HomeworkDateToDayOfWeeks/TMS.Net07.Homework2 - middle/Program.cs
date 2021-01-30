using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework2___middle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            DateTime inputDate, maxRange = DateTime.Parse("31.12.2999");

            Console.Title = "Dmitry Salata - TMS.Net07.Homework2 - level not slave, but not master (middle)";
            Console.WriteLine("Please, enter the date in format DD.MM.yyyy or DD/MM/yyyy.");

            input = Console.ReadLine();

            for (;String.Equals(input.ToLower(), "exit") == false; input = Console.ReadLine()) 
            {
               
                if (DateTime.TryParse(input, out inputDate) == true)
                {
                    if (inputDate > maxRange)
                    {
                        Console.WriteLine("\nPlease, enter the date in range from 01.01.0001 to 31.12.2999");
                    }
                    else
                    {
                        Console.WriteLine(inputDate.ToString($"\n{input} - dddd", new System.Globalization.CultureInfo("en-EN")));
                    }
                }
                else
                {
                    Console.WriteLine($"\nYou are enter a {input} and it is not a date or format of date are not acceptable. " +
                        $"\nPlease enter the date in format DD.MM.yyyy or DD/MM/yyyy");
                }
            }
        }
    }
}
