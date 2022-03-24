
namespace BoardGame
{
    partial class LogIn
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(93, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(96, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(99, 206);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(78, 17);
            this.lblUserType.TabIndex = 2;
            this.lblUserType.Text = "User Type:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(211, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(211, 206);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbtnAdmin.TabIndex = 5;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(211, 243);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(59, 21);
            this.rbtnUser.TabIndex = 6;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(273, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 42);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LogIn";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.Button btnLogin;
    }
}

