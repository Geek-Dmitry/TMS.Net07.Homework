using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework2___slave 
{
    class Program
    {
        enum dayOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            string input;

            Console.Title = "Dmitry Salata - TMS.Net07.Homework2 - level slave";
            Console.WriteLine($"This program translate the days of the week." +
                $"{Environment.NewLine}Just enter name of the day on english." +
                $"{Environment.NewLine}Еnter exit for closing program.");

            for (input = Console.ReadLine().ToLower(); Equals(input, "exit") == false; Console.WriteLine( $"{Environment.NewLine}Please, enter another day of week.{Environment.NewLine} Enter exit for closing program.{Environment.NewLine}"), input = Console.ReadLine().ToLower())
            {
                switch (input)
                {
                    case "monday":
                        Console.WriteLine(dayOfWeek.Понедельник);
                        break;

                    case "tuesday":
                        Console.WriteLine(dayOfWeek.Вторник);
                        break;

                    case "wednesday":
                        Console.WriteLine(dayOfWeek.Среда);
                        break;

                    case "thursday":
                        Console.WriteLine(dayOfWeek.Четверг);
                        break;

                    case "friday":
                        Console.WriteLine(dayOfWeek.Пятница);
                        break;

                    case "saturday":
                        Console.WriteLine(dayOfWeek.Суббота);
                        break;

                    case "sunday":
                        Console.WriteLine(dayOfWeek.Воскресенье);
                        break;

                    default:
                        Console.WriteLine($"{Environment.NewLine}Check your enter.");
                        break;
                }
            }
        }
    }
}