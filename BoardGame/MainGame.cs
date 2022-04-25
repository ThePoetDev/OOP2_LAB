using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void mainSettingsBtn_Click(object sender, EventArgs e) {
            Settings settings = new Settings();
            settings.Show();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
        }

        private void btnProfile_Click(object sender, EventArgs e) {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e) {
            this.Enabled = false;
            Credits credits = new Credits();
            credits.Show();
        }
    }
}
