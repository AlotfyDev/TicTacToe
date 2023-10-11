namespace TicTacToe
{
    partial class FRM_PlayGround
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Turn = new System.Windows.Forms.Label();
            this.LBL_TurnValue = new System.Windows.Forms.Label();
            this.LBL_Winner = new System.Windows.Forms.Label();
            this.LBL_WinnerValue = new System.Windows.Forms.Label();
            this.BTN_Restart = new System.Windows.Forms.Button();
            this.BTN_Cell1 = new System.Windows.Forms.Button();
            this.BTN_Cell8 = new System.Windows.Forms.Button();
            this.BTN_Cell2 = new System.Windows.Forms.Button();
            this.BTN_Cell3 = new System.Windows.Forms.Button();
            this.BTN_Cell4 = new System.Windows.Forms.Button();
            this.BTN_Cell5 = new System.Windows.Forms.Button();
            this.BTN_Cell6 = new System.Windows.Forms.Button();
            this.BTN_Cell7 = new System.Windows.Forms.Button();
            this.BTN_Cell9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBL_Title.Location = new System.Drawing.Point(470, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(364, 86);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Tic Tac Toe";
            // 
            // LBL_Turn
            // 
            this.LBL_Turn.AutoSize = true;
            this.LBL_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Turn.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_Turn.Location = new System.Drawing.Point(23, 126);
            this.LBL_Turn.Name = "LBL_Turn";
            this.LBL_Turn.Size = new System.Drawing.Size(105, 46);
            this.LBL_Turn.TabIndex = 1;
            this.LBL_Turn.Text = "Turn";
            // 
            // LBL_TurnValue
            // 
            this.LBL_TurnValue.AutoSize = true;
            this.LBL_TurnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TurnValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LBL_TurnValue.Location = new System.Drawing.Point(23, 246);
            this.LBL_TurnValue.Name = "LBL_TurnValue";
            this.LBL_TurnValue.Size = new System.Drawing.Size(298, 46);
            this.LBL_TurnValue.TabIndex = 2;
            this.LBL_TurnValue.Text = "Player Number";
            // 
            // LBL_Winner
            // 
            this.LBL_Winner.AutoSize = true;
            this.LBL_Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Winner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBL_Winner.Location = new System.Drawing.Point(23, 389);
            this.LBL_Winner.Name = "LBL_Winner";
            this.LBL_Winner.Size = new System.Drawing.Size(152, 46);
            this.LBL_Winner.TabIndex = 3;
            this.LBL_Winner.Text = "Winner";
            // 
            // LBL_WinnerValue
            // 
            this.LBL_WinnerValue.AutoSize = true;
            this.LBL_WinnerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WinnerValue.ForeColor = System.Drawing.Color.Fuchsia;
            this.LBL_WinnerValue.Location = new System.Drawing.Point(23, 490);
            this.LBL_WinnerValue.Name = "LBL_WinnerValue";
            this.LBL_WinnerValue.Size = new System.Drawing.Size(229, 46);
            this.LBL_WinnerValue.TabIndex = 4;
            this.LBL_WinnerValue.Text = "In progress";
            // 
            // BTN_Restart
            // 
            this.BTN_Restart.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Restart.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.BTN_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Restart.ForeColor = System.Drawing.Color.Red;
            this.BTN_Restart.Location = new System.Drawing.Point(31, 611);
            this.BTN_Restart.Name = "BTN_Restart";
            this.BTN_Restart.Size = new System.Drawing.Size(203, 65);
            this.BTN_Restart.TabIndex = 6;
            this.BTN_Restart.Text = "Restart";
            this.BTN_Restart.UseVisualStyleBackColor = false;
            this.BTN_Restart.Click += new System.EventHandler(this.BTN_Restart_Click);
            // 
            // BTN_Cell1
            // 
            this.BTN_Cell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell1.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell1.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell1.Location = new System.Drawing.Point(408, 128);
            this.BTN_Cell1.Name = "BTN_Cell1";
            this.BTN_Cell1.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell1.TabIndex = 7;
            this.BTN_Cell1.Tag = "1";
            this.BTN_Cell1.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell8
            // 
            this.BTN_Cell8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell8.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell8.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell8.Location = new System.Drawing.Point(588, 488);
            this.BTN_Cell8.Name = "BTN_Cell8";
            this.BTN_Cell8.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell8.TabIndex = 8;
            this.BTN_Cell8.Tag = "128";
            this.BTN_Cell8.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell2
            // 
            this.BTN_Cell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell2.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell2.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell2.Location = new System.Drawing.Point(588, 128);
            this.BTN_Cell2.Name = "BTN_Cell2";
            this.BTN_Cell2.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell2.TabIndex = 9;
            this.BTN_Cell2.Tag = "2";
            this.BTN_Cell2.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell3
            // 
            this.BTN_Cell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell3.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell3.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell3.Location = new System.Drawing.Point(768, 128);
            this.BTN_Cell3.Name = "BTN_Cell3";
            this.BTN_Cell3.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell3.TabIndex = 10;
            this.BTN_Cell3.Tag = "4";
            this.BTN_Cell3.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell4
            // 
            this.BTN_Cell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell4.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell4.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell4.Location = new System.Drawing.Point(408, 308);
            this.BTN_Cell4.Name = "BTN_Cell4";
            this.BTN_Cell4.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell4.TabIndex = 11;
            this.BTN_Cell4.Tag = "8";
            this.BTN_Cell4.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell5
            // 
            this.BTN_Cell5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell5.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell5.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell5.Location = new System.Drawing.Point(588, 308);
            this.BTN_Cell5.Name = "BTN_Cell5";
            this.BTN_Cell5.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell5.TabIndex = 12;
            this.BTN_Cell5.Tag = "16";
            this.BTN_Cell5.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell6
            // 
            this.BTN_Cell6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell6.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell6.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell6.Location = new System.Drawing.Point(768, 308);
            this.BTN_Cell6.Name = "BTN_Cell6";
            this.BTN_Cell6.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell6.TabIndex = 13;
            this.BTN_Cell6.Tag = "32";
            this.BTN_Cell6.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell7
            // 
            this.BTN_Cell7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell7.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell7.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell7.Location = new System.Drawing.Point(408, 488);
            this.BTN_Cell7.Name = "BTN_Cell7";
            this.BTN_Cell7.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell7.TabIndex = 14;
            this.BTN_Cell7.Tag = "64";
            this.BTN_Cell7.UseVisualStyleBackColor = true;
            // 
            // BTN_Cell9
            // 
            this.BTN_Cell9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Cell9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cell9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Cell9.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cell9.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.BTN_Cell9.Location = new System.Drawing.Point(768, 488);
            this.BTN_Cell9.Name = "BTN_Cell9";
            this.BTN_Cell9.Size = new System.Drawing.Size(164, 164);
            this.BTN_Cell9.TabIndex = 15;
            this.BTN_Cell9.Tag = "256";
            this.BTN_Cell9.UseVisualStyleBackColor = true;
            // 
            // FRM_PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(971, 768);
            this.Controls.Add(this.BTN_Cell9);
            this.Controls.Add(this.BTN_Cell7);
            this.Controls.Add(this.BTN_Cell6);
            this.Controls.Add(this.BTN_Cell5);
            this.Controls.Add(this.BTN_Cell4);
            this.Controls.Add(this.BTN_Cell3);
            this.Controls.Add(this.BTN_Cell2);
            this.Controls.Add(this.BTN_Cell8);
            this.Controls.Add(this.BTN_Cell1);
            this.Controls.Add(this.BTN_Restart);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.LBL_WinnerValue);
            this.Controls.Add(this.LBL_Winner);
            this.Controls.Add(this.LBL_TurnValue);
            this.Controls.Add(this.LBL_Turn);
            this.Name = "FRM_PlayGround";
            this.Text = "Tic Tac Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_PlayGround_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Turn;
        private System.Windows.Forms.Label LBL_TurnValue;
        private System.Windows.Forms.Label LBL_Winner;
        private System.Windows.Forms.Label LBL_WinnerValue;
        private System.Windows.Forms.Button BTN_Restart;
        private System.Windows.Forms.Button BTN_Cell1;
        private System.Windows.Forms.Button BTN_Cell8;
        private System.Windows.Forms.Button BTN_Cell2;
        private System.Windows.Forms.Button BTN_Cell3;
        private System.Windows.Forms.Button BTN_Cell4;
        private System.Windows.Forms.Button BTN_Cell5;
        private System.Windows.Forms.Button BTN_Cell6;
        private System.Windows.Forms.Button BTN_Cell7;
        private System.Windows.Forms.Button BTN_Cell9;
    }
}

