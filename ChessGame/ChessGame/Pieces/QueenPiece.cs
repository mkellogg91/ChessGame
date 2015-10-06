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
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_queen");
                //chesspieceImage = Image.FromFile("../Images/white_queen.PNG");

            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_queen");
                //chesspieceImage = Image.FromFile("../Images/black_queen.PNG");
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
