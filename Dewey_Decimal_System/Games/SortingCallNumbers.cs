using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Other;
using System.Reflection.PortableExecutable;

namespace Dewey_Decimal_System
{
    public partial class frmSortingCallNumbers : Form
    {
        // Declaring lists of type string
        List<String> sortedList;
        List<String> shuffleList;
        List<String> userList;

        // Instantiate timer object
        CountDownTimer timer = new CountDownTimer();

        // Properties
        public bool gameBegin { get; set; } = false;

        public frmSortingCallNumbers()
        {
            // Display instructions to the user
            MessageBox.Show(null,
                "SORT IN ASCENDING ORDER (Smallest to Biggest)\n" +
                "----------------------------------------------------------\n\n" +
                "To start the game:\n\n" +
                "1. Click and drag a Call number (e.g., 222.97 JAM)\n" +
                "   to the empty list box on the right.\n\n" +
                "2. The timer will start, and you must continue until\n" +
                "   all numbers have been moved. The game ends then.\n\n" +
                "Remember, you're racing against the timer.\n\n" +
                "-----------------------------------------------------\n" +
                "GOODLUCK!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitializeComponent();
            lstboxRandom.AllowDrop = true;
            lstboxSorted.AllowDrop = true;

            LoadCallNos();
        }

        #region Load Call Numbers
        // Method to populate list box with randomly generated call numbers
        public void LoadCallNos()
        {
            // Clear the component
            lstboxRandom.Items.Clear();

            // Shuffle the list and store to the updated lists
            ReplacingTheBooks r = new ReplacingTheBooks();
            sortedList = r.GenerateCallNos();
            shuffleList = r.ShuffleList(sortedList);

            // Iterate through list and populate the list box
            foreach (var callNo in shuffleList)
            {
                lstboxRandom.Items.Add(callNo);
            }
        }
        #endregion

        #region Drag and Drop
        private void lstboxRandom_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                lstboxSorted.DoDragDrop(lstboxRandom.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please select a call number from the list");
                throw ex;
            }

            if (StartGame())
            {
                StartTimer();
                gameBegin = false;
            }

            if (EndGame())
            {
                // Get the data of the users from the list box
                userList = lstboxSorted.Items.Cast<String>().ToList();

                bool isCorrectAnswer = userList.SequenceEqual(sortedList);

                if (isCorrectAnswer)
                {
                    // Save the score
                    Global.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

                    Global.UpdateUserControl = true;

                    // Show user details and score
                    ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Congratulations! You Solved Correctly 👑 ");
                    this.Hide();
                    scoreAndDetails.Show();
                }
                else
                {
                    // Incorrect sorting
                    Global.Points = 0;
                    Global.BonusPoints = 0;

                    Global.UpdateUserControl = true;

                    // Show user details and score
                    ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly 😢 ");
                    this.Hide();
                    scoreAndDetails.Show();
                }
            }
        }

        private void lstboxSorted_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstboxSorted_DragDrop(object sender, DragEventArgs e)
        {
            lstboxSorted.Items.Add(e.Data.GetData(DataFormats.Text));
            lstboxRandom.Items.Remove(e.Data.GetData(DataFormats.Text));

            // Initialize game mode
            Global.Game1 = true;
            Global.Game2 = false;
            Global.Game3 = false;
        }
        #endregion

        #region Start Game
        public bool StartGame()
        {
            if (lstboxSorted.Items.Count > 0 || lstboxRandom.Items.Count < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Start Timer
        public void StartTimer()
        {
            // Set time dependent on difficulty
            timer.SetTime(0, Global.CountdownTime);

            timer.Start();

            // Update label text
            timer.TimeChanged += () => lblCountdownEdit.Text = timer.TimeLeftMsStr;

            // Timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion

        #region End Game
        public bool EndGame()
        {
            if (lstboxSorted.Items.Count.Equals(10) || lstboxRandom.Items.Count.Equals(0))
            {
                timer.Pause();
                lblCountdownEdit.Text = timer.TimeLeftStr;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void frmSortingCallNumbers_Load(object sender, EventArgs e)
        {
            // Set time on UI
            lblCountdownEdit.Text = Global.CountdownTime.ToString();
        }

        private void frmSortingCallNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Navigate back
            this.Hide();
            frmDifficultyLevel difficultyLevel = new frmDifficultyLevel();
            difficultyLevel.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            // Declare variables
            string selected = null;
            int index = 0;

            // Error handling
            try
            {
                index = lstboxSorted.SelectedIndex;

                // Error handling
                if (lstboxSorted.SelectedItem != null)
                {
                    selected = lstboxSorted.SelectedItem.ToString();

                    // Move the selected item up
                    if (index > 0)
                    {
                        lstboxSorted.Items.RemoveAt(index);
                        lstboxSorted.Items.Insert(index - 1, selected);
                        lstboxSorted.SetSelected(index - 1, true);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to move");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please select an item to move");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            // Declare variables
            string selected = null;
            int index = 0;

            // Error handling
            try
            {
                index = lstboxSorted.SelectedIndex;

                // Error handling
                if (lstboxSorted.SelectedItem != null)
                {
                    selected = lstboxSorted.SelectedItem.ToString();

                    // Move the selected item down
                    if (index < lstboxSorted.Items.Count - 1)
                    {
                        lstboxSorted.Items.RemoveAt(index);
                        lstboxSorted.Items.Insert(index + 1, selected);
                        lstboxSorted.SetSelected(index + 1, true);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to move");
                }
            }
            catch (System.NullReferenceException)
            {
                throw;
            }
        }

        private void frmSortingCallNumbers_MouseHover(object sender, EventArgs e)
        {
            // Check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0 && lstboxRandom.Items.Count > 0)
            {
                // Incorrect sorting
                Global.Points = 0;
                Global.BonusPoints = 0;

                Global.UpdateUserControl = true;

                // Show user details and score
                ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly 😢 ");
                this.Hide();
                scoreAndDetails.Show();
            }
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
