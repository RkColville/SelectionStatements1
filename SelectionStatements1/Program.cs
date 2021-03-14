using System;

namespace SelectionStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice exercise
            //int day = 0;
            //switch (day)
            //{
            //    case 0:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
         
            var favNumber = 7;
            Console.WriteLine("Hello, guess my favorite number!");
            string input = Console.ReadLine();
            var userGuess = int.Parse(input);

            if (userGuess < 7)
            {
                Console.WriteLine("Too low, try again!");
            }
            else if (userGuess > 7)
            {
                Console.WriteLine("Too high, try again!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


        }

    }
}       
