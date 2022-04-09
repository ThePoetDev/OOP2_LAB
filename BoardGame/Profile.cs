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
using System.Xml.Linq;

namespace BoardGame {
    public partial class Profile : Form {
        public Profile() {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e) {
            String username = BoardGame.Properties.Settings.Default.UserName;
            this.txtboxUsername.Text = username;

            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == txtboxUsername.Text);

            if (node != null) {
                this.txtboxNameSurname.Text = (string)node.Element("Name-Surname");
                this.txtboxPhoneNumber.Text = (string)node.Element("PhoneNumber");
                this.txtboxAddress.Text = (string)node.Element("Address");
                this.txtboxCity.Text = (string)node.Element("City");
                this.txtboxCountry.Text = (string)node.Element("Country");
                this.txtboxEmail.Text = (string)node.Element("Email");
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            MainGame mainGame = new MainGame();
            mainGame.Show();
        }

        private void btnSave_Click(object sender, EventArgs e) {

            XDocument xDoc = XDocument.Load(@"../../Veriler.xml");
            XElement node = xDoc.Element("Users").Elements("user").FirstOrDefault(data => data.Element("Username").Value == txtboxUsername.Text);

            if ((string) node.Element("Password") != sha256_hash(this.txtboxPassword.Text)){
                MessageBox.Show("Password is incorrect.");
                return;
            }

            if (node != null) {
                node.SetElementValue("Username", txtboxUsername.Text);
                node.SetElementValue("Password", sha256_hash(txtboxPassword.Text));
                node.SetElementValue("Name-Surname", txtboxNameSurname.Text);
                node.SetElementValue("PhoneNumber", txtboxPhoneNumber.Text);
                node.SetElementValue("Address", txtboxAddress.Text);
                node.SetElementValue("City", txtboxCity.Text);
                node.SetElementValue("Country", txtboxCountry.Text);
                node.SetElementValue("Email", txtboxEmail.Text);
                xDoc.Save(@"../../Veriler.xml");
            }
            MessageBox.Show("Saved successfully");
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
