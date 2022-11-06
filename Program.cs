namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Cli game");

            Play();

            Console.WriteLine("Thanks For Playing.");
        }

        static void Play()
        {
            string userInput;
            string Computer;
            bool keepPlaying = true;
            Random myRandomObject = new Random();

            try
            {
                while (keepPlaying)
                {

                    Computer = "";
                    userInput = "";

                    while (userInput != "ROCK" && userInput != "PAPER" && userInput != "SCISSORS")
                    {
                        Console.WriteLine("Please enter your choice. ROCK, PAPER or SCISSORS");
                        userInput = Console.ReadLine();
                        userInput = userInput.ToUpper();
                    }

                    var randomNum = myRandomObject.Next(1, 4);
                    switch (randomNum)
                    {
                        case 1:
                            Computer = "ROCK";
                            break;
                        case 2:
                            Computer = "PAPER";
                            break;
                        case 3:
                            Computer = "SCISSORS";
                            break;
                    }

                    Console.WriteLine("User : " + userInput);
                    Console.WriteLine("Computer : " + Computer);

                    switch (userInput)
                    {
                        case "ROCK":
                            if (Computer == "ROCK")
                            {
                                Console.WriteLine("Its Tie!");
                            }
                            else if (Computer == "PAPER")
                            {
                                Console.WriteLine("You Lost!!");
                            }
                            else
                            {
                                Console.WriteLine("You Won!!");
                            }
                            break;
                        case "PAPER":
                            if (Computer == "ROCK")
                            {
                                Console.WriteLine("You Won!!");
                            }
                            else if (Computer == "PAPER")
                            {
                                Console.WriteLine("Its a Tie!");
                            }
                            else
                            {
                                Console.WriteLine("You Lost!!");
                            }
                            break;
                        case "SCISSORS":
                            if (Computer == "ROCK")
                            {
                                Console.WriteLine("You Lost!!");
                            }
                            else if (Computer == "PAPER")
                            {
                                Console.WriteLine("You Won!!");
                            }
                            else
                            {
                                Console.WriteLine("Its a Tie!");
                            }
                            break;
                    }

                    Console.WriteLine("Would you like to play again ? ( Y or YES for play again )");
                    var answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (answer == "Y" || answer == "YES")
                    {
                        keepPlaying = true;
                    }
                    else
                    {
                        keepPlaying = false;
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}