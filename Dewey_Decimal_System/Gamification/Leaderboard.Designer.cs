namespace Dewey_Decimal_System
{
    partial class Leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            lvLeaderboard = new ListView();
            ch_username = new ColumnHeader();
            ch_score = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvLeaderboard
            // 
            lvLeaderboard.Columns.AddRange(new ColumnHeader[] { ch_username, ch_score });
            lvLeaderboard.Location = new Point(138, 136);
            lvLeaderboard.Margin = new Padding(3, 2, 3, 2);
            lvLeaderboard.Name = "lvLeaderboard";
            lvLeaderboard.Size = new Size(424, 186);
            lvLeaderboard.TabIndex = 0;
            lvLeaderboard.UseCompatibleStateImageBehavior = false;
            lvLeaderboard.View = View.Details;
            // 
            // ch_username
            // 
            ch_username.Text = "Username";
            ch_username.Width = 240;
            // 
            // ch_score
            // 
            ch_score.Text = "Score";
            ch_score.Width = 240;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ravie", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(138, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(436, 63);
            label1.TabIndex = 4;
            label1.Text = "Leaderboard";
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(686, 364);
            Controls.Add(label1);
            Controls.Add(lvLeaderboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Leaderboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            FormClosed += frmLeaderboard_FormClosed;
            Load += frmLeaderboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvLeaderboard;
        private ColumnHeader ch_username;
        private ColumnHeader ch_score;
        private Label label1;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
