using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FileStream fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamReader streamReader = new StreamReader(fileStream);

            if (streamReader.ReadLine() == null)
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write("Easy;NULL;NULL;NULL;NULL;NULL;NULL;0;0");
                streamWriter.Close();
            }
            streamReader.Close();
            fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            streamReader = new StreamReader(fileStream);
            String[] str = streamReader.ReadLine().Split(';');
            fileStream.Close();

            if (str[0] == "Easy")
            {
                this.easyRadioBtn.Checked = true;
            }
            else if (str[0] == "Medium")
            {
                this.medRadioBtn.Checked = true;
            }
            else if (str[0] == "Hard")
            {
                this.hardRadioBtn.Checked = true;
            }
            else if (str[0] == "Custom")
            {
                this.customRadioBtn.Checked = true;
            }

            if (str[1] != null)
            {
                if (str[1] == "Square")
                {
                    this.squareCheckBox.Checked = true;
                }
            }

            if (str[2] != null)
            {
                if (str[2] == "Circle")
                {
                    this.circleCheckBox.Checked = true;
                }
            }

            if (str[3] != null)
            {
                if (str[3] == "Triangle")
                {
                    this.triangleCheckBox.Checked = true;
                }
            }

            if (str[4] != null)
            {
                if (str[4] == "Red")
                {
                    this.redCheckbox.Checked = true;
                }
            }

            if (str[5] != null)
            {
                if (str[5] == "Green")
                {
                    this.greenCheckbox.Checked = true;
                }
            }

            if (str[6] != null)
            {
                if (str[6] == "Blue")
                {
                    this.blueCheckbox.Checked = true;
                }
            }

            if (str[7] != null)
            {
                this.borderTextboxX.Text = str[7];
            }

            if (str[8] != null)
            {
                this.borderTextboxY.Text = str[8];
            }


        }

        private void easyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.customPanel.Visible = false;
        }

        private void medRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.customPanel.Visible = false;
        }

        private void hardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.customPanel.Visible = false;
        }

        private void customRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.customPanel.Visible = true;
        }

        private void settingsSaveBtn_Click(object sender, EventArgs e)
        {
            var difficulty = this.difficultyPanel.Controls.OfType<RadioButton>().FirstOrDefault(r =>
            r.Checked);
            var squareStr = "";
            var circleStr = "";
            var triangleStr = "";
            var redStr = "";
            var greenStr = "";
            var blueStr = "";

            if (this.squareCheckBox.Checked)
            {
                squareStr = "Square";
            }
            else
            {
                squareStr = "NULL";
            }

            if (this.circleCheckBox.Checked)
            {
                circleStr = "Circle";
            }
            else
            {
                circleStr = "NULL";
            }

            if (this.triangleCheckBox.Checked)
            {
                triangleStr = "Triangle";
            }
            else
            {
                triangleStr = "NULL";
            }

            if (this.redCheckbox.Checked)
            {
                redStr = "Red";
            }
            else
            {
                redStr = "NULL";
            }

            if (this.greenCheckbox.Checked)
            {
                greenStr = "Green";
            }
            else
            {
                greenStr = "NULL";
            }

            if (this.blueCheckbox.Checked)
            {
                blueStr = "Blue";
            }
            else
            {
                blueStr = "NULL";
            }

            var x = this.borderTextboxX.Text;
            var y = this.borderTextboxY.Text;

            if (x == "")
            {
                x = "0";
            }

            if (y == "")
            {
                y = "0";
            }


            String save = difficulty.Text + ";" + squareStr + ";" + circleStr + ";" + triangleStr + ";" + redStr + ";" + greenStr + ";" + blueStr + ";" + x + ";" + y;

            FileStream fileStream2 = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.Open, FileAccess.Write, FileShare.None);
            StreamWriter streamWriter2 = new StreamWriter(fileStream2);
            streamWriter2.WriteLine(save);
            streamWriter2.Close();

            MessageBox.Show("Successfully saved!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

