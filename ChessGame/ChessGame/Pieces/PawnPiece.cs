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
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_pawn");
                //chesspieceImage = Image.FromFile("../Images/white_pawn.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_pawn");
                //chesspieceImage = Image.FromFile("../Images/black_pawn.PNG");
            }
        }


        // METHODS
        public void pieceMove(PawnPiece pawn)
        {

        }

    }
}
