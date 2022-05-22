using BoardGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Game : Form
    {
        static Board board = new Board(30, 30);
        public Button[,] btnGrid = new Button[board.Row, board.Col];
        Random random = new Random();

        public Game()
        {
            InitializeComponent();
            populateGrid();
        }
        private void populateGrid()
        {
            var redColor = BoardGame.Properties.Settings.Default.ColorRed;
            var greenColor = BoardGame.Properties.Settings.Default.ColorGreen;
            var blueColor = BoardGame.Properties.Settings.Default.ColorBlue;
            var squareShape = BoardGame.Properties.Settings.Default.ShapeSquare;
            var triangleShape = BoardGame.Properties.Settings.Default.ShapeTriangle;
            var circleShape = BoardGame.Properties.Settings.Default.ShapeCircle;
            var difLevel = BoardGame.Properties.Settings.Default.DifLevel;
            if (difLevel.Equals("Easy"))
            {
                int size = 15;
                board = new Board(size, size);
            }
            else if (difLevel.Equals("Medium"))
            {
                int size = 9;
                board = new Board(size, size);
            }
            else if (difLevel.Equals("Hard"))
            {
                int size = 6;
                board = new Board(size, size);
            }
            else if (difLevel.Equals("Custom"))
            {
                var row = BoardGame.Properties.Settings.Default.BorderX;
                var col = BoardGame.Properties.Settings.Default.BorderY;
                board = new Board(Int32.Parse(row), Int32.Parse(col));
            }
            int shapeColorList = 0;
            int btnSize = GameBoard.Width / board.Row;
            GameBoard.Width = GameBoard.Height;
            int colors = 1;
            if (triangleShape) colors++;
            if (circleShape) colors++;
            if (squareShape) colors++;
            int colorSize = random.Next(1, colors);
            for (int i = 0; i < board.Row; i++)
            {
                for (int j = 0; j < board.Col; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = btnSize;
                    btnGrid[i, j].Width = btnSize;
                    if (shapeColorList <= 2)
                    {
                        if (triangleShape && colorSize == 1)
                        {
                            if (redColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.RedTriangle;
                                    btnGrid[i, j].Image.Tag = "RedTriangle";
                                }
                            }

                            if (greenColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.GreenTriangle;
                                    btnGrid[i, j].Image.Tag = "GreenTriangle";
                                }
                            }

                            if (blueColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.BlueTriangle;
                                    btnGrid[i, j].Image.Tag = "BlueTriangle";
                                }
                            }

                        }

                        if (circleShape && colorSize == 2)
                        {
                            if (redColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.RedCircle;
                                    btnGrid[i, j].Image.Tag = "RedCircle";
                                }
                            }

                            if (greenColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.GreenCircle;
                                    btnGrid[i, j].Image.Tag = "GreenCircle";
                                }
                            }

                            if (blueColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.BlueCircle;
                                    btnGrid[i, j].Image.Tag = "BlueCircle";
                                }
                            }
                        }

                        if (squareShape && colorSize == 3)
                        {
                            if (redColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.RedSquare;
                                    btnGrid[i, j].Image.Tag = "RedSquare";
                                }
                            }

                            if (greenColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.GreenSquare;
                                    btnGrid[i, j].Image.Tag = "GreenSquare";
                                }
                            }

                            if (blueColor)
                            {
                                if (random.Next(0, 5) < 3)
                                {
                                    btnGrid[i, j].Image = Properties.Resources.BlueSquare;
                                    btnGrid[i, j].Image.Tag = "BlueSquare";
                                }
                            }
                        }
                        shapeColorList++;
                    }
                    btnGrid[i, j].Click += Grid_Button_Click;
                    GameBoard.Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(i * btnSize, j * btnSize);
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }
        static int x = 0;
        static int y = 0;
        static int x1 = 0;
        static int y1 = 0;
        static Cell currentCell;
        int clickCounter = 0;
        static int total = 3;

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            clickCounter++;

            if (clickCounter % 2 == 1) { x = location.X; y = location.Y; currentCell = board.theGrid[x, y]; /*timer1.Start(); */}
            if (clickCounter % 2 == 0)
            {
                if (btnGrid[currentCell.RowNumber, currentCell.ColNumber].Image == null)
                {
                    return;
                }
                x1 = location.X; y1 = location.Y; currentCell = board.theGrid[x1, y1]; /*timer1.Stop()*/;
                if (btnGrid[x1, y1].Image == null)
                {
                    btnGrid[x1, y1].Image = btnGrid[x, y].Image;
                    btnGrid[x, y].Image = null;
                    isWin();
                }
                else
                {
                    return;
                }
                int number = random.Next(1, 4);
                int chance = random.Next(1, 4);
                if (total != board.Row * board.Col)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int row = 0;
                        int col = 0;
                        do
                        {
                            row = random.Next(0, board.Row);
                            col = random.Next(0, board.Col);
                        }
                        while (row == x1 && col == y1);

                        if (Properties.Settings.Default.ShapeTriangle && number == 1)
                        {
                            if (btnGrid[row, col].Image == null)
                            {
                                if (chance == 1)
                                {
                                    btnGrid[row, col].Image = Resources.RedTriangle;
                                    btnGrid[row, col].Image.Tag = "RedTriangle";
                                    total++;
                                }
                                else if (chance == 2)
                                {
                                    btnGrid[row, col].Image = Resources.GreenTriangle;
                                    btnGrid[row, col].Image.Tag = "GreenTriangle";
                                    total++;
                                }
                                else if (chance == 3)
                                {
                                    btnGrid[row, col].Image = Resources.BlueTriangle;
                                    btnGrid[row, col].Image.Tag = "BlueTriangle";
                                    total++;
                                }
                            }
                        }
                        if (Properties.Settings.Default.ShapeSquare && number == 2)
                        {
                            if (btnGrid[row, col].Image == null)
                            {
                                if (chance == 1)
                                {
                                    btnGrid[row, col].Image = Resources.RedSquare;
                                    btnGrid[row, col].Image.Tag = "RedSquare";
                                    total++;
                                }
                                else if (chance == 2)
                                {
                                    btnGrid[row, col].Image = Resources.GreenSquare;
                                    btnGrid[row, col].Image.Tag = "GreenSquare";
                                    total++;
                                }
                                else if (chance == 3)
                                {
                                    btnGrid[row, col].Image = Resources.BlueSquare;
                                    btnGrid[row, col].Image.Tag = "BlueSquare";
                                    total++;
                                }
                            }
                        }
                        if (Properties.Settings.Default.ShapeCircle && number == 3)
                        {
                            if (btnGrid[row, col].Image == null)
                            {
                                if (chance == 1)
                                {
                                    btnGrid[row, col].Image = Resources.RedCircle;
                                    btnGrid[row, col].Image.Tag = "RedCircle";
                                    total++;
                                }
                                else if (chance == 2)
                                {
                                    btnGrid[row, col].Image = Resources.GreenCircle;
                                    btnGrid[row, col].Image.Tag = "GreenCircle";
                                    total++;
                                }
                                else if (chance == 3)
                                {
                                    btnGrid[row, col].Image = Resources.BlueCircle;
                                    btnGrid[row, col].Image.Tag = "BlueCircle";
                                    total++;
                                }
                            }
                        }
                    }
                }
            }
            //timer1.Interval = 100;
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }
        public void isWin()
        {
            int counter = 0;
            for (int i = 0; i < board.Row; i++)
            {
                for(int j = 0; j < board.Col; j++)
                {
                    if (j + 4 != board.Row && j + 4 < board.Row)
                    {
                        if (btnGrid[i, j].Image != null && btnGrid[i, j + 1].Image != null && btnGrid[i, j+ 2].Image != null && btnGrid[i, j + 3].Image != null && btnGrid[i, j + 4].Image != null)
                        {
                            if (btnGrid[i, j].Image.Tag == btnGrid[i, j + 1].Image.Tag && btnGrid[i, j + 1].Image.Tag == btnGrid[i, j + 2].Image.Tag && btnGrid[i, j + 2].Image.Tag == btnGrid[i, j + 3].Image.Tag && btnGrid[i, j + 3].Image.Tag == btnGrid[i, j + 4].Image.Tag)
                            {
                                btnGrid[i, j].Image = null;
                                btnGrid[i, j + 1].Image = null;
                                btnGrid[i, j + 2].Image = null;
                                btnGrid[i, j + 3].Image = null;
                                btnGrid[i, j + 4].Image = null;
                                counter++;
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < board.Row; i++)
            {
                for (int j = 0; j < board.Col; j++)
                {
                    if (i + 4 != board.Row && i + 4 < board.Row)
                    {
                        if (btnGrid[i, j].Image != null && btnGrid[i+1, j].Image != null && btnGrid[i+2, j].Image != null && btnGrid[i+3, j].Image != null && btnGrid[i+4, j].Image != null)
                        {
                            if (btnGrid[i, j].Image.Tag == btnGrid[i+1, j].Image.Tag && btnGrid[i+1, j].Image.Tag == btnGrid[i+2, j].Image.Tag && btnGrid[i+2, j].Image.Tag == btnGrid[i+3, j].Image.Tag && btnGrid[i+3, j].Image.Tag == btnGrid[i+4, j ].Image.Tag)
                            {
                                btnGrid[i, j].Image = null;
                                btnGrid[i+1, j].Image = null;
                                btnGrid[i+2, j].Image = null;
                                btnGrid[i+3, j].Image = null;
                                btnGrid[i+4, j].Image = null;
                                counter++;
                                break;
                            }
                        }
                    }
                }
            }
            string difLevel = BoardGame.Properties.Settings.Default.DifLevel;
            if (difLevel.Equals("Easy")){
                this.txtScore.Text = (Int32.Parse(this.txtScore.Text) + counter).ToString();
            }
            else if (difLevel.Equals("Medium"))
            {
                this.txtScore.Text = (Int32.Parse(this.txtScore.Text) + counter*3).ToString();
            }
            else if (difLevel.Equals("Hard"))
            {
                this.txtScore.Text = (Int32.Parse(this.txtScore.Text) + counter * 5).ToString();
            }

        }
        //public void checkWinner()
        //{
        //    for (int i = 0; i < board.Row - 4; i++)
        //    {
        //        for (int j = 0; j < board.Col - 4; j++)
        //        {
        //            if (btnGrid[i, j].Image == null || btnGrid[i + 1, j].Image == null || btnGrid[i + 2, j].Image == null ||
        //                                btnGrid[i + 3, j].Image == null || btnGrid[i + 4, j].Image == null) continue;
        //            if (btnGrid[i, j].Image.Tag == btnGrid[i + 1, j].Image.Tag && btnGrid[i, j].Image.Tag == btnGrid[i + 2, j].Image.Tag && btnGrid[i, j].Image.Tag == btnGrid[i + 3, j].Image.Tag && btnGrid[i, j].Image.Tag == btnGrid[i + 4, j].Image.Tag)
        //            {
        //                btnGrid[i, j].Image = null;
        //                btnGrid[i + 1, j].Image = null;
        //                btnGrid[i + 2, j].Image = null;
        //                btnGrid[i + 3, j].Image = null;
        //                btnGrid[i + 4, j].Image = null;
        //            }
        //            if (btnGrid[i, j].Image.Tag == btnGrid[i, j + 1].Image.Tag && btnGrid[i, j + 1].Image.Tag == btnGrid[i, j + 2].Image.Tag && btnGrid[i, j + 3].Image.Tag == btnGrid[i, j + 3].Image.Tag && btnGrid[i, j + 3].Image.Tag == btnGrid[i, j + 4].Image.Tag)
        //            {
        //                btnGrid[i, j].Image = null;
        //                btnGrid[i, j + 1].Image = null;
        //                btnGrid[i, j + 2].Image = null;
        //                btnGrid[i, j + 3].Image = null;
        //                btnGrid[i, j + 4].Image = null;

        //            }
        //        }
        //    }
        //}
    }
}
