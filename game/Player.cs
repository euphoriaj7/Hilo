using System;


namespace Hilo.game
{
    public class Player
    {
        private int score;
        public Player(int score)
        {
            this.score = score;
        }
        public int getScore()
        {
            return score;
        }
        public void CorrectGuess()
        {
            score += 100;
        }
        public void WrongGuess()
        {
            score -= 75;
        }
        public void GameOver()
        {
                    Console.WriteLine("GAME OVER!");
        }
        public bool ContinueGame()
        {
            if(score > 0)
            {
                Console.Write("Play Again? [y/n]: ");
                string? PlayerAnswer = Console.ReadLine();
                if(PlayerAnswer?.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
    }
}