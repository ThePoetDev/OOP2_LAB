using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame {
    public partial class Game : Form {
        private PictureBox[,] pictureBox;
        int rowLength = 0, colLength = 0;
        int left = 2, top = 2;
        int shapeSizeList = 0;
        bool isPlayerClickedCell = false;

        public Game() {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e) {
            var difLevel = BoardGame.Properties.Settings.Default.DifLevel;
            if (difLevel.Equals("Easy")) {
                int size = 15;
                pictureBox = new PictureBox[size, size];
                rowLength = size; colLength = size;
            } else if (difLevel.Equals("Medium")) {
                int size = 9;
                pictureBox = new PictureBox[size, size];
                rowLength = size; colLength = size;
            } else if (difLevel.Equals("Hard")) {
                int size = 6;
                pictureBox = new PictureBox[size, size];
                rowLength = size; colLength = size;
            } else if (difLevel.Equals("Custom")) {
                var row = BoardGame.Properties.Settings.Default.BorderX;
                var col = BoardGame.Properties.Settings.Default.BorderY;
                pictureBox = new PictureBox[Int32.Parse(row), Int32.Parse(col)];
                rowLength = Int32.Parse(row); colLength = Int32.Parse(col);
            }

            Random r = new Random();

            for (int i = 0; i < rowLength; i++) {
                left = 2;
                for (int j = 0; j < colLength; j++) {
                    pictureBox[i, j] = new PictureBox();
                    if (shapeSizeList <= 2) {
                        if (r.Next(0, 25) < 3) {
                            pictureBox[i, j].Image = Properties.Resources.RedTriangle;
                            pictureBox[i, j].Name = i + "," + j + "," +  "g,s";
                            shapeSizeList++;
                        }
                    }
                    pictureBox[i, j].Location = new Point(left, top);
                    pictureBox[i, j].Size = new Size(GameBoard.Width / colLength, GameBoard.Height / rowLength);
                    left += GameBoard.Width / colLength;
                    GameBoard.Controls.Add(pictureBox[i, j]);
                    pictureBox[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox[i, j].MouseClick += (sender2, e2) => {
                        PictureBox p = sender2 as PictureBox;
                        if (p.Image != null) {
                            if(p.BackColor == Color.SkyBlue && !isPlayerClickedCell) {
                                p.BackColor = Color.FromArgb(255, 64, 64, 64);
                                isPlayerClickedCell = true;
                            } else if(p.BackColor == Color.FromArgb(255, 64, 64, 64)) {
                                p.BackColor = Color.SkyBlue;
                                isPlayerClickedCell = false;
                            }
                        }
                    };

                }
                    top += GameBoard.Height / rowLength;
            }

        }


    }
}
