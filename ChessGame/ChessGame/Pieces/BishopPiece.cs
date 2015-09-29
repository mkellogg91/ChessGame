using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    class BishopPiece : ChessPiece
    {

        // CONSTRUCTOR
        public BishopPiece(int color) : base (color)
        {
            


                //DETERMINE PIECE IMAGE
            if (pieceColor == '0')   // IF WHITE PIECE
            {
                chesspieceImage = Image.FromFile("../Images/white_bishop.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = Image.FromFile("../Images/black_bishop.PNG");
            }
        }


        // METHODS
        public void pieceMove(BishopPiece bishop)
        {
            


        }

        


    }
}
