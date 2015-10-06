using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace ChessGame
{
    public class KingPiece : ChessPiece
    {

        // CONSTRUCTOR
        public KingPiece(int color) : base (color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                //chesspieceImage = Image.FromFile(@"~../Images/black_king.PNG");
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_king");

            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_king");
                //chesspieceImage = Image.FromFile(@"~../Images/black_king.PNG");
            }
        }

        // METHODS
        public void pieceMove(ChessboardSquare previousChessSquare, ChessboardSquare newChessSquare)
        {

        }
            // displays potential moves
        public void displayPotentialMove(ChessboardSquare chessSquare)
        {

        }

    }
}
