using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class QueenPiece : ChessPiece
    {

        // CONSTRUCTOR
        public QueenPiece(int color) : base (color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = Image.FromFile("../Images/white_queen.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = Image.FromFile("../Images/black_queen.PNG");
            }
        }


        // METHODS
        public void pieceMove(QueenPiece queen)
        {

        }

    }
}
