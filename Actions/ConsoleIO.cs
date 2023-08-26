using RockPaperScissors.DTOs;
using System.Security.Cryptography.X509Certificates;

namespace RockPaperScissors.Actions
{
    internal static class ConsoleIO
    {

        public static void WriteStatistics(GameStatistics _gameStats)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Game Summary:");
            Console.WriteLine($"Wins: {_gameStats.Wins}");
            Console.WriteLine($"Losses: {_gameStats.Losses}");
            Console.WriteLine($"Ties: {_gameStats.Ties}");
        }
        public static void WriteGoodByeMessage()
        {
            Console.WriteLine("Thank you for playing Rock, Paper, Scissors!");
        }
        public static string ConvertMoveToString(int moveIndex)
        {
            string[] moves = new string[] { "Rock", "Paper", "Scissors" };
            string move = moves[moveIndex - 1];
            return move;
        }
        public static string ConvertMoveToString(char moveChar)
        {
            Dictionary<string, string> movesDictionary = new Dictionary<string, string>
            {
                {"r", "Rock" },
                {"p", "Paper" },
                {"s", "Scissors" }
            };
            string moveKey = moveChar.ToString();
            if (movesDictionary.TryGetValue(moveKey, out string move))
            {
                return move;
            }
            else
            {
                Console.WriteLine($"Invalide move character: {moveChar}.");
                return "no valid move";
            }
        }
        public static void WriteWelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        }
        public static int GetPlayerMove(string prompt)
        {
            char input;
            int move;
            do
            {
                Console.Write(prompt);
                input = Console.ReadKey().KeyChar;
                
                switch (input)
                {
                    case 'r':
                    case 'R':
                        move = 1;
                        return move;
                    case 'p':
                    case 'P':
                        move = 2;
                        return move;
                    case 's':
                    case 'S':
                        move = 3;
                        return move;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid input! Answer with R, P or S.");

            } while (true);

        }

        public static bool GetPlayAgain(string prompt)
        {
            char input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadKey().KeyChar;
                
                switch (input)
                {
                    case 'y':
                    case 'Y':
                        return true;
                    case 'n':
                    case 'N':

                        return false;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid input! Answer with Y or N.");

            } while (true);

        }

        public static void WriteResult(int playerMoveKey, int computerMoveKey)
        {
            string playerMove = ConvertMoveToString(playerMoveKey);
            string computerMove = ConvertMoveToString(computerMoveKey);
            Console.WriteLine();
            Console.WriteLine($"You picked {playerMove} and the Computer picked {computerMove}");
        }

        public static void WriteWinner(string prompt)
        {
            Console.WriteLine(prompt);
        }
        public static int GetComputerMove(Random rnd)
        {
            int move = rnd.Next(1, 4);
            return move;
        }
    }
}
