
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainSettingsBtn
            // 
            this.mainSettingsBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.mainSettingsBtn.Location = new System.Drawing.Point(320, 236);
            this.mainSettingsBtn.Name = "mainSettingsBtn";
            this.mainSettingsBtn.Size = new System.Drawing.Size(155, 59);
            this.mainSettingsBtn.TabIndex = 0;
            this.mainSettingsBtn.Text = "Settings";
            this.mainSettingsBtn.UseVisualStyleBackColor = false;
            this.mainSettingsBtn.Click += new System.EventHandler(this.mainSettingsBtn_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.MediumPurple;
            this.btnProfile.Location = new System.Drawing.Point(320, 171);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(155, 59);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBack.Location = new System.Drawing.Point(320, 301);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 59);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.mainSettingsBtn);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainSettingsBtn;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBack;
    }
}