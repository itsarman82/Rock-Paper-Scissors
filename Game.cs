using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{  
    class Game
    {
        public static int userInput;
        public static int Computer;

        public static void playGame()
        {
            int userAnswer = user(userInput);
            int computerAnswer = computer(Computer);

            resualt(userAnswer, computerAnswer);
        }   
        public static int user(int userInput)
        {
            Console.WriteLine("Please enter your choice.1 for ROCK,2 for PAPER or 3 for SCISSORS");
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static int computer(int computer)
        {
            Random myRandomObject = new Random();
            var randomNum = myRandomObject.Next(1, 4);
            return randomNum;
        }

        public static void resualt(int userAnswer, int computerAnswer)
        {
            switch (userAnswer) 
            {
                case 1:
                    if (computerAnswer == 1)
                    {
                        Console.WriteLine("You played: Rock");
                        Console.WriteLine("Computer played: Rock");
                        Console.WriteLine("its a tie");

                    } else if (computerAnswer == 2) 
                    {
                        Console.WriteLine("You played: Rock");
                        Console.WriteLine("Computer played: paper");
                        Console.WriteLine("You Lost!!");

                    }else if (computerAnswer == 3)
                    {
                        Console.WriteLine("You played: Rock");
                        Console.WriteLine("Computer played: scissors");
                        Console.WriteLine("You Won!!");
                    }
                    break;

                case 2:
                    if (computerAnswer == 1)
                    {
                        Console.WriteLine("You played: paper");
                        Console.WriteLine("Computer played: Rock");
                        Console.WriteLine("You Won!!");

                    }
                    else if (computerAnswer == 2)
                    {
                        Console.WriteLine("You played: paper");
                        Console.WriteLine("Computer played: paper");
                        Console.WriteLine("its a tie");

                    }
                    else if (computerAnswer == 3)
                    {
                        Console.WriteLine("You played: paper");
                        Console.WriteLine("Computer played: scissors");
                        Console.WriteLine("You Lost!!");
                    }
                    break;

                case 3:
                    if (computerAnswer == 1)
                    {
                        Console.WriteLine("You played: scissors");
                        Console.WriteLine("Computer played: Rock");
                        Console.WriteLine("You Lost!!");

                    }
                    else if (computerAnswer == 2)
                    {
                        Console.WriteLine("You played: scissors");
                        Console.WriteLine("Computer played: paper");
                        Console.WriteLine("You Won!!");

                    }
                    else if (computerAnswer == 3)
                    {
                        Console.WriteLine("You played: scissors");
                        Console.WriteLine("Computer played: scissors");
                        Console.WriteLine("its a tie");
                    }
                    break;

            }
        }

    }
}
