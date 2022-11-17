namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this app develpped with .net core v7
            // this app developed in Visual studio 2022 Enterprise
            // warning : this app may not run on your enviroments except build it.

            Console.WriteLine("Welcome to Rock Paper Scissors Cli game");

            bool keepPlaying = true;

            try
            {
                while (keepPlaying)
                {
                    Game.playGame();
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Thanks For Playing.");
        }
    }
}