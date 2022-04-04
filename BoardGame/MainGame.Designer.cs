
namespace BoardGame
{
    partial class MainGame
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
            this.mainSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainSettingsBtn
            // 
            this.mainSettingsBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.mainSettingsBtn.Location = new System.Drawing.Point(427, 366);
            this.mainSettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mainSettingsBtn.Name = "mainSettingsBtn";
            this.mainSettingsBtn.Size = new System.Drawing.Size(207, 73);
            this.mainSettingsBtn.TabIndex = 0;
            this.mainSettingsBtn.Text = "Settings";
            this.mainSettingsBtn.UseVisualStyleBackColor = false;
            this.mainSettingsBtn.Click += new System.EventHandler(this.mainSettingsBtn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainSettingsBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainSettingsBtn;
    }
}