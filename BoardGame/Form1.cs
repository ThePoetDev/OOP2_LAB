using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Xml.XPath;

namespace BoardGame
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        void load()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"../../Veriler.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            xmlFile.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"Veriler.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            x.Load("Veriler.xml");
            XmlNodeList nameList = x.GetElementsByTagName("Username");
            XmlNodeList passList = x.GetElementsByTagName("Password");
            XmlNodeList typeList = x.GetElementsByTagName("type");
            var shaTmp1 = SHA256.Create();
            var passwrd = passList[0].InnerText;
            string hashCode1 = Convert.ToBase64String(shaTmp1.ComputeHash(Encoding.Unicode.GetBytes(passwrd)));
            passList[0].InnerText = hashCode1;
            var shaTmp2 = SHA256.Create();
            var passwrd2 = passList[1].InnerText;
            string hashCode2 = Convert.ToBase64String(shaTmp2.ComputeHash(Encoding.Unicode.GetBytes(passwrd2)));
            passList[1].InnerText = hashCode2;
            bool found = false;
            for (int i = 0; i < nameList.Count; i++)
            {
                var sha = SHA256.Create();
                var password = txtPassword.Text;
                string hashCode = Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(password)));
                if (nameList[i].InnerText == txtUsername.Text && hashCode == passList[i].InnerText)
                {
                    if (typeList[i].InnerText == "admin")
                    {
                        this.Visible = false;
                        ManagerScreen manager = new ManagerScreen();
                        manager.Show();
                        found = true;
                        break;
                    }
                    else
                    {
                        this.Visible = false;
                        MainGame mainGame = new MainGame();
                        mainGame.Show();
                        found = true;
                        break;
                    }
                }
                else if (nameList[i].InnerText != txtUsername.Text && hashCode != passList[i].InnerText)
                {
                    continue;
                }
            }
            if (found == true)
            {
               BoardGame.Properties.Settings.Default.UserName = txtUsername.Text;
               BoardGame.Properties.Settings.Default.Save();
            }
   
            if (found == false)
            {
                BoardGame.Properties.Settings.Default.UserName = "";
                BoardGame.Properties.Settings.Default.Save();
                MessageBox.Show("User information is not found. Please try again!");
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            load();
            this.AcceptButton = btnLogin;
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signUp = new SignUp();
            signUp.Show();
        }
        private void LogIn_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void chckPassShown_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPassShown.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}