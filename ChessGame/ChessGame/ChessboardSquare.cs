using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessGame
{
    public class ChessboardSquare
    {

        // POSITION PROPERTIES
        public int squarePos_x { get; set; }
        public int squarePos_y { get; set; }
        public int squareSize_x { get; set; }
        public int squareSize_y { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A COLOR
        public string squareColor { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A CHESSPEICE OBJECT
        public ChessPiece squareChessPiece { get; set; }
        public Size pictureBoxSize { get; set; }
        public Point point { get; set; }

        // ACTUAL VISUAL REPRESENTATION OF CHESSBOARD SQUARE
        public PictureBox squarePictureBox { get; set; }

        //temporary
        public Button buttonTest { get; set; }

        // CONSTRUCTOR
        public ChessboardSquare()
        {

            squarePictureBox = new PictureBox();
            Initialize(10, 10);

        }

        // OVERLOAD CONSTRUCTOR FOR POSITION VALUES
        public ChessboardSquare(int x, int y)
        {
            squarePictureBox = new PictureBox();
            Initialize(x, y);

        }

        public void Initialize(int x, int y)
        {

            pictureBoxSize = new Size(100, 100);

            point = new Point(x, y);

            squarePictureBox.Size = pictureBoxSize;
            squarePictureBox.BackColor = Color.White;
            squarePictureBox.BorderStyle = BorderStyle.FixedSingle;
        }






    }
}
