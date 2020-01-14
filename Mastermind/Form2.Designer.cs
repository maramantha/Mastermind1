namespace Mastermind
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Peg8 = new System.Windows.Forms.Button();
            this.Peg9 = new System.Windows.Forms.Button();
            this.Peg10 = new System.Windows.Forms.Button();
            this.ReturnGuesses = new System.Windows.Forms.DataGridView();
            this.submitFunction = new System.Windows.Forms.Button();
            this.Slot1 = new System.Windows.Forms.Button();
            this.Slot2 = new System.Windows.Forms.Button();
            this.Slot4 = new System.Windows.Forms.Button();
            this.Slot3 = new System.Windows.Forms.Button();
            this.Slot6 = new System.Windows.Forms.Button();
            this.Slot5 = new System.Windows.Forms.Button();
            this.Slot8 = new System.Windows.Forms.Button();
            this.Slot7 = new System.Windows.Forms.Button();
            this.Slot10 = new System.Windows.Forms.Button();
            this.Slot9 = new System.Windows.Forms.Button();
            this.RightLocationRightColor = new System.Windows.Forms.Label();
            this.RightColorWrongLocation = new System.Windows.Forms.Label();
            this.Peg7 = new System.Windows.Forms.Button();
            this.Peg6 = new System.Windows.Forms.Button();
            this.Peg5 = new System.Windows.Forms.Button();
            this.Peg4 = new System.Windows.Forms.Button();
            this.Peg3 = new System.Windows.Forms.Button();
            this.Peg2 = new System.Windows.Forms.Button();
            this.Peg1 = new System.Windows.Forms.Button();
            this.TriesRemaining = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGuesses)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(743, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Peg8
            // 
            this.Peg8.BackgroundImage = global::Mastermind.Properties.Resources.PinkPeg;
            this.Peg8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg8.Enabled = false;
            this.Peg8.Location = new System.Drawing.Point(174, 502);
            this.Peg8.Name = "Peg8";
            this.Peg8.Size = new System.Drawing.Size(75, 72);
            this.Peg8.TabIndex = 17;
            this.Peg8.Tag = "Pink";
            this.Peg8.UseVisualStyleBackColor = true;
            this.Peg8.Visible = false;
            this.Peg8.Click += new System.EventHandler(this.Peg8_Click);
            // 
            // Peg9
            // 
            this.Peg9.BackgroundImage = global::Mastermind.Properties.Resources.BrownPeg;
            this.Peg9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg9.Enabled = false;
            this.Peg9.Location = new System.Drawing.Point(255, 502);
            this.Peg9.Name = "Peg9";
            this.Peg9.Size = new System.Drawing.Size(75, 72);
            this.Peg9.TabIndex = 18;
            this.Peg9.Tag = "Brown";
            this.Peg9.UseVisualStyleBackColor = true;
            this.Peg9.Visible = false;
            this.Peg9.Click += new System.EventHandler(this.Peg9_Click);
            // 
            // Peg10
            // 
            this.Peg10.BackgroundImage = global::Mastermind.Properties.Resources.PurplePeg;
            this.Peg10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg10.Enabled = false;
            this.Peg10.Location = new System.Drawing.Point(336, 502);
            this.Peg10.Name = "Peg10";
            this.Peg10.Size = new System.Drawing.Size(75, 72);
            this.Peg10.TabIndex = 19;
            this.Peg10.Tag = "Purple";
            this.Peg10.UseVisualStyleBackColor = true;
            this.Peg10.Visible = false;
            this.Peg10.Click += new System.EventHandler(this.Peg10_Click);
            // 
            // ReturnGuesses
            // 
            this.ReturnGuesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnGuesses.Location = new System.Drawing.Point(12, 76);
            this.ReturnGuesses.Name = "ReturnGuesses";
            this.ReturnGuesses.RowHeadersWidth = 51;
            this.ReturnGuesses.RowTemplate.Height = 24;
            this.ReturnGuesses.Size = new System.Drawing.Size(849, 342);
            this.ReturnGuesses.TabIndex = 20;
            // 
            // submitFunction
            // 
            this.submitFunction.Location = new System.Drawing.Point(438, 424);
            this.submitFunction.Name = "submitFunction";
            this.submitFunction.Size = new System.Drawing.Size(118, 38);
            this.submitFunction.TabIndex = 0;
            this.submitFunction.Text = "Submit";
            this.submitFunction.UseVisualStyleBackColor = true;
            this.submitFunction.Click += new System.EventHandler(this.submitFunction_Click);
            // 
            // Slot1
            // 
            this.Slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot1.Location = new System.Drawing.Point(12, 12);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(49, 58);
            this.Slot1.TabIndex = 22;
            this.Slot1.Tag = "NoColor";
            this.Slot1.UseVisualStyleBackColor = true;
            this.Slot1.Click += new System.EventHandler(this.Slot1_Click);
            // 
            // Slot2
            // 
            this.Slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot2.Location = new System.Drawing.Point(67, 12);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(49, 58);
            this.Slot2.TabIndex = 23;
            this.Slot2.Tag = "NoColor";
            this.Slot2.UseVisualStyleBackColor = true;
            this.Slot2.Click += new System.EventHandler(this.Slot2_Click);
            // 
            // Slot4
            // 
            this.Slot4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot4.Location = new System.Drawing.Point(177, 12);
            this.Slot4.Name = "Slot4";
            this.Slot4.Size = new System.Drawing.Size(49, 58);
            this.Slot4.TabIndex = 25;
            this.Slot4.Tag = "NoColor";
            this.Slot4.UseVisualStyleBackColor = true;
            this.Slot4.Click += new System.EventHandler(this.Slot4_Click);
            // 
            // Slot3
            // 
            this.Slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot3.Location = new System.Drawing.Point(122, 12);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(49, 58);
            this.Slot3.TabIndex = 24;
            this.Slot3.Tag = "NoColor";
            this.Slot3.UseVisualStyleBackColor = true;
            this.Slot3.Click += new System.EventHandler(this.Slot3_Click);
            // 
            // Slot6
            // 
            this.Slot6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot6.Enabled = false;
            this.Slot6.Location = new System.Drawing.Point(287, 12);
            this.Slot6.Name = "Slot6";
            this.Slot6.Size = new System.Drawing.Size(49, 58);
            this.Slot6.TabIndex = 27;
            this.Slot6.Tag = "NoColor";
            this.Slot6.UseVisualStyleBackColor = true;
            this.Slot6.Visible = false;
            this.Slot6.Click += new System.EventHandler(this.Slot6_Click);
            // 
            // Slot5
            // 
            this.Slot5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot5.Enabled = false;
            this.Slot5.Location = new System.Drawing.Point(232, 12);
            this.Slot5.Name = "Slot5";
            this.Slot5.Size = new System.Drawing.Size(49, 58);
            this.Slot5.TabIndex = 26;
            this.Slot5.Tag = "NoColor";
            this.Slot5.UseVisualStyleBackColor = true;
            this.Slot5.Visible = false;
            this.Slot5.Click += new System.EventHandler(this.Slot5_Click);
            // 
            // Slot8
            // 
            this.Slot8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot8.Enabled = false;
            this.Slot8.Location = new System.Drawing.Point(397, 12);
            this.Slot8.Name = "Slot8";
            this.Slot8.Size = new System.Drawing.Size(49, 58);
            this.Slot8.TabIndex = 29;
            this.Slot8.Tag = "NoColor";
            this.Slot8.UseVisualStyleBackColor = true;
            this.Slot8.Visible = false;
            this.Slot8.Click += new System.EventHandler(this.Slot8_Click);
            // 
            // Slot7
            // 
            this.Slot7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot7.Enabled = false;
            this.Slot7.Location = new System.Drawing.Point(342, 12);
            this.Slot7.Name = "Slot7";
            this.Slot7.Size = new System.Drawing.Size(49, 58);
            this.Slot7.TabIndex = 28;
            this.Slot7.Tag = "NoColor";
            this.Slot7.UseVisualStyleBackColor = true;
            this.Slot7.Visible = false;
            this.Slot7.Click += new System.EventHandler(this.Slot7_Click);
            // 
            // Slot10
            // 
            this.Slot10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot10.Enabled = false;
            this.Slot10.Location = new System.Drawing.Point(507, 12);
            this.Slot10.Name = "Slot10";
            this.Slot10.Size = new System.Drawing.Size(49, 58);
            this.Slot10.TabIndex = 31;
            this.Slot10.Tag = "NoColor";
            this.Slot10.UseVisualStyleBackColor = true;
            this.Slot10.Visible = false;
            this.Slot10.Click += new System.EventHandler(this.Slot10_Click);
            // 
            // Slot9
            // 
            this.Slot9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slot9.Enabled = false;
            this.Slot9.Location = new System.Drawing.Point(452, 12);
            this.Slot9.Name = "Slot9";
            this.Slot9.Size = new System.Drawing.Size(49, 58);
            this.Slot9.TabIndex = 30;
            this.Slot9.Tag = "NoColor";
            this.Slot9.UseVisualStyleBackColor = true;
            this.Slot9.Visible = false;
            this.Slot9.Click += new System.EventHandler(this.Slot9_Click);
            // 
            // RightLocationRightColor
            // 
            this.RightLocationRightColor.AutoSize = true;
            this.RightLocationRightColor.Location = new System.Drawing.Point(562, 12);
            this.RightLocationRightColor.Name = "RightLocationRightColor";
            this.RightLocationRightColor.Size = new System.Drawing.Size(0, 17);
            this.RightLocationRightColor.TabIndex = 32;
            // 
            // RightColorWrongLocation
            // 
            this.RightColorWrongLocation.AutoSize = true;
            this.RightColorWrongLocation.Location = new System.Drawing.Point(562, 53);
            this.RightColorWrongLocation.Name = "RightColorWrongLocation";
            this.RightColorWrongLocation.Size = new System.Drawing.Size(0, 17);
            this.RightColorWrongLocation.TabIndex = 33;
            // 
            // Peg7
            // 
            this.Peg7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Peg7.BackgroundImage = global::Mastermind.Properties.Resources.WhitePeg;
            this.Peg7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg7.Enabled = false;
            this.Peg7.Location = new System.Drawing.Point(96, 502);
            this.Peg7.Name = "Peg7";
            this.Peg7.Size = new System.Drawing.Size(75, 72);
            this.Peg7.TabIndex = 16;
            this.Peg7.Tag = "White";
            this.Peg7.UseVisualStyleBackColor = true;
            this.Peg7.Visible = false;
            this.Peg7.Click += new System.EventHandler(this.Peg7_Click);
            // 
            // Peg6
            // 
            this.Peg6.BackgroundImage = global::Mastermind.Properties.Resources.YellowPeg;
            this.Peg6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg6.Location = new System.Drawing.Point(12, 502);
            this.Peg6.Name = "Peg6";
            this.Peg6.Size = new System.Drawing.Size(75, 72);
            this.Peg6.TabIndex = 15;
            this.Peg6.Tag = "Yellow";
            this.Peg6.UseVisualStyleBackColor = true;
            this.Peg6.Click += new System.EventHandler(this.Peg6_Click);
            // 
            // Peg5
            // 
            this.Peg5.BackgroundImage = global::Mastermind.Properties.Resources.RedPeg;
            this.Peg5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg5.Location = new System.Drawing.Point(336, 424);
            this.Peg5.Name = "Peg5";
            this.Peg5.Size = new System.Drawing.Size(75, 72);
            this.Peg5.TabIndex = 14;
            this.Peg5.Tag = "Red";
            this.Peg5.UseVisualStyleBackColor = true;
            this.Peg5.Click += new System.EventHandler(this.Peg5_Click);
            // 
            // Peg4
            // 
            this.Peg4.BackgroundImage = global::Mastermind.Properties.Resources.OrangePeg;
            this.Peg4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg4.Location = new System.Drawing.Point(255, 424);
            this.Peg4.Name = "Peg4";
            this.Peg4.Size = new System.Drawing.Size(75, 72);
            this.Peg4.TabIndex = 13;
            this.Peg4.Tag = "Orange";
            this.Peg4.UseVisualStyleBackColor = true;
            this.Peg4.Click += new System.EventHandler(this.Peg4_Click);
            // 
            // Peg3
            // 
            this.Peg3.BackgroundImage = global::Mastermind.Properties.Resources.GreenPeg;
            this.Peg3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg3.Location = new System.Drawing.Point(174, 424);
            this.Peg3.Name = "Peg3";
            this.Peg3.Size = new System.Drawing.Size(75, 72);
            this.Peg3.TabIndex = 12;
            this.Peg3.Tag = "Green";
            this.Peg3.UseVisualStyleBackColor = true;
            this.Peg3.Click += new System.EventHandler(this.Peg3_Click);
            // 
            // Peg2
            // 
            this.Peg2.BackgroundImage = global::Mastermind.Properties.Resources.BluePeg;
            this.Peg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg2.Location = new System.Drawing.Point(93, 424);
            this.Peg2.Name = "Peg2";
            this.Peg2.Size = new System.Drawing.Size(75, 72);
            this.Peg2.TabIndex = 11;
            this.Peg2.Tag = "Blue";
            this.Peg2.UseVisualStyleBackColor = true;
            this.Peg2.Click += new System.EventHandler(this.Peg2_Click);
            // 
            // Peg1
            // 
            this.Peg1.BackColor = System.Drawing.SystemColors.Control;
            this.Peg1.BackgroundImage = global::Mastermind.Properties.Resources.BlackPeg;
            this.Peg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Peg1.Location = new System.Drawing.Point(12, 424);
            this.Peg1.Name = "Peg1";
            this.Peg1.Size = new System.Drawing.Size(75, 72);
            this.Peg1.TabIndex = 2;
            this.Peg1.Tag = "Black";
            this.Peg1.UseVisualStyleBackColor = false;
            this.Peg1.Click += new System.EventHandler(this.Peg1_Click);
            // 
            // TriesRemaining
            // 
            this.TriesRemaining.AutoSize = true;
            this.TriesRemaining.Location = new System.Drawing.Point(565, 425);
            this.TriesRemaining.Name = "TriesRemaining";
            this.TriesRemaining.Size = new System.Drawing.Size(0, 17);
            this.TriesRemaining.TabIndex = 34;
            // 
            // Form2
            // 
            this.AcceptButton = this.submitFunction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(881, 615);
            this.Controls.Add(this.TriesRemaining);
            this.Controls.Add(this.RightColorWrongLocation);
            this.Controls.Add(this.RightLocationRightColor);
            this.Controls.Add(this.Slot10);
            this.Controls.Add(this.Slot9);
            this.Controls.Add(this.Slot8);
            this.Controls.Add(this.Slot7);
            this.Controls.Add(this.Slot6);
            this.Controls.Add(this.Slot5);
            this.Controls.Add(this.Slot4);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.submitFunction);
            this.Controls.Add(this.ReturnGuesses);
            this.Controls.Add(this.Peg10);
            this.Controls.Add(this.Peg9);
            this.Controls.Add(this.Peg8);
            this.Controls.Add(this.Peg7);
            this.Controls.Add(this.Peg6);
            this.Controls.Add(this.Peg5);
            this.Controls.Add(this.Peg4);
            this.Controls.Add(this.Peg3);
            this.Controls.Add(this.Peg2);
            this.Controls.Add(this.Peg1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGuesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Peg1;
        private System.Windows.Forms.Button Peg2;
        private System.Windows.Forms.Button Peg3;
        private System.Windows.Forms.Button Peg4;
        private System.Windows.Forms.Button Peg5;
        private System.Windows.Forms.Button Peg6;
        private System.Windows.Forms.Button Peg7;
        private System.Windows.Forms.Button Peg8;
        private System.Windows.Forms.Button Peg9;
        private System.Windows.Forms.Button Peg10;
        private System.Windows.Forms.DataGridView ReturnGuesses;
        private System.Windows.Forms.Button submitFunction;
        private System.Windows.Forms.Button Slot1;
        private System.Windows.Forms.Button Slot2;
        private System.Windows.Forms.Button Slot4;
        private System.Windows.Forms.Button Slot3;
        private System.Windows.Forms.Button Slot6;
        private System.Windows.Forms.Button Slot5;
        private System.Windows.Forms.Button Slot8;
        private System.Windows.Forms.Button Slot7;
        private System.Windows.Forms.Button Slot10;
        private System.Windows.Forms.Button Slot9;
        private System.Windows.Forms.Label RightLocationRightColor;
        private System.Windows.Forms.Label RightColorWrongLocation;
        private System.Windows.Forms.Label TriesRemaining;
    }
}