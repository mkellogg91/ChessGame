using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class RookPiece : ChessPiece
    {
        // CONSTRUCTOR
        public RookPiece(int color) : base(color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_rook");
                //chesspieceImage = Image.FromFile("../Images/white_rook.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_rook");
                //chesspieceImage = Image.FromFile("../Images/black_rook.PNG");
            }
        }

        // PROPERTIES



        // METHODS
        public void pieceMove(ChessboardSquare previousChessSquare, ChessboardSquare newChessSquare)
        {

        }


        public override List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {

            List<Point> potentialMoveList = new List<Point>();

            Point movePoint;

                //will never have to move more than 8 spaces
                for (int iterator = 1; iterator < 8; iterator++)
                {
                    //add upmove
                    movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);

                    //add downmove
                    movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);


                    //add leftmove
                    movePoint = leftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);

                    //add rightmove
                    movePoint = rightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);

                }

            return potentialMoveList;

        }



    }
}
