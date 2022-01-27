using System;

namespace Hilo.game

{
    public class Director
    {
        public static int cardGenerate()
        {
            var random = new Random();
            return random.Next(1,13);
        }
        public void StartGame()
        {
            Player player = new Player(300);
            do
            {
                int card = cardGenerate(); 
                int nextCard = cardGenerate(); 
                Console.WriteLine($"The card is: {card} ");

                // We need to ask the user if they want to guess higher or lower
                Console.Write("Higher or lower? [h/l] ");
                string? playerAnswer = Console.ReadLine();
                // while (playerAnswer?.ToLower() != "h" && playerAnswer?.ToLower() != "l")
                {
                    if(playerAnswer?.ToLower() == "h")
                    {
                        if(nextCard>card)
                        {
                            player.CorrectGuess();
                        }
                        else
                        {
                            player.WrongGuess();
                        }
                    }
                    else if(playerAnswer?.ToLower() == "l")
                    {
                        if(nextCard<card)
                        {
                            player.CorrectGuess();
                        }
                        else
                        {
                            player.WrongGuess();
                        }
                    }
                    // else
                } 
                Console.WriteLine($"The next card is: {nextCard}");
                Console.WriteLine($"Your score is: {player.getScore()}");
                Console.WriteLine(" ");
            }

            while(player.ContinueGame()==true);

            Console.WriteLine("Thanks for Playing.");
            // Console.WriteLine(" ");
            if(player.getScore() <= 0)
            {
                player.GameOver();
            }
        }
    }
}
