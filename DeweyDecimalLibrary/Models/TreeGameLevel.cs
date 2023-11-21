using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    // Define a class for representing a game level in a Dewey Decimal System game
    public class TreeGameLevel
    {
        // Properties to store game data for a level
        public List<DeweyPairGameModel> AnswerPath { get; set; }
        public List<DeweyPairGameModel> Level1Options { get; set; }
        public List<DeweyPairGameModel> Level2Options { get; set; }
        public List<DeweyPairGameModel> Level3Options { get; set; }
        // Default constructor
        public TreeGameLevel()
        {
            // Initialize the lists for game data
            AnswerPath = new List<DeweyPairGameModel>();
            Level1Options = new List<DeweyPairGameModel>();
            Level2Options = new List<DeweyPairGameModel>();
            Level3Options = new List<DeweyPairGameModel>();
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
