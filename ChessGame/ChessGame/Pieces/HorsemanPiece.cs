using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class HorsemanPiece : ChessPiece
    {

        // CONSTRUCTOR
        public HorsemanPiece(int color) : base (color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_horse");
                //chesspieceImage = Image.FromFile("../Images/white_horse.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_horse");
                //chesspieceImage = Image.FromFile("../Images/black_horse.PNG");
            }
        }


        // METHODS
        public void pieceMove(HorsemanPiece horseman)
        {

        }

        public void validateMove(/*move argument*/)
        {

        }

    }
}
