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
            xmlFile = XmlReader.Create(@"Veriler.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            xmlFile.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"Veriler.xml");
            x.Element("Users").Add(
                new XElement("user",
                new XElement("Username", txtUsername.Text),
                new XElement("Password", txtPassword.Text),
                new XElement("Name-Surname", txtNameSurname.Text),
                new XElement("PhoneNumber", txtPnumber.Text),
                new XElement("Address", txtAddress.Text),
                new XElement("City", txtCity.Text),
                new XElement("Country", txtCountry.Text),
                new XElement("Email", txtMail.Text)
                ));
            x.Save(@"Veriler.xml");
            load();
            MessageBox.Show("Signed up successfully");
            this.Visible = false;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
