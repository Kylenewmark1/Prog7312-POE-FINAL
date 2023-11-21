using DeweyDecimalLibrary.Other;

namespace DeweyDecimalLibrary.Logic
{
    public static class ScoreSystem
    {
        // Calculate the score for Game 1
        public static int CalculateScore(int timeLeft)
        {
            // Initialize properties for Game 1
            int timeCompleted = 30 - timeLeft;
            int score = 0;

            // Logic structure for the points system
            if (timeCompleted < 10)
            {
                score = 100;
            }
            else if (timeCompleted >= 10 && timeCompleted <= 15)
            {
                score = 75;
            }
            else if (timeCompleted >= 16 && timeCompleted <= 21)
            {
                score = 50;
            }
            else if (timeCompleted >= 22 && timeCompleted <= 25)
            {
                score = 25;
            }
            else if (timeCompleted > 26)
            {
                score = 10;
            }

            return score;
        }

        // Calculate the score for Game 2
        public static int CalculateScore(int timeLeft, int count)
        {
            // Calculate the score based on count, bonus points, and time left
            return ((count / 4) * 100) + Global.BonusPoints + timeLeft;
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
