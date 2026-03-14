namespace Project_Tic_Tac_Toe
{
    partial class TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbCheckPlayer = new System.Windows.Forms.Label();
            this.LbWhoWinOrDraw = new System.Windows.Forms.Label();
            this.LbWinOrLoseOrDraw = new System.Windows.Forms.Label();
            this.BtRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(54, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // LbCheckPlayer
            // 
            this.LbCheckPlayer.AutoSize = true;
            this.LbCheckPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCheckPlayer.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbCheckPlayer.Location = new System.Drawing.Point(54, 178);
            this.LbCheckPlayer.Name = "LbCheckPlayer";
            this.LbCheckPlayer.Size = new System.Drawing.Size(118, 32);
            this.LbCheckPlayer.TabIndex = 1;
            this.LbCheckPlayer.Text = "Player1";
            // 
            // LbWhoWinOrDraw
            // 
            this.LbWhoWinOrDraw.AutoSize = true;
            this.LbWhoWinOrDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWhoWinOrDraw.ForeColor = System.Drawing.Color.Yellow;
            this.LbWhoWinOrDraw.Location = new System.Drawing.Point(54, 227);
            this.LbWhoWinOrDraw.Name = "LbWhoWinOrDraw";
            this.LbWhoWinOrDraw.Size = new System.Drawing.Size(110, 32);
            this.LbWhoWinOrDraw.TabIndex = 2;
            this.LbWhoWinOrDraw.Text = "Winner";
            // 
            // LbWinOrLoseOrDraw
            // 
            this.LbWinOrLoseOrDraw.AutoSize = true;
            this.LbWinOrLoseOrDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinOrLoseOrDraw.ForeColor = System.Drawing.Color.Chartreuse;
            this.LbWinOrLoseOrDraw.Location = new System.Drawing.Point(54, 280);
            this.LbWinOrLoseOrDraw.Name = "LbWinOrLoseOrDraw";
            this.LbWinOrLoseOrDraw.Size = new System.Drawing.Size(168, 32);
            this.LbWinOrLoseOrDraw.TabIndex = 3;
            this.LbWinOrLoseOrDraw.Text = "In Progress";
            // 
            // BtRestart
            // 
            this.BtRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRestart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtRestart.Location = new System.Drawing.Point(39, 336);
            this.BtRestart.Name = "BtRestart";
            this.BtRestart.Size = new System.Drawing.Size(206, 45);
            this.BtRestart.TabIndex = 4;
            this.BtRestart.Text = "Restart Game";
            this.BtRestart.UseVisualStyleBackColor = true;
            this.BtRestart.Click += new System.EventHandler(this.BtRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(386, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tic-Tac-Toe Game";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(419, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 76);
            this.button2.TabIndex = 6;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(569, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 76);
            this.button3.TabIndex = 7;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(705, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 76);
            this.button4.TabIndex = 8;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(419, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 76);
            this.button5.TabIndex = 9;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(569, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 76);
            this.button6.TabIndex = 10;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(705, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 76);
            this.button7.TabIndex = 11;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(419, 387);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 76);
            this.button8.TabIndex = 12;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(569, 387);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 76);
            this.button9.TabIndex = 13;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(705, 387);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 76);
            this.button10.TabIndex = 14;
            this.button10.Text = "?";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(896, 593);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtRestart);
            this.Controls.Add(this.LbWinOrLoseOrDraw);
            this.Controls.Add(this.LbWhoWinOrDraw);
            this.Controls.Add(this.LbCheckPlayer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Tic_Tac_Toe);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbCheckPlayer;
        private System.Windows.Forms.Label LbWhoWinOrDraw;
        private System.Windows.Forms.Label LbWinOrLoseOrDraw;
        private System.Windows.Forms.Button BtRestart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

