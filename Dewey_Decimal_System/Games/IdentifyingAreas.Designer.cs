namespace Dewey_Decimal_System
{
    partial class IdentifyingAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyingAreas));
            lblTimer = new Label();
            btnCheckAnswer = new Button();
            lstboxDescription = new ListBox();
            lstboxCallNo = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(304, 16);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(87, 40);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "00:00";
            // 
            // btnCheckAnswer
            // 
            btnCheckAnswer.Location = new Point(182, 299);
            btnCheckAnswer.Margin = new Padding(3, 2, 3, 2);
            btnCheckAnswer.Name = "btnCheckAnswer";
            btnCheckAnswer.Size = new Size(303, 36);
            btnCheckAnswer.TabIndex = 6;
            btnCheckAnswer.Text = "Check Answer";
            btnCheckAnswer.UseVisualStyleBackColor = true;
            btnCheckAnswer.Click += btnCheckAnswer_Click;
            // 
            // lstboxDescription
            // 
            lstboxDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstboxDescription.FormattingEnabled = true;
            lstboxDescription.ItemHeight = 25;
            lstboxDescription.Location = new Point(55, 102);
            lstboxDescription.Margin = new Padding(3, 2, 3, 2);
            lstboxDescription.Name = "lstboxDescription";
            lstboxDescription.Size = new Size(268, 154);
            lstboxDescription.TabIndex = 5;
            lstboxDescription.MouseDown += lstboxDescription_MouseDown;
            // 
            // lstboxCallNo
            // 
            lstboxCallNo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstboxCallNo.FormattingEnabled = true;
            lstboxCallNo.ItemHeight = 30;
            lstboxCallNo.Location = new Point(362, 102);
            lstboxCallNo.Margin = new Padding(3, 2, 3, 2);
            lstboxCallNo.Name = "lstboxCallNo";
            lstboxCallNo.Size = new Size(280, 154);
            lstboxCallNo.TabIndex = 4;
            lstboxCallNo.MouseDown += lstboxCallNo_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 16);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 8;
            label1.Text = "Timer :";
            // 
            // IdentifyingAreas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 355);
            Controls.Add(label1);
            Controls.Add(lblTimer);
            Controls.Add(btnCheckAnswer);
            Controls.Add(lstboxDescription);
            Controls.Add(lstboxCallNo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdentifyingAreas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IdentifyingAreas";
            FormClosed += IdentifyingAreas_FormClosed;
            Load += IdentifyingAreas_Load;
            MouseHover += IdentifyingAreas_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnCheckAnswer;
        private ListBox lstboxDescription;
        private ListBox lstboxCallNo;
        private Label label1;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
