using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ChessGame;

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
        public void pieceMove(ChessboardSquare previousChessSquare, ChessboardSquare newChessSquare)
        {

        }


        public List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {

            List<Point> potentialMoveList = new List<Point>();

            Point movePoint;

            //if piece is white
            if(chessSquare.squareChessPiece.pieceColor == 0)
            {
                //add diaglmove
                movePoint = upDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add upmove
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add upmove 2x
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                potentialMoveList.Add(movePoint);

                //add diagrmove
                movePoint = upDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

            }
            //if piece is black
            else
            {

                //add diaglmove
                movePoint = downDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add downmove
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);

                //add downmove 2x
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                potentialMoveList.Add(movePoint);

                //add diagrmove
                movePoint = downDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                potentialMoveList.Add(movePoint);


            }

            return potentialMoveList;
                    
        }
       




            


    }
}
