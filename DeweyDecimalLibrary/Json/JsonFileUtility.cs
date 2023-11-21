using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Tree_Structure;
using System.Text.Json;

namespace DeweyDecimalLibrary.Json
{
    public class JsonFileUtility
    {
        // Define file names for different JSON files
        public static string SortingCallNosFile = "SortingCallNumbersLeaderboard.json";
        public static string IdentifyingAreasCallNo = "IdentifyingAreasCallNo.json";
        public static string IdentifyingAreasFile = "IdentifyingAreasLeaderboard.json";
        public static string TreeGameDataFile = "Tree.json";
        public static string TreeHighScoreFile = "FindingCallNumbersLeaderboard.json";

        #region Sorting Call Numbers
        // Creates the JSON file for sorting call numbers
        public static void CreateJsonFile(string filename)
        {
            // Initialize a random object
            Random rnd = new Random();


            // initialised list with random pre populated data
            List<ModelHighScore> initializeHighScore = new List<ModelHighScore>()
            {
                new ModelHighScore( "Troy Newmark",     rnd.Next(1, 101)),
                new ModelHighScore( "Kyle Newmark",     rnd.Next(1, 101)),
                new ModelHighScore( "Taine Newmark",   rnd.Next(1, 101)),
                new ModelHighScore( "Toni Kirsten",     rnd.Next(1, 101)),
                new ModelHighScore( "Rod Kirsten",    rnd.Next(1, 101)),
                new ModelHighScore( "Aiden State",    rnd.Next(1, 101)),
                new ModelHighScore( "Josh Kruger",  rnd.Next(1, 101)),
                new ModelHighScore( "Tyler Page",     rnd.Next(1, 101)),
            };

            // Serialize and write the initial data to the JSON file
            File.WriteAllText(filename, JsonSerializer.Serialize(initializeHighScore));
        }

        // Appends new scores to an existing JSON file for sorting call numbers
        public static void AppendScores(ModelHighScore highScore, string filename)
        {
            List<ModelHighScore> lstHighScore = GetAllScores(filename);

            lstHighScore.Add(highScore);

            // Serialize and write the updated data to the JSON file
            File.WriteAllText(filename, JsonSerializer.Serialize(lstHighScore));
        }

        // Retrieves all existing scores from a JSON file for sorting call numbers
        public static List<ModelHighScore> GetAllScores(string filename)
        {
            // Deserialize the JSON content into a list of high scores
            return JsonSerializer.Deserialize<List<ModelHighScore>>(File.ReadAllText(filename));
        }

        // Check if the JSON file for identifying areas call numbers exists
        public static bool FileExists(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Identifying Areas
        // check if the json file exists
        public static bool CallNumFileExists()
        {
            if (File.Exists(IdentifyingAreasCallNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Creates the JSON file for identifying areas call numbers
        public static void CreateCallNumFile()
        {
            // Initialize a dictionary to map call numbers to their descriptions
            Dictionary<string, string> callNums = new Dictionary<string, string>();

            // Populate the dictionary with call numbers and descriptions
            callNums.Add("000", "General Knowledge");
            callNums.Add("100", "Philosophy & Psychology");
            callNums.Add("200", "Religion");
            callNums.Add("300", "Social Sciences");
            callNums.Add("400", "Language");
            callNums.Add("500", "Natural Sciences & Mathematics");
            callNums.Add("600", "Technology (Applied Sciences)");
            callNums.Add("700", "The Arts");
            callNums.Add("800", "Literature & Rhetoric");
            callNums.Add("900", "Geography & History");

            File.WriteAllText(IdentifyingAreasCallNo, JsonSerializer.Serialize(callNums));
        }

        // Retrieve the JSON file content into a dictionary
        public static Dictionary<string, string> GetKeyValuePairs()
        {
            // Deserialize the JSON content into a dictionary
            return JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(IdentifyingAreasCallNo));
        }
        #endregion

        #region Finding Call Numbers

        // Check if the data file for tree-based game exists
        public static bool TreeGameDataExists()
        {
            if (File.Exists(TreeHighScoreFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Check if the score file for tree-based game exists
        public static bool TreeGameScoresExists()
        {
            if (File.Exists(TreeHighScoreFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a score file for the tree-based game
        public static void CreateTreeScoreFile()
        {


            Random rnd = new Random();

            // Initialize a list with random pre-populated data
            List<ModelHighScore> initializeHighScore = new List<ModelHighScore>()
            {
                new ModelHighScore( "Troy Newmark",     rnd.Next(1, 101)),
                new ModelHighScore( "Kyle Newmark",     rnd.Next(1, 101)),
                new ModelHighScore( "Taine Newmark",   rnd.Next(1, 101)),
                new ModelHighScore( "Toni Kirsten",     rnd.Next(1, 101)),
                new ModelHighScore( "Rod Kirsten",    rnd.Next(1, 101)),
                new ModelHighScore( "Aiden State",    rnd.Next(1, 101)),
                new ModelHighScore( "Josh Kruger",  rnd.Next(1, 101)),
                new ModelHighScore( "Tyler Page",     rnd.Next(1, 101)),
            };

            // Serialize the list to JSON
            string highScoreContent = JsonSerializer.Serialize(initializeHighScore);

            // Write the JSON content to the score file

            using (StreamWriter sw = File.CreateText(TreeHighScoreFile))
            {
                sw.WriteLine(highScoreContent);
            }
        }

        public static void CreateTreeDataFile()
        {
            //gets a tree from the generator file
            Tree<DeweyPair> tree = MakeTree.GrowATree();

            //well, this file cant be a one liner, for the sake of my sanity
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            //make json string
            string treeJSON = JsonSerializer.Serialize(tree, options);

            //writes tree to file
            using (StreamWriter sw = File.CreateText(TreeGameDataFile))
            {
                sw.WriteLine(treeJSON);
            }
        }

        public static Tree<DeweyPair> GetTree()
        {
            return JsonSerializer.Deserialize<Tree<DeweyPair>>(File.ReadAllText(TreeGameDataFile));
        }

        //adds a new highscore to the score file
        public static void AddTreeScore(ModelHighScore newScore)
        {
            List<ModelHighScore> highScores = GetTreeScores();

            highScores.Add(newScore);

            string scoreList = JsonSerializer.Serialize(highScores);

            File.WriteAllText(TreeHighScoreFile, scoreList);
        }

        //gets the list of highscores
        public static List<ModelHighScore> GetTreeScores()
        {
            return JsonSerializer.Deserialize<List<ModelHighScore>>(File.ReadAllText(TreeHighScoreFile));
        }
        #endregion
    }
}
   
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
