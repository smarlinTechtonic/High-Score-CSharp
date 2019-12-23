using System;

// Create an application with a score, highscore and a highscorePlayer.
// Create a method which has two parameters, one for the score and one for the playerName.
// When ever that method is called, it should be checked if the score of the player is higher than the highscore,
// if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console,
// if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
// Consider which variables are required globally and which ones locally.

namespace HighScoreCSharp
{
    class MainClass
    {
        static int highscore = 0;
        static string highscorePlayer;

        public static void Main(string[] args)
        {
            int numGames = 0;
            while ( numGames < 10)
            {
                Console.WriteLine("What is your high score?");
                int currScore = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your player name?");
                string currPlayer = Console.ReadLine();
                recordHighScore(currScore, currPlayer);
                numGames++;
            }
            
        }

        static void recordHighScore(int playerscore, string playerName)
        {
            if (playerscore > highscore)
            {
                highscore = playerscore;
                highscorePlayer = playerName;
                Console.WriteLine("Congrats we have a new highscore");
            }

            else
            {
                Console.WriteLine("Nope that is not a new highscore!");
            }

            Console.WriteLine($"Current high score is {highscore} by {highscorePlayer}");
        }
    }
}
