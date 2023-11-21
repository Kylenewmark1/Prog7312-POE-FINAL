using System;

namespace DeweyDecimalLibrary.Models
{
    // Define a class for representing high scores
    public class ModelHighScore
    {
        // Properties to store the Username and Score
        public string Username { get; set; }
        public int Score { get; set; }

        // Default constructor
        public ModelHighScore()
        {
            // You can add any additional initialization logic here if needed
        }

        // Parameterized constructor for creating instances with initial values
        public ModelHighScore(string username, int score)
        {
            Username = username;
            Score = score;
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
