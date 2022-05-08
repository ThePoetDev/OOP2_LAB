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
            for (int i = 0; i < board.Row; i++)
            {
                for (int j = 0; j < board.Col; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = btnSize;
                    btnGrid[i, j].Width = btnSize;
                    if (shapeColorList <= 2)
                    {
                        if (redColor && triangleShape)
                        {
                            if (random.Next(0, 5) < 3)
                            {
                                btnGrid[i, j].Image = Properties.Resources.RedTriangle;
                                btnGrid[i, j].Tag = i + "," + j + "," + "r,t";
                            }
                        }
                        if (greenColor && triangleShape)
                        {
                            if (random.Next(0, 7) < 3)
                            {
                                btnGrid[i, j].Image = Properties.Resources.GreenTriangle;
                                btnGrid[i, j].Tag = i + "," + j + "," + "g,t";
                            }
                        }
                        if (blueColor && triangleShape)
                        {
                            if (random.Next(0, 6) < 3)
                            {
                                btnGrid[i, j].Image = Properties.Resources.BlueTriangle;
                                btnGrid[i, j].Tag = i + "," + j + "," + "b,t";
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
            if (clickCounter % 2 == 1) { x = location.X; y = location.Y; currentCell = board.theGrid[x, y]; timer1.Start(); }
            if (clickCounter % 2 == 0)
            {
                x1 = location.X; y1 = location.Y; currentCell = board.theGrid[x1, y1]; timer1.Stop(); btnGrid[x1, y1].Image = btnGrid[x, y].Image; btnGrid[x, y].Image = null;
                int number = random.Next(1, 4);
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

                        if (number == 1)
                        {
                            if (btnGrid[row, col].Image == null)
                                btnGrid[row, col].Image = Resources.BlueTriangle;
                        }
                        else if (number == 2)
                        {
                            if (btnGrid[row, col].Image == null)
                                btnGrid[row, col].Image = Resources.RedTriangle;
                        }
                        else if (number == 3)
                        {
                            if (btnGrid[row, col].Image == null)
                                btnGrid[row, col].Image = Resources.GreenTriangle;
                        }
                        total++;
                    }
                }
            }
            timer1.Interval = 100;
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }
        //public void isWin()
        //{
        //    for (int i = 0; i < board.Row; i++)
        //    {
        //        for (int j = 0; j < board.Col; j++)
        //        {
        //            if (btnGrid[i, j].Image == btnGrid[i + 1, j].Image && btnGrid[i + 1, j].Image == btnGrid[i + 2, j].Image && btnGrid[i + 2, j].Image == btnGrid[i + 3, j].Image && btnGrid[i + 3, j].Image == btnGrid[i + 4, j].Image)
        //            {
        //                btnGrid[i, j].Image = null;
        //                btnGrid[i + 1, j].Image = null;
        //                btnGrid[i + 2, j].Image = null;
        //                btnGrid[i + 3, j].Image = null;
        //                btnGrid[i + 4, j].Image = null;
        //            }
        //            if (btnGrid[i, j].Image == btnGrid[i, j + 1].Image && btnGrid[i, j + 1].Image == btnGrid[i, j + 2].Image && btnGrid[i, j + 3].Image == btnGrid[i, j + 3].Image && btnGrid[i, j + 3].Image == btnGrid[i, j + 4].Image)
        //            {
        //            }
        //        }
        //    }
        //}
    }


}
