using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Other;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dewey_Decimal_System
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            // Check if the JSON files for game scores exist and create them if not
            if (!JsonFileUtility.FileExists(JsonFileUtility.SortingCallNosFile))
            {
                JsonFileUtility.CreateJsonFile(JsonFileUtility.SortingCallNosFile);
            }

            if (!JsonFileUtility.FileExists(JsonFileUtility.IdentifyingAreasFile))
            {
                JsonFileUtility.CreateJsonFile(JsonFileUtility.IdentifyingAreasFile);
            }

            if (!JsonFileUtility.FileExists(JsonFileUtility.TreeHighScoreFile))
            {
                JsonFileUtility.CreateCallNumFile();
                JsonFileUtility.CreateJsonFile(JsonFileUtility.TreeHighScoreFile);
            }

            // Debugging information (you can remove these lines)
            Console.WriteLine(Global.Game1);
            Console.WriteLine(Global.Game2);
            Console.WriteLine(Global.Game3);

            if (Global.Game1)
            {
                // Load high scores for Game 1 (Sorting Call Numbers)
                List<ModelHighScore> lstModelHighScore = JsonFileUtility.GetAllScores(JsonFileUtility.SortingCallNosFile);

                // Populate the ListView with high scores
                lstModelHighScore
                    .OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                Global.Game1 = false; // Reset the game mode flag
            }
            else if (Global.Game2)
            {
                // Load high scores for Game 2 (Identifying Areas)
                lvLeaderboard.Items.Clear();
                List<ModelHighScore> lstModelHighScore = JsonFileUtility.GetAllScores(JsonFileUtility.IdentifyingAreasFile);

                // Populate the ListView with high scores
                lstModelHighScore
                    .OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                Global.Game2 = false; // Reset the game mode flag
            }
            else if (Global.Game3)
            {
                // Load high scores for Game 3 (Tree High Score)
                lvLeaderboard.Items.Clear();
                List<ModelHighScore> lstModelHighScore = JsonFileUtility.GetAllScores(JsonFileUtility.TreeHighScoreFile);

                // Populate the ListView with high scores
                lstModelHighScore
                    .OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                Global.Game3 = false; // Reset the game mode flag
            }
        }

        private void frmLeaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Navigate back to the home screen
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
