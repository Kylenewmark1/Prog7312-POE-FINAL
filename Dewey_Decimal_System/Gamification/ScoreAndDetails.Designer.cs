namespace Dewey_Decimal_System
{
    partial class ScoreAndDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreAndDetails));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txbFinalScore = new TextBox();
            txbScore = new TextBox();
            txbBonus = new TextBox();
            btnSaveScore = new Button();
            btnPlayAgain = new Button();
            lblUserMessage = new Label();
            label1 = new Label();
            txbUsername = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(444, 73);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 23;
            label5.Text = "Final Score:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(304, 73);
            label4.Name = "label4";
            label4.Size = new Size(114, 18);
            label4.TabIndex = 22;
            label4.Text = "Bonus Points:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(173, 73);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 21;
            label3.Text = "Your Score: ";
            // 
            // txbFinalScore
            // 
            txbFinalScore.Font = new Font("Sitka Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbFinalScore.Location = new Point(444, 92);
            txbFinalScore.Margin = new Padding(4, 4, 4, 4);
            txbFinalScore.Name = "txbFinalScore";
            txbFinalScore.ReadOnly = true;
            txbFinalScore.Size = new Size(80, 26);
            txbFinalScore.TabIndex = 20;
            // 
            // txbScore
            // 
            txbScore.Font = new Font("Sitka Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbScore.Location = new Point(173, 91);
            txbScore.Margin = new Padding(4, 4, 4, 4);
            txbScore.Name = "txbScore";
            txbScore.ReadOnly = true;
            txbScore.Size = new Size(78, 26);
            txbScore.TabIndex = 19;
            // 
            // txbBonus
            // 
            txbBonus.Font = new Font("Sitka Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbBonus.Location = new Point(304, 92);
            txbBonus.Margin = new Padding(4, 4, 4, 4);
            txbBonus.Name = "txbBonus";
            txbBonus.ReadOnly = true;
            txbBonus.Size = new Size(95, 26);
            txbBonus.TabIndex = 18;
            // 
            // btnSaveScore
            // 
            btnSaveScore.BackColor = Color.White;
            btnSaveScore.Location = new Point(401, 147);
            btnSaveScore.Margin = new Padding(3, 2, 3, 2);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(132, 30);
            btnSaveScore.TabIndex = 16;
            btnSaveScore.Text = "Save Score";
            btnSaveScore.UseVisualStyleBackColor = false;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.White;
            btnPlayAgain.Location = new Point(287, 263);
            btnPlayAgain.Margin = new Padding(3, 2, 3, 2);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(138, 30);
            btnPlayAgain.TabIndex = 15;
            btnPlayAgain.Text = "Play Again!";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.BackColor = Color.White;
            lblUserMessage.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserMessage.Location = new Point(102, 32);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(188, 36);
            lblUserMessage.TabIndex = 14;
            lblUserMessage.Text = "User Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(173, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 13;
            label1.Text = "Username:";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsername.Location = new Point(173, 147);
            txbUsername.Margin = new Padding(4, 4, 4, 4);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(211, 38);
            txbUsername.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(340, 192);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 24;
            label6.Text = "OR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(255, 220);
            label7.Name = "label7";
            label7.Size = new Size(222, 35);
            label7.TabIndex = 25;
            label7.Text = "Aim for a better score?";
            // 
            // ScoreAndDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(686, 364);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbFinalScore);
            Controls.Add(txbScore);
            Controls.Add(txbBonus);
            Controls.Add(btnSaveScore);
            Controls.Add(btnPlayAgain);
            Controls.Add(lblUserMessage);
            Controls.Add(label1);
            Controls.Add(txbUsername);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ScoreAndDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreAndDetails";
            FormClosed += ScoreAndDetails_FormClosed;
            Load += ScoreAndDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txbFinalScore;
        private TextBox txbScore;
        private TextBox txbBonus;
        private Button btnSaveScore;
        private Button btnPlayAgain;
        private Label lblUserMessage;
        private Label label1;
        private TextBox txbUsername;
        private Label label6;
        private Label label7;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
