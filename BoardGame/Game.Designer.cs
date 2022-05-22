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
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoard
            // 
            this.GameBoard.BackColor = System.Drawing.Color.SkyBlue;
            this.GameBoard.ErrorImage = global::BoardGame.Properties.Resources.RedTriangle;
            this.GameBoard.Location = new System.Drawing.Point(12, 12);
            this.GameBoard.Margin = new System.Windows.Forms.Padding(4);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(775, 775);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(907, 114);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(852, 114);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1047, 828);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.GameBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Game";
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
    }
}