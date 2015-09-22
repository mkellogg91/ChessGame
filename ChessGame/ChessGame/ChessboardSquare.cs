using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessGame
{
    class ChessboardSquare
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
        public Size pictureBoxSize = new Size(100, 100);
        Color redColor = Color.FromArgb(255, 0, 0);

        // ACTUAL VISUAL REPRESENTATION OF CHESSBOARD SQUARE
        public PictureBox squarePictureBox { get; set; }

        // CONSTRUCTOR
        public ChessboardSquare()
        {
            squarePictureBox = new PictureBox();
            squarePictureBox.Size = pictureBoxSize;
            squarePictureBox.BackColor = redColor;

        }

    }
}
