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
            // displays potential moves
        public void displayPotentialMove(ChessboardSquare chessSquare)
        {

        }

        public bool validateMove(ChessboardSquare movingFromChessSquare, ChessboardSquare movingToChessSquare)
        {
            isValidMove = false;

            //if chesspiece.color == white
            if(movingFromChessSquare.squareChessPiece.pieceColor == 0)
            {
                bool enemyPieceDiagonal = false;

                //if enemypiece diagonal
                //if(chessboard.chessboardsquareArray)

                //if square.squareArrayRow, square.squareArrowCol within movable area
                
                    //set isValidMove = true

                //else 
                    //do nothing


            }




            //else if chesspiece.color == black
            else
            {

                //if square.squareArrayRow, square.squareArrowCol within movable area
                //set isValidMove = true

                //else 
                //do nothing

            }



            return isValidMove;
            
        }


    }
}
