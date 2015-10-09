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


        public List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {

            List<Point> potentialMoveList = new List<Point>();

            Point movePoint;

            //will never have to move more than 8 spaces
            for (int iterator = 1; iterator < 8; iterator++)
            {
                //add updiaglmove
                movePoint = upDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add upmove
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add updiagrmove
                movePoint = upDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add leftmove
                movePoint = leftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add rightmove
                movePoint = rightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add downdiaglmove
                movePoint = downDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add downmove
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add downdiagrmove
                movePoint = downDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);
            }

            return potentialMoveList;

        }


    }
}
