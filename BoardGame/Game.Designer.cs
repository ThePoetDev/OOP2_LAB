namespace BoardGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.GameBoard = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.txtBoxBestScore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoard
            // 
            this.GameBoard.BackColor = System.Drawing.Color.SkyBlue;
            this.GameBoard.ErrorImage = global::BoardGame.Properties.Resources.RedTriangle;
            this.GameBoard.Location = new System.Drawing.Point(9, 10);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(581, 630);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(680, 93);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(76, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(611, 96);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Location = new System.Drawing.Point(611, 142);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(65, 13);
            this.lblBestScore.TabIndex = 4;
            this.lblBestScore.Text = "Best Score: ";
            // 
            // txtBoxBestScore
            // 
            this.txtBoxBestScore.Location = new System.Drawing.Point(680, 139);
            this.txtBoxBestScore.Name = "txtBoxBestScore";
            this.txtBoxBestScore.Size = new System.Drawing.Size(76, 20);
            this.txtBoxBestScore.TabIndex = 5;
            this.txtBoxBestScore.Text = "0";
            this.txtBoxBestScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(785, 673);
            this.Controls.Add(this.txtBoxBestScore);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.GameBoard);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.TextBox txtBoxBestScore;
    }
}