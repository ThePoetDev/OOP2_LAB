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

namespace BoardGame {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            FileStream fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamReader streamReader = new StreamReader(fileStream);

            if(streamReader.ReadLine() == null) {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write("Easy;Square;0;0");
                streamWriter.Close();
            }
            streamReader.Close();
            fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            streamReader = new StreamReader(fileStream);
            String[] str = streamReader.ReadLine().Split(';');
            fileStream.Close();

            if (str[0] == "Easy") {
                this.easyRadioBtn.Checked = true;
            }else if(str[0] == "Medium") {
                this.medRadioBtn.Checked = true;
            }else if(str[0] == "Hard") {
                this.hardRadioBtn.Checked = true;
            }else if(str[0] == "Custom") {
                this.customRadioBtn.Checked = true;
            }

            if (str[2] != null) {
                this.borderTextboxX.Text = str[2];
            }

            if (str[3] != null) {
                this.borderTextboxY.Text = str[3];
            }

            if (str[1] == "Square") {
                this.squareRadioBtn.Checked = true;
            }else if(str[1] == "Triangle") {
                this.triangleRadioBtn.Checked = true;
            }else if(str[1] == "Circle") {
                this.circleRadioBtn.Checked = true;
            }
        }

        private void easyRadioBtn_CheckedChanged(object sender, EventArgs e) {
            this.customPanel.Visible = false;
        }

        private void medRadioBtn_CheckedChanged(object sender, EventArgs e) {
            this.customPanel.Visible = false;
        }

        private void hardRadioBtn_CheckedChanged(object sender, EventArgs e) {
            this.customPanel.Visible = false;
        }

        private void customRadioBtn_CheckedChanged(object sender, EventArgs e) {
            this.customPanel.Visible = true;
        }

        private void squareRadioBtn_CheckedChanged(object sender, EventArgs e) {

        }

        private void triangleRadioBtn_CheckedChanged(object sender, EventArgs e) {

        }

        private void circleRadioBtn_CheckedChanged(object sender, EventArgs e) {

        }

        private void settingsSaveBtn_Click(object sender, EventArgs e) {
            var difficulty = this.difficultyPanel.Controls.OfType<RadioButton>().FirstOrDefault(r =>
            r.Checked);
            var shape = this.shapePanel.Controls.OfType<RadioButton>().FirstOrDefault(r =>
            r.Checked);

            var x = this.borderTextboxX.Text;
            var y = this.borderTextboxY.Text;

            String save = difficulty.Text + ";" + shape.Text + ";" + x + ";" + y;

            FileStream fileStream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "settings.txt", FileMode.Open, FileAccess.Write, FileShare.None);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(save);
            streamWriter.Close();

            MessageBox.Show("Successfully saved!");
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Visible = false;
            MainGame mainGame = new MainGame();
            mainGame.Show();
        }
    }
}
