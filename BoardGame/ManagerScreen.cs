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
using System.Data.SqlClient;

namespace BoardGame
{
    public partial class ManagerScreen : Form
    {

        static string connectionString = BoardGame.Properties.Settings.Default.BoardgameConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void btnListAllUsers_Click(object sender, EventArgs e) {
            reloadTable();
        }

        private void btnBringInfo_Click(object sender, EventArgs e) {
            if(dataGridViewList.CurrentRow == null) {
                MessageBox.Show("Please select row then use bring info button.");
                return;
            }
            txtboxUsername.Text = dataGridViewList.CurrentRow.Cells[1].Value.ToString();
            txtboxNameSurname.Text = dataGridViewList.CurrentRow.Cells[3].Value.ToString();
            txtboxPhonenum.Text = dataGridViewList.CurrentRow.Cells[4].Value.ToString();
            txtboxAddress.Text = dataGridViewList.CurrentRow.Cells[5].Value.ToString();
            txtboxCity.Text = dataGridViewList.CurrentRow.Cells[6].Value.ToString();
            txtboxCountry.Text = dataGridViewList.CurrentRow.Cells[7].Value.ToString();
            txtboxEmail.Text = dataGridViewList.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e) {
            try {
                if (sqlConnection.State == ConnectionState.Closed) {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(username) FROM Users WHERE username = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", txtboxUsername.Text);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader rdr = sqlCommand.ExecuteReader();

                while (rdr.Read()) {
                    if (rdr.GetInt32(0) >= 1) {
                        MessageBox.Show("There's already such a user.");
                        rdr.Close();
                        return;
                    }
                }

                rdr.Close();

                string registery = "INSERT INTO Users (username,password,name_surname,phone_number,address,city,country,email,admin) " +
                    "values(@username, @password, @name_surname, @phone_number, @address, @city, @country, @email, @admin)";

                sqlCommand = new SqlCommand(registery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", txtboxUsername.Text);
                sqlCommand.Parameters.AddWithValue("@password", sha256_hash(txtBoxPassword.Text));
                sqlCommand.Parameters.AddWithValue("@name_surname", txtboxNameSurname.Text);
                sqlCommand.Parameters.AddWithValue("@phone_number", txtboxPhonenum.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtboxAddress.Text);
                sqlCommand.Parameters.AddWithValue("@city", txtboxCity.Text);
                sqlCommand.Parameters.AddWithValue("@country", txtboxCountry.Text);
                sqlCommand.Parameters.AddWithValue("@email", txtboxEmail.Text);
                sqlCommand.Parameters.AddWithValue("@admin", "0");
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Signed up successfully");

                reloadTable();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            if (txtboxUsername.Text.Equals("user") || txtboxUsername.Text.Equals("admin")) {
                MessageBox.Show("You cannot edit this account.");
                return;
            }


            try {
                if (sqlConnection.State == ConnectionState.Closed) {
                    sqlConnection.Open();
                }


                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(username) FROM Users WHERE username = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", txtboxUsername.Text);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader rdr = sqlCommand.ExecuteReader();

                while (rdr.Read()) {
                    if (rdr.GetInt32(0) == 0) {
                        MessageBox.Show("There's no such a user.");
                        rdr.Close();
                        return;
                    }
                }

                rdr.Close();

                sqlCommand = new SqlCommand("UPDATE Users SET name_surname = @name_surname,phone_number = @phone_number,address = @address,city = @city,country = @country,email = @email WHERE username = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", txtboxUsername.Text);
                sqlCommand.Parameters.AddWithValue("@name_surname", txtboxNameSurname.Text);
                sqlCommand.Parameters.AddWithValue("@phone_number", txtboxPhonenum.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtboxAddress.Text);
                sqlCommand.Parameters.AddWithValue("@city", txtboxCity.Text);
                sqlCommand.Parameters.AddWithValue("@country", txtboxCountry.Text);
                sqlCommand.Parameters.AddWithValue("@email", txtboxEmail.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                reloadTable();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {
            if (dataGridViewList.CurrentRow == null) {
                MessageBox.Show("Please select row then use bring info button.");
                return;
            }

            if (dataGridViewList.CurrentRow.Cells[1].Value.ToString().Equals("user") || dataGridViewList.CurrentRow.Cells[1].Value.ToString().Equals("admin")) {
                MessageBox.Show("You cannot delete this account.");
                return;
            }


            try {
                if (sqlConnection.State == ConnectionState.Closed) {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Users WHERE username = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", dataGridViewList.CurrentRow.Cells[1].Value.ToString());
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                reloadTable();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e) {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
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

        public void reloadTable() {
            try {
                if (sqlConnection.State == ConnectionState.Closed) {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.dataGridViewList.DataSource = dataTable;
                sqlConnection.Close();
                this.txtBoxPassword.Text = "";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
