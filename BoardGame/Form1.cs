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

namespace BoardGame
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        bool found = false;
        void load()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"Veriler.xml", new XmlReaderSettings());
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
            bool found = false;
            for (int i = 0; i < nameList.Count; i++)
            {
                for (int j = 0; j < passList.Count; j++)
                {

                    if (nameList[i].InnerText == txtUsername.Text && txtPassword.Text == passList[j].InnerText)
                    {
                        this.Visible = false;
                        MainGame mainGame = new MainGame();
                        mainGame.Show();
                        found = true;
                        break;
                    }
                    else if (nameList[i].InnerText != txtUsername.Text && txtPassword.Text != passList[j].InnerText)
                    {
                        continue;
                    }
                }
            }
            if (found == true)
            {
                FileStream fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "girisbilgileri.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(txtUsername.Text + ";" + txtPassword.Text);

            }
   
            if (found == false)
            {
                MessageBox.Show("User information is not found. Please try again!");
            }
            //txtUsername.Text = "";
            //txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            if (found == true)
            {
                FileStream fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "girisbilgileri.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                StreamReader streamReader = new StreamReader(fileStream);
                String[] str = streamReader.ReadLine().Split(';');

                this.txtUsername.Text = str[0];
                this.txtPassword.Text = str[1];
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