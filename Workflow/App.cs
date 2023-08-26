using RockPaperScissors.Actions;
using RockPaperScissors.DTOs;

namespace RockPaperScissors.Workflow
{
    public static class App
    {

        public static void Run()
        {
            Random rnd = new Random();
            GameStatistics _gameStats = new GameStatistics();
            GameHandler _gameHandler = new GameHandler();
            bool _keepPlaying;
            int _playerMove;
            int _computerMove;
            _gameStats.NewGame();
            ConsoleIO.WriteWelcomeMessage();
            do
            {
                _keepPlaying = true;
                _playerMove = ConsoleIO.GetPlayerMove("\nPlease enter your choice (R)ock, (P)aper, (S)cissors): ");
                _computerMove = ConsoleIO.GetComputerMove(rnd);
                _gameHandler.CalculateWinner(_gameStats, _playerMove, _computerMove);
                _keepPlaying = ConsoleIO.GetPlayAgain("\nDo you want to play again? (Y/N): ");

            } while (_keepPlaying);
            ConsoleIO.WriteStatistics(_gameStats);
            ConsoleIO.WriteGoodByeMessage();
        }
    }
}
