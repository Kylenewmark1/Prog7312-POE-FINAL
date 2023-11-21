namespace Dewey_Decimal_System.Games
{
    partial class FindingCallNumbers
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
            btnChoice1 = new Button();
            btnChoice2 = new Button();
            btnChoice3 = new Button();
            btnChoice4 = new Button();
            txbDescription = new TextBox();
            label1 = new Label();
            lblTimer = new Label();
            SuspendLayout();
            // 
            // btnChoice1
            // 
            btnChoice1.BackColor = Color.White;
            btnChoice1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoice1.Location = new Point(52, 246);
            btnChoice1.Margin = new Padding(3, 2, 3, 2);
            btnChoice1.Name = "btnChoice1";
            btnChoice1.Size = new Size(149, 110);
            btnChoice1.TabIndex = 0;
            btnChoice1.Text = "button1";
            btnChoice1.UseVisualStyleBackColor = false;
            btnChoice1.Click += btnChoice1_Click;
            // 
            // btnChoice2
            // 
            btnChoice2.BackColor = Color.White;
            btnChoice2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoice2.Location = new Point(237, 246);
            btnChoice2.Margin = new Padding(3, 2, 3, 2);
            btnChoice2.Name = "btnChoice2";
            btnChoice2.Size = new Size(149, 110);
            btnChoice2.TabIndex = 1;
            btnChoice2.Text = "button2";
            btnChoice2.UseVisualStyleBackColor = false;
            btnChoice2.Click += btnChoice2_Click;
            // 
            // btnChoice3
            // 
            btnChoice3.BackColor = Color.White;
            btnChoice3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoice3.Location = new Point(424, 246);
            btnChoice3.Margin = new Padding(3, 2, 3, 2);
            btnChoice3.Name = "btnChoice3";
            btnChoice3.Size = new Size(149, 110);
            btnChoice3.TabIndex = 2;
            btnChoice3.Text = "button3";
            btnChoice3.UseVisualStyleBackColor = false;
            btnChoice3.Click += btnChoice3_Click;
            // 
            // btnChoice4
            // 
            btnChoice4.BackColor = Color.White;
            btnChoice4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoice4.Location = new Point(621, 246);
            btnChoice4.Margin = new Padding(3, 2, 3, 2);
            btnChoice4.Name = "btnChoice4";
            btnChoice4.Size = new Size(149, 110);
            btnChoice4.TabIndex = 3;
            btnChoice4.Text = "button4";
            btnChoice4.UseVisualStyleBackColor = false;
            btnChoice4.Click += btnChoice4_Click;
            // 
            // txbDescription
            // 
            txbDescription.BackColor = Color.White;
            txbDescription.BorderStyle = BorderStyle.FixedSingle;
            txbDescription.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txbDescription.Location = new Point(154, 147);
            txbDescription.Margin = new Padding(3, 2, 3, 2);
            txbDescription.Name = "txbDescription";
            txbDescription.ReadOnly = true;
            txbDescription.Size = new Size(501, 40);
            txbDescription.TabIndex = 4;
            txbDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 10;
            label1.Text = "Timer :";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(428, 32);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(87, 40);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "00:00";
            // 
            // FindingCallNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 416);
            Controls.Add(label1);
            Controls.Add(lblTimer);
            Controls.Add(txbDescription);
            Controls.Add(btnChoice4);
            Controls.Add(btnChoice3);
            Controls.Add(btnChoice2);
            Controls.Add(btnChoice1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FindingCallNumbers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FindingCallNumbers";
            Load += FindingCallNumbers_Load;
            MouseMove += FindingCallNumbers_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChoice1;
        private Button btnChoice2;
        private Button btnChoice3;
        private Button btnChoice4;
        private TextBox txbDescription;
        private Label label1;
        private Label lblTimer;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
