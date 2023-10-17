using System;
using System.Dynamic;
using System.Runtime.Remoting.Lifetime;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();

            getUserName();

            
            while (true)
            {


                //Create a random number
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    //User input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print Error message if not a number
                        printColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message if wrong number
                        printColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }

                //Print success message if correct
                printColorMessage(ConsoleColor.Yellow, "You are Correct!!!!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void getAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christian Hall";

            //Change Text color
            Console.ForegroundColor = ConsoleColor.Green;

            //App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void getUserName()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //User input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }

        static void printColorMessage(ConsoleColor color, string message)
        {
            //Change Text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
