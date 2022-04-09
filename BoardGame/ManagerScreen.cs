using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BoardGame
{
    public partial class ManagerScreen : Form
    {
        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void btnListAllUsers_Click(object sender, EventArgs e) {
            loadData();
        }

        private void btnBringInfo_Click(object sender, EventArgs e) {
            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            String str = dataGridViewList.CurrentCell.Value.ToString();

            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == str);

            if (node != null) {
                this.txtboxUsername.Text = str;
                this.txtboxPassword.Text = (string)node.Element("Password");
                this.txtboxNameSurname.Text = (string)node.Element("Name-Surname");
                this.txtboxPhonenum.Text = (string)node.Element("PhoneNumber");
                this.txtboxAddress.Text = (string)node.Element("Address");
                this.txtboxCity.Text = (string)node.Element("City");
                this.txtboxCountry.Text = (string)node.Element("Country");
                this.txtboxEmail.Text = (string)node.Element("Email");
            } else {
                MessageBox.Show("Username couldn't find.");
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e) {
            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");

            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == txtboxUsername.Text);

            if(node != null) {
                MessageBox.Show("There's already such a user.");
                return;
            }

            xDoc.Element("Users").Add(
                new XElement("user",
                new XElement("type", "user"),
                new XElement("Username", txtboxUsername.Text),
                new XElement("Password", sha256_hash(this.txtboxPassword.Text)),
                new XElement("Name-Surname", txtboxNameSurname.Text),
                new XElement("PhoneNumber", txtboxPhonenum.Text),
                new XElement("Address", txtboxAddress.Text),
                new XElement("City", txtboxCity.Text),
                new XElement("Country", txtboxCountry.Text),
                new XElement("Email", txtboxEmail.Text)
                ));

            xDoc.Save(@"../../Veriler.xml");
            loadData();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == txtboxUsername.Text);

            if(node != null) {
                node.SetElementValue("Username", txtboxUsername.Text);
                node.SetElementValue("Name-Surname", txtboxNameSurname.Text);
                node.SetElementValue("PhoneNumber", txtboxPhonenum.Text);
                node.SetElementValue("Address", txtboxAddress.Text);
                node.SetElementValue("City", txtboxCity.Text);
                node.SetElementValue("Country", txtboxCountry.Text);
                node.SetElementValue("Email", txtboxEmail.Text);
                xDoc.Save(@"../../Veriler.xml");
                loadData();
            } else {
                MessageBox.Show("Username couldn't find.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {

            if(txtboxUsername.Text == "admin" || txtboxUsername.Text == "user") {
                MessageBox.Show("This account cannot be deleted.");
                return;
            }

            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            xDoc.Root.Elements().Where(data => data.Element("Username").Value == txtboxUsername.Text).Remove();
            xDoc.Save(@"../../Veriler.xml");
            loadData();
           
        }

        private void btnBack_Click(object sender, EventArgs e) {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }


        void loadData() {
            DataSet ds = new DataSet();
            XmlReader xmlReader = XmlReader.Create(@"../../Veriler.xml", new XmlReaderSettings());
            ds.ReadXml(xmlReader);
            dataGridViewList.DataSource = ds.Tables[0];
            xmlReader.Close();
        }


        public static String sha256_hash(String value) {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create()) {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
