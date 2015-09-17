using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    class ChessboardSquare
    {

        // POSITION PROPERTIES
        int squarePos_x { get; set; }
        int squarePos_y { get; set; }
        int squareSize_x { get; set; }
        int squareSize_y { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A COLOR
        string squareColor { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A CHESSPEICE OBJECT
        ChessPiece squareChessPiece { get; set; }


        // ACTUAL VISUAL REPRESENTATION OF CHESSBOARD SQUARE
        PictureBox squarePictureBox { get; set; }

    }
}
