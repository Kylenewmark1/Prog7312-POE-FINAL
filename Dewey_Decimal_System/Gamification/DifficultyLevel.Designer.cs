namespace Dewey_Decimal_System
{
    partial class frmDifficultyLevel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDifficultyLevel));
            btnEasy = new Button();
            btnMed = new Button();
            btnHard = new Button();
            label1 = new Label();
            toolTipMode1 = new ToolTip(components);
            toolTipMode2 = new ToolTip(components);
            toolTipMode3 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.White;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEasy.ForeColor = Color.Black;
            btnEasy.Location = new Point(223, 197);
            btnEasy.Margin = new Padding(4, 3, 4, 3);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(329, 48);
            btnEasy.TabIndex = 0;
            btnEasy.Text = "Easy Mode";
            toolTipMode1.SetToolTip(btnEasy, "Double click on the button to select the easy difficulty mode.");
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMed
            // 
            btnMed.BackColor = Color.FromArgb(255, 128, 0);
            btnMed.FlatStyle = FlatStyle.Flat;
            btnMed.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMed.ForeColor = Color.Black;
            btnMed.Location = new Point(223, 260);
            btnMed.Margin = new Padding(4, 3, 4, 3);
            btnMed.Name = "btnMed";
            btnMed.Size = new Size(329, 48);
            btnMed.TabIndex = 1;
            btnMed.Text = "Medium Mode";
            toolTipMode2.SetToolTip(btnMed, "Double click on the button to select the medium difficulty mode.");
            btnMed.UseVisualStyleBackColor = false;
            btnMed.Click += btnMed_Click;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.Red;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHard.ForeColor = Color.Black;
            btnHard.Location = new Point(223, 326);
            btnHard.Margin = new Padding(4, 3, 4, 3);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(329, 48);
            btnHard.TabIndex = 2;
            btnHard.Text = "Hard Mode";
            toolTipMode3.SetToolTip(btnHard, "Double click on the button to select the hard difficulty mode.");
            btnHard.UseVisualStyleBackColor = false;
            btnHard.Click += btnHard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 133);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 33);
            label1.TabIndex = 3;
            label1.Text = "Difficulty Mode";
            // 
            // toolTipMode1
            // 
            toolTipMode1.IsBalloon = true;
            toolTipMode1.ToolTipIcon = ToolTipIcon.Info;
            toolTipMode1.ToolTipTitle = "Easy Mode";
            // 
            // toolTipMode2
            // 
            toolTipMode2.IsBalloon = true;
            toolTipMode2.ToolTipIcon = ToolTipIcon.Info;
            toolTipMode2.ToolTipTitle = "Medium Mode";
            // 
            // toolTipMode3
            // 
            toolTipMode3.IsBalloon = true;
            toolTipMode3.ToolTipIcon = ToolTipIcon.Info;
            toolTipMode3.ToolTipTitle = "Hard Mode";
            // 
            // frmDifficultyLevel
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(label1);
            Controls.Add(btnHard);
            Controls.Add(btnMed);
            Controls.Add(btnEasy);
            DoubleBuffered = true;
            Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmDifficultyLevel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DifficultyLevel";
            FormClosed += frmDifficultyLevel_FormClosed;
            Load += DifficultyLevel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEasy;
        private Button btnMed;
        private Button btnHard;
        private Label label1;
        private ToolTip toolTipMode1;
        private ToolTip toolTipMode2;
        private ToolTip toolTipMode3;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
