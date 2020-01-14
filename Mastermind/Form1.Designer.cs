namespace Mastermind
{
    partial class Form1
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
            this.StartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComputerPosition = new System.Windows.Forms.CheckBox();
            this.SinglePlayerOpt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slpotAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorAmount = new System.Windows.Forms.NumericUpDown();
            this.enableNull = new System.Windows.Forms.CheckBox();
            this.enableRepeats = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TryCountLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slpotAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TryCountLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(238, 90);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(166, 43);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            this.StartGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartGame_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TryCountLimit);
            this.groupBox1.Controls.Add(this.ComputerPosition);
            this.groupBox1.Controls.Add(this.SinglePlayerOpt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slpotAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colorAmount);
            this.groupBox1.Controls.Add(this.enableNull);
            this.groupBox1.Controls.Add(this.enableRepeats);
            this.groupBox1.Location = new System.Drawing.Point(684, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ComputerPosition
            // 
            this.ComputerPosition.AutoSize = true;
            this.ComputerPosition.Checked = true;
            this.ComputerPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ComputerPosition.Location = new System.Drawing.Point(6, 192);
            this.ComputerPosition.Name = "ComputerPosition";
            this.ComputerPosition.Size = new System.Drawing.Size(125, 21);
            this.ComputerPosition.TabIndex = 7;
            this.ComputerPosition.Text = "Comp Creator?";
            this.ComputerPosition.UseVisualStyleBackColor = true;
            this.ComputerPosition.Visible = false;
            // 
            // SinglePlayerOpt
            // 
            this.SinglePlayerOpt.AutoSize = true;
            this.SinglePlayerOpt.Location = new System.Drawing.Point(6, 165);
            this.SinglePlayerOpt.Name = "SinglePlayerOpt";
            this.SinglePlayerOpt.Size = new System.Drawing.Size(121, 21);
            this.SinglePlayerOpt.TabIndex = 6;
            this.SinglePlayerOpt.Text = "Single Player?";
            this.SinglePlayerOpt.UseVisualStyleBackColor = true;
            this.SinglePlayerOpt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Slots";
            // 
            // slpotAmount
            // 
            this.slpotAmount.Location = new System.Drawing.Point(7, 107);
            this.slpotAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.slpotAmount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.slpotAmount.Name = "slpotAmount";
            this.slpotAmount.Size = new System.Drawing.Size(46, 22);
            this.slpotAmount.TabIndex = 4;
            this.slpotAmount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Colors";
            // 
            // colorAmount
            // 
            this.colorAmount.Location = new System.Drawing.Point(7, 78);
            this.colorAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorAmount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colorAmount.Name = "colorAmount";
            this.colorAmount.Size = new System.Drawing.Size(46, 22);
            this.colorAmount.TabIndex = 2;
            this.colorAmount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // enableNull
            // 
            this.enableNull.AutoSize = true;
            this.enableNull.Location = new System.Drawing.Point(7, 50);
            this.enableNull.Name = "enableNull";
            this.enableNull.Size = new System.Drawing.Size(112, 21);
            this.enableNull.TabIndex = 1;
            this.enableNull.Text = "Empty Slots?";
            this.enableNull.UseVisualStyleBackColor = true;
            // 
            // enableRepeats
            // 
            this.enableRepeats.AutoSize = true;
            this.enableRepeats.Location = new System.Drawing.Point(7, 22);
            this.enableRepeats.Name = "enableRepeats";
            this.enableRepeats.Size = new System.Drawing.Size(147, 21);
            this.enableRepeats.TabIndex = 0;
            this.enableRepeats.Text = "Repeating Colors?";
            this.enableRepeats.UseVisualStyleBackColor = true;
            this.enableRepeats.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Tries";
            // 
            // TryCountLimit
            // 
            this.TryCountLimit.Location = new System.Drawing.Point(7, 135);
            this.TryCountLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TryCountLimit.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TryCountLimit.Name = "TryCountLimit";
            this.TryCountLimit.Size = new System.Drawing.Size(46, 22);
            this.TryCountLimit.TabIndex = 8;
            this.TryCountLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slpotAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TryCountLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox enableNull;
        private System.Windows.Forms.CheckBox enableRepeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown slpotAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colorAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SinglePlayerOpt;
        private System.Windows.Forms.CheckBox ComputerPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TryCountLimit;
    }
}

