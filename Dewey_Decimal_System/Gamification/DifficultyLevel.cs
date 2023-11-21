using Dewey_Decimal_System.Games;
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
    public partial class frmDifficultyLevel : Form
    {
        public frmDifficultyLevel()
        {
            InitializeComponent();
        }

        private void DifficultyLevel_Load(object sender, EventArgs e)
        {
        }
        private void frmDifficultyLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Navigate back to the home screen
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        #region Select Difficulty
        private void btnEasy_Click(object sender, EventArgs e)
        {
            // Assign time and bonus points for Easy mode
            Global.CountdownTime = 60;
            Global.BonusPoints = 0;

            NavigateToGame();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            // Assign time and bonus points for Medium mode
            Global.CountdownTime = 45;
            Global.BonusPoints = 25;

            NavigateToGame();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            // Assign time and bonus points for Hard mode
            Global.CountdownTime = 30;
            Global.BonusPoints = 50;

            NavigateToGame();
        }
        #endregion

        #region Game Navigation

        public void NavigateToGame()
        {
            if (Global.Game1)
            {
                // Navigate to Game 1 (Sorting Call Numbers)
                frmSortingCallNumbers sortingCallNumbers = new frmSortingCallNumbers();
                this.Hide();
                try
                {
                    sortingCallNumbers.ShowDialog();
                }
                catch (System.NullReferenceException) { throw; }
            }
            else if (Global.Game2)
            {
                // Navigate to Game 2 (Identifying Areas)
                IdentifyingAreas identifyingAreas = new IdentifyingAreas();
                this.Hide();
                identifyingAreas.ShowDialog();

            }
            else if (Global.Game3)
            {
                // Game 3

                FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
                this.Hide();
                findingCallNumbers.ShowDialog();
            }
        }

    }
        #endregion

    }

//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
