using DeweyDecimalLibrary;
using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_System
{
    public partial class IdentifyingAreas : Form
    {
        static int count = 0;

        // Instantiate object
        MatchingCallNosDescription matching = new MatchingCallNosDescription();

        // Instantiate timer object
        CountDownTimer timer = new CountDownTimer();

        // Flag bool for testing if the game has started
        bool gameBegin = false;

        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        // Event handler for the "Check Answer" button
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // Declare variables
            string callNumber = null, description = null;

            // Check if the user has selected an item from the listbox
            if (lstboxCallNo.SelectedItem != null)
            {
                // Get the user input from the listbox
                callNumber = lstboxCallNo.SelectedItem.ToString();

                if (lstboxDescription.SelectedItem != null)
                {
                    // Get the user input from the listbox
                    description = lstboxDescription.SelectedItem.ToString();

                    // Check if the user has selected an item from the listbox
                    if (matching.CheckAnswer(callNumber, description, Global.isAltGame))
                    {
                        // If the matching pair is correct, remove it from the listbox
                        lstboxCallNo.Items.RemoveAt(lstboxCallNo.SelectedIndex);
                        lstboxDescription.Items.RemoveAt(lstboxDescription.SelectedIndex);

                        // Increment count
                        count++;

                        // Check if the game has been completed
                        if (matching.isGameFinished(lstboxCallNo.Items.Count))
                        {
                            updatedScore();
                        }
                    }
                    else
                    {
                        ClearSelectedItems();
                        MessageBox.Show("Whoops! Incorrect match. Have another go!\n" +
                            "-----------------------------------------------------\n" +
                            "Press 'Enter' on your keyboard or select 'OK' to continue", "Invalid Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a description", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a call number", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the MouseDown event of lstboxCallNo
        private void lstboxCallNo_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }

            // Check if the game has been completed
            if (matching.isGameFinished(lstboxCallNo.Items.Count))
            {
                updatedScore();
            }
        }

        // Event handler for the MouseDown event of lstboxDescription
        private void lstboxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }

            // Check if the game has been completed
            if (matching.isGameFinished(lstboxCallNo.Items.Count))
            {
                updatedScore();
            }
        }

        // Event handler for the Form's Load event
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            // Clear lists and list views
            Global.lstDescription.Clear();
            Global.lstCallNos.Clear();
            Global.dictCallNoDescription.Clear();
            lstboxCallNo.Items.Clear();
            lstboxDescription.Items.Clear();

            // Check if the JSON file exists; if not, create it
            if (!JsonFileUtility.CallNumFileExists())
            {
                JsonFileUtility.CreateCallNumFile();
            }

            // Get list values
            Global.lstDescription = matching.GetDescription();
            Global.lstCallNos = matching.GetCallNos();

            // Alternate displays
            Alternate(Global.countAlt);

            // Initialize game start to false
            gameBegin = false;

            // Initialize game mode
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            // Initialize counter
            count = 0;

            // Display game instructions
            MessageBox.Show("When the call numbers (left) and the descriptions (right) load, follow these steps:\n" +
                "----------------------------------------------------------\n\n" +
                "1. Select one call number and one description from each listbox.\n" +
                "2. Click 'Check Answer' to verify your selection.\n" +
                "3. If the answer is correct, the items will be removed from the listbox.\n" +
                "4. Continue guessing and removing pairs before time runs out.\n\n" +
                "-----------------------------------------------------\n" +
                "Good luck with the Identify Areas task!", "Identify Areas - Instructions");
        }

        // Method to unselect the item selected by the user in the listbox
        private void ClearSelectedItems()
        {
            lstboxCallNo.ClearSelected();
            lstboxDescription.ClearSelected();
        }

        // Method to alternate list views based on count
        private void Alternate(int count)
        {
            // Instantiate a random object
            Random rnd = new Random();

            int check = count % 2;

            if (check == 0)
            {
                Global.isAltGame = true;

                // Populate list view with call numbers
                Global.lstCallNos.ToList().ForEach(x => lstboxCallNo.Items.Add(x));

                // Shuffle description list
                Global.lstDescription.ToList().OrderBy(x => rnd.Next()).ToList().ForEach(x => lstboxDescription.Items.Add(x.Value));
            }
            else
            {
                Global.isAltGame = false;

                // Populate list view with descriptions
                Global.lstCallNos.ToList().ForEach(x => lstboxDescription.Items.Add(x));

                // Shuffle call number list
                Global.lstDescription.ToList().OrderBy(x => rnd.Next()).ToList().ForEach(x => lstboxCallNo.Items.Add(x.Value));
            }
        }

        // Method to start the timer
        public void StartTimer()
        {
            // Set time dependent on difficulty
            timer.SetTime(0, Global.CountdownTime); // 30s
            timer.Start();

            // Update label text
            timer.TimeChanged += () => lblTimer.Text = timer.TimeLeftMsStr;

            // Timer step (default is 1 second)
            timer.StepMs = 77;
        }

        // Method to update the score and navigate to the score and details form
        private void updatedScore()
        {
            // Stop the timer
            timer.Pause();

            // Save the score
            Global.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds), count);

            Global.UpdateUserControl = true;

            // Show user details and score
            ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Congratulations! You Solved Correctly well done!!!");
            this.Hide();
            scoreAndDetails.Show();
        }

        // Event handler for the Form's FormClosed event
        private void IdentifyingAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form navigation
            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }

        // Event handler for the MouseHover event
        private void IdentifyingAreas_MouseHover(object sender, EventArgs e)
        {
            // Check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0)
            {
                // Incorrect sorting
                Global.BonusPoints = 0;
                Global.Points = ScoreSystem.CalculateScore(0, count);

                Global.UpdateUserControl = true;

                // Show user details and score
                ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly. Please try again. ");
                this.Hide();
                scoreAndDetails.Show();
            }
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
