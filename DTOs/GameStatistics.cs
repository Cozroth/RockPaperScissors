namespace RockPaperScissors.DTOs
{
    public class GameStatistics
    {
        private int _wins;
        private int _losses;
        private int _ties;
        public void NewGame()
        {
            _wins = 0;
            _losses = 0;
            _ties = 0;
        }
        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }
        public int Losses
        {
            get { return _losses; }
            set { _losses = value; }
        }

        public int Ties
        {
            get { return _ties; }
            set { _ties = value; }
        }

    }
}
