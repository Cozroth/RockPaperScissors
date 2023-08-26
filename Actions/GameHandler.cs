using RockPaperScissors.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Actions
{
    public class GameHandler
    {
        public void CalculateWinner(GameStatistics gameStats, int playerMove, int computerMove)
        {
            string winner;
            // Rock = 1
            // 1 > 3
            // Paper = 2
            // 2 > 1
            // Scissors = 3
            // 3 > 2

            if (playerMove == computerMove)
            {
                winner = "You tied!";
                gameStats.Ties += 1;
            }
            else if (playerMove == 1)
            {
                if (computerMove == 3)
                {
                    winner = "You win!";
                    gameStats.Wins += 1;
                }
                else
                {
                    winner = "You lost!";
                    gameStats.Losses += 1;
                }
            }
            else if (playerMove == 2)
            {
                if (computerMove == 1)
                {
                    winner = "You win!";
                    gameStats.Wins += 1;
                }
                else
                {
                    winner = "You lost!";
                    gameStats.Losses += 1;
                }
            }
            else
            {
                if (computerMove == 2)
                {
                    winner = "You win!";
                    gameStats.Wins += 1;
                }
                else
                {
                    winner = "You lost!";
                    gameStats.Losses += 1;
                }
            }
            ConsoleIO.WriteResult(playerMove, computerMove);
            ConsoleIO.WriteWinner(winner);
        }
    }
}
