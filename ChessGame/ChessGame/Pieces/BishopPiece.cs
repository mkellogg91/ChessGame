using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class BishopPiece : ChessPiece
    {

        // CONSTRUCTOR
        public BishopPiece(int color) : base (color)
        {
            


                //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_bishop");
                //chesspieceImage = Image.FromFile("../Images/white_bishop.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_bishop");
                //chesspieceImage = Image.FromFile("../Images/black_bishop.PNG");
            }
        }


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
                    //add updiaglmove
                    movePoint = upDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);

                    //add updiagrmove
                    movePoint = upDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);


                    //add downdiaglmove
                    movePoint = downDiagLeftMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);

                    //add downdiagrmove
                    movePoint = downDiagRightMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), iterator);
                    potentialMoveList.Add(movePoint);
                }

            return potentialMoveList;

        }


        // START MOVE DIRECTIONS HERE


        // updiagleft move
        public override Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y -= 1;

            }
            return startingPoint;

        }

        // up move
        public override Point upMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //bishops don't move up
        }


        // updiagright move
        public override Point upDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }


        // left move
        public override Point leftMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint; //bishops don't move left
        }

        // right move
        public override Point rightMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //bishops don't move right
        }


        // downdiagleft move
        public override Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        // down move
        public override Point downMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //bishops don't move down
        }

        // downdiagright move
        public override Point downDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }


    }
}
