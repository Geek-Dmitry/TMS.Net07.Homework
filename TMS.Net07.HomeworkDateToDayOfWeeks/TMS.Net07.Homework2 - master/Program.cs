using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework2___master
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the date in format DD.MM.YYYY:");
            var date = Console.ReadLine();
            while (String.Equals(date.ToLower(), "exit") == false)
            {
                try
                {
                    string getDayMiddle = DateTime.Parse(date).ToString("check dddd");
                    Console.WriteLine($"{getDayMiddle}");
                    var dotsRemove = Int32.Parse(date.Replace(".", string.Empty));
                    var dayNumber = dotsRemove / 1000000;
                    var monthNumber = dotsRemove / 10000 % 100;
                    var yearNumber = dotsRemove % 10000;
                    int dayOfWeekHard;
                    int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

                    if (monthNumber >= 3)
                    {
                        yearNumber += 1;
                    }

                    dayOfWeekHard = (int)(yearNumber + yearNumber / 4 - yearNumber / 100 + yearNumber / 400 + t[monthNumber - 1] + dayNumber) % 7;


                    switch (dayOfWeekHard)
                    {
                        case 0:
                            Console.WriteLine("Суббота");
                            break;

                        case 1:
                            Console.WriteLine("Воскресенье");
                            break;

                        case 2:
                            Console.WriteLine("Понедельник");
                            break;

                        case 3:
                            Console.WriteLine("Вторник");
                            break;

                        case 4:
                            Console.WriteLine("Среда");
                            break;

                        case 5:
                            Console.WriteLine("Четверг");
                            break;

                        case 6:
                            Console.WriteLine("Пятница");
                            break;
                    }
                    Console.WriteLine($"{Environment.NewLine} Enter new date in format DD.MM.YYYY or exit for close program.");
                    date = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Check your input. Please enter date in format DD.MM.YYYY");
                    date = Console.ReadLine();
                }
            }
        }
    }
}