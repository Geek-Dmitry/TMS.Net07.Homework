using System;

class Hard 
{
    static void Main () 
    {

        int number;
        string enter;

        Console.Title = "Dmitry Salata - TMS.Net07.Homework - Hard";
        Console.WriteLine("Please, enter any number!\n Enter number 0 for closing program");
        do
        {
           enter = Console.ReadLine();

            try
            {
                number = Int32.Parse(enter);

                if (number == 0)
                {
                    Console.WriteLine("You are enter number " + number + "!\n Entering number 0 is close this program.\n Good bye!");
                }
                else
                {
                    Console.WriteLine("You are enter number " + number + "!\n Please, enter any other number.");
                }
            }
            
            catch
            {
                Console.WriteLine("You are enter " + enter + " and it is not a number!\n Please, enter only a numbers.");
            }
        }
        while (enter != "0");
    }
}