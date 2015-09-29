using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessGame
{
    public class ChessPiece
    {

        // PROPERTIES

        public Image chesspieceImage { get; set; }
        public int pieceColor { get; set; }         // 0 = WHITE    1 = BLACK

        
        // CONSTRUCTOR!!!           TAKES A COLOR PARAMETER
        public ChessPiece(int color)
        {
            pieceColor = color;
        }

        // METHODS

            // set up a piece move property
        public void pieceMove(ChessPiece piece)
        {

        }


        

    }
}
