using System;

class Hard
{
    static void Main()
    {

        int number;
        string enter; 
        const string txtMessage = "You are enter";
        bool inputIsNumber;

        Console.Title = "Dmitry Salata - TMS.Net07.Homework - Hard";
        Console.WriteLine("Please, enter any number!\n Enter number 0 for closing program");

        enter = Console.ReadLine();
        inputIsNumber = Int32.TryParse(enter, out number);

        do
        {
            enter = Console.ReadLine();
            inputIsNumber = Int32.TryParse(enter, out number);

            if (inputIsNumber == true)
            {
                if (number == 0)
                    Console.WriteLine($"{txtMessage} number {number}! {Environment.NewLine} Entering number 0 is close this program.{Environment.NewLine} Good bye!");
                else
                {
                    Console.WriteLine($"{txtMessage} number {number}!{Environment.NewLine} Please, enter any other number.");
                }
            }
            else
            {
                Console.WriteLine($"{txtMessage} {enter} and it is not a number!{Environment.NewLine} Please, enter only a numbers.");
                number = 1;
            }
        }
        while (number != 0);
    }
}