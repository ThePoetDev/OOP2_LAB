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
using System.Security.Cryptography;
using System.Xml.XPath;

namespace BoardGame
{
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void btnSign_Click(object sender, EventArgs e)
        {
            if(this.txtUsername.Text == "" && this.txtPassword.Text == "") {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }

            XDocument xml = XDocument.Load(@"../../Veriler.xml");
            var sha = SHA256.Create();
            var passwrd = txtPassword.Text;
            string hashCode = Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(passwrd)));

            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == txtUsername.Text);

            if (node != null) {
                MessageBox.Show("There's already such a user.");
                return;
            }

            xml.Element("Users").Add(
                new XElement("user",
                new XElement("type","user"),
                new XElement("Username", txtUsername.Text),
                new XElement("Password", hashCode),
                new XElement("Name-Surname", txtNameSurname.Text),
                new XElement("PhoneNumber", txtPnumber.Text),
                new XElement("Address", txtAddress.Text),
                new XElement("City", txtCity.Text),
                new XElement("Country", txtCountry.Text),
                new XElement("Email", txtMail.Text)
                ));
            //foreach (XElement element in x.XPathSelectElement("//user").Descendants())
            //{
            //    string value = element.Value;
            //}
            xml.Save(@"../../Veriler.xml");
            load();
            MessageBox.Show("Signed up successfully");
            this.Visible = false;
            LogIn login = new LogIn();
            login.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            load();
            this.AcceptButton = btnSign;
        }
    }
}
