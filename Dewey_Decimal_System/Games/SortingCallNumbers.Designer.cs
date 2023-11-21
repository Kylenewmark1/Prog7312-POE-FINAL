namespace Dewey_Decimal_System
{
    partial class frmSortingCallNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortingCallNumbers));
            lstboxRandom = new ListBox();
            lstboxSorted = new ListBox();
            lblCountdown = new Label();
            lblCountdownEdit = new Label();
            btnUp = new Button();
            btnDown = new Button();
            toolTipUp = new ToolTip(components);
            toolTipDown = new ToolTip(components);
            toolTipLbox1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lstboxRandom
            // 
            lstboxRandom.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lstboxRandom.FormattingEnabled = true;
            lstboxRandom.ItemHeight = 25;
            lstboxRandom.Location = new Point(56, 73);
            lstboxRandom.Margin = new Padding(3, 2, 3, 2);
            lstboxRandom.Name = "lstboxRandom";
            lstboxRandom.Size = new Size(210, 204);
            lstboxRandom.TabIndex = 0;
            toolTipLbox1.SetToolTip(lstboxRandom, "Drag the item from this list box to the other to play the game. Sort the Items in ascending order.");
            lstboxRandom.MouseDown += lstboxRandom_MouseDown;
            // 
            // lstboxSorted
            // 
            lstboxSorted.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lstboxSorted.FormattingEnabled = true;
            lstboxSorted.ItemHeight = 25;
            lstboxSorted.Location = new Point(321, 73);
            lstboxSorted.Margin = new Padding(3, 2, 3, 2);
            lstboxSorted.Name = "lstboxSorted";
            lstboxSorted.Size = new Size(212, 204);
            lstboxSorted.TabIndex = 1;
            lstboxSorted.DragDrop += lstboxSorted_DragDrop;
            lstboxSorted.DragEnter += lstboxSorted_DragEnter;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.Transparent;
            lblCountdown.Location = new Point(129, 27);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(137, 36);
            lblCountdown.TabIndex = 2;
            lblCountdown.Text = "Timer : ";
            // 
            // lblCountdownEdit
            // 
            lblCountdownEdit.AutoSize = true;
            lblCountdownEdit.BackColor = Color.Transparent;
            lblCountdownEdit.Font = new Font("Perpetua Titling MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdownEdit.ForeColor = Color.Transparent;
            lblCountdownEdit.Location = new Point(391, 27);
            lblCountdownEdit.Name = "lblCountdownEdit";
            lblCountdownEdit.Size = new Size(102, 34);
            lblCountdownEdit.TabIndex = 4;
            lblCountdownEdit.Text = "00:00";
            // 
            // btnUp
            // 
            btnUp.BackgroundImage = (Image)resources.GetObject("btnUp.BackgroundImage");
            btnUp.BackgroundImageLayout = ImageLayout.Center;
            btnUp.Location = new Point(552, 73);
            btnUp.Margin = new Padding(3, 2, 3, 2);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(62, 51);
            btnUp.TabIndex = 5;
            toolTipUp.SetToolTip(btnUp, "Select a call number and then press this button to move the call number up in the listbox.");
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.BackgroundImage = (Image)resources.GetObject("btnDown.BackgroundImage");
            btnDown.BackgroundImageLayout = ImageLayout.Center;
            btnDown.Location = new Point(552, 226);
            btnDown.Margin = new Padding(3, 2, 3, 2);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(62, 51);
            btnDown.TabIndex = 6;
            toolTipDown.SetToolTip(btnDown, "Select a call number and then press this button to move the call number down in the listbox.");
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // toolTipUp
            // 
            toolTipUp.IsBalloon = true;
            toolTipUp.ToolTipIcon = ToolTipIcon.Info;
            toolTipUp.ToolTipTitle = "Move Item Up";
            // 
            // toolTipDown
            // 
            toolTipDown.IsBalloon = true;
            toolTipDown.ToolTipIcon = ToolTipIcon.Info;
            toolTipDown.ToolTipTitle = "Move Item Down";
            // 
            // toolTipLbox1
            // 
            toolTipLbox1.IsBalloon = true;
            toolTipLbox1.ToolTipTitle = "Drag Items";
            // 
            // frmSortingCallNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 355);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblCountdownEdit);
            Controls.Add(lblCountdown);
            Controls.Add(lstboxSorted);
            Controls.Add(lstboxRandom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmSortingCallNumbers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SortingCallNumbers";
            FormClosed += frmSortingCallNumbers_FormClosed;
            Load += frmSortingCallNumbers_Load;
            MouseHover += frmSortingCallNumbers_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstboxRandom;
        private ListBox lstboxSorted;
        private Label lblCountdown;
        private Label lblCountdownEdit;
        private Button btnUp;
        private Button btnDown;
        private ToolTip toolTipUp;
        private ToolTip toolTipDown;
        private ToolTip toolTipLbox1;
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
