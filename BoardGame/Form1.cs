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

            user.Add("user/user");
            user.Add("admin/admin");
            user.Add("atesogluf/absfbhc");
            user.Add("thepoetdev/122425");
            user.Add("apple/12345");
            foreach (var users in user)
            {
                user.ToList();
            }
            for (int i = 0; i < user.Count; i++)
            {
                string[] userInfo = user[i].Split('/');
                if (txtUsername.Text == userInfo[0] && txtPassword.Text == userInfo[1])
                {
                    this.Visible = false;
                    MainGame mainGame = new MainGame();
                    mainGame.Show();
                    break;
                   
                }
                else if((user.Count-1)==i)
                {
                    MessageBox.Show("User information not found. Please try again!");
                    txtUsername.Select();
                }
                else if(txtUsername.Text != userInfo[0] && txtPassword.Text != userInfo[1])
                {
                    continue;
                }
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}