using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BoardGame
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            List<string> user = new List<string>();
            List<string> admin = new List<string>();

            user.Add("user/user");
            admin.Add("admin/admin");

            string[] userInfo = user[0].Split('/');
            string[] adminInfo = admin[0].Split('/');
            if (rbtnAdmin.Checked && txtUsername.Text == adminInfo[0] && txtPassword.Text == adminInfo[1])
            {
                this.Visible = false;
                MainGame mainGame = new MainGame();
                mainGame.Show();
            }
            else if (rbtnUser.Checked && txtUsername.Text == userInfo[0] && txtPassword.Text == userInfo[1])
            {
                this.Visible = false;
                MainGame mainGame = new MainGame();
                mainGame.Show();
            }
            else
            {
                MessageBox.Show("User information not found. Please try again!");
            }
            txtUsername.Text = " ";
            txtPassword.Text = " ";
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}