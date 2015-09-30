using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class PawnPiece : ChessPiece
    {

        // CONSTRUCTOR
        public PawnPiece(int color) : base (color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = Image.FromFile("../Images/white_pawn.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = Image.FromFile("../Images/black_pawn.PNG");
            }
        }


        // METHODS
        public void pieceMove(PawnPiece pawn)
        {

        }

    }
}
