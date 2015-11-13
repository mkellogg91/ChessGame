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


        public override Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y -= 1;

            }
            return startingPoint;

        }

        public override Point upMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
            }
            return startingPoint;

        }

        public override Point upDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public override Point leftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        public override Point rightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public override Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        public override Point downMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
            }
            return startingPoint;

        }

        public override Point downDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = pieceMoveDirectionIterator; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }


    }
}
