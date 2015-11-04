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



        public override Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //rooks don't move diagonally
        }

        public override Point upMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
            }
            return startingPoint;

        }

        public override Point upDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //rooks don't move diagonally
        }

        public override Point leftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        public override Point rightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public override Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //rooks don't move diagonally
        }

        public override Point downMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
            }
            return startingPoint;

        }

        public override Point downDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //rooks don't move diagonally
        }



    }
}
