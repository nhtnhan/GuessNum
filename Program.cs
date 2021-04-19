using System;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // set app vars
            string appName = "Guess Number Game";
            string appVersion = "1.0.0";
            string appAuthor = "Nhan Nguyen";
            bool playStatus = true;

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset font color
            Console.ResetColor();

            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // write out game intro
            Console.WriteLine("Hello {0}, let's play a game!", inputName);

            // start game
            while (playStatus)
            {
                Console.WriteLine("Please give me any random number. Type x to quit");
                // get random number
                string inputMid = Console.ReadLine();

                if (Int32.TryParse(inputMid, out int mid))
                {
                    int start = mid - 5;
                    int end = mid + 5;
                    int trial = 4;
                    int correctAns = new Random().Next(start, end);

                    // explain the rule
                    Console.WriteLine("Thank you! So the rule of the game is really simple. I'm thinking between of a number between {0} and {1}", start,end);
                    Console.WriteLine("You have {0} try to guess the nummber. Type x to quit.", trial);

                    while (trial != 0)
                    {
                        string answer = Console.ReadLine();
                        if (Int32.TryParse(answer, out int ans))
                        {
                            if (ans == correctAns)
                            {
                                Console.WriteLine("That's correct!");
                                break;
                            } else if (ans < start || ans > end)
                            {
                                Console.WriteLine("Wrong answer. Please try again. You have {0} try", trial);
                            } else
                            {
                                trial -= 1;
                                if (trial > 0)
                                {
                                    Console.WriteLine("Wrong answer. Please try again. You have {0} try", trial);
                                } else
                                {
                                    Console.WriteLine("Wrong answer. The correct answer was {0}.", correctAns);
                                }
                                
                            }
                        } else if (answer == "x"){
                            break;
                        } else
                        {
                            Console.WriteLine("Invalid Input. You still have {0} try. Please try again or type x to quit");
                        }
                    }

                } else if (inputMid == "x")
                {
                    playStatus = false;
                    Console.WriteLine("Exiting game...");
                } else
                {
                    Console.WriteLine("Invalid Input. Please give me any random number...");
                }

            }

        }
    }
}
