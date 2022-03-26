
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
            this.mainSettingsBtn.Location = new System.Drawing.Point(320, 297);
            this.mainSettingsBtn.Name = "mainSettingsBtn";
            this.mainSettingsBtn.Size = new System.Drawing.Size(155, 59);
            this.mainSettingsBtn.TabIndex = 0;
            this.mainSettingsBtn.Text = "Settings";
            this.mainSettingsBtn.UseVisualStyleBackColor = true;
            this.mainSettingsBtn.Click += new System.EventHandler(this.mainSettingsBtn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainSettingsBtn);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainSettingsBtn;
    }
}