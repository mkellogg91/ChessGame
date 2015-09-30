using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
                string test = Environment.CurrentDirectory;
                chesspieceImage = Image.FromFile(@"C:\Users\Mike\Pictures\chess_pieces\white_king.PNG");
                
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = Image.FromFile(@"../Images/black_king.PNG");
            }
        }

        // METHODS
        public void pieceMove(KingPiece king)
        {

        }

    }
}
