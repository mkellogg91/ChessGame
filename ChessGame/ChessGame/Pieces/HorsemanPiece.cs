using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGame
{
    public class HorsemanPiece : ChessPiece
    {

        // CONSTRUCTOR
        public HorsemanPiece(int color) : base (color)
        {
            //DETERMINE PIECE IMAGE
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_horse");
                //chesspieceImage = Image.FromFile("../Images/white_horse.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_horse");
                //chesspieceImage = Image.FromFile("../Images/black_horse.PNG");
            }
        }


        public override Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //knights don't require diagonal moves
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
            return startingPoint;   //knights don't require diagonal moves
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
            return startingPoint;   //knights don't require diagonal moves
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
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }


    }
}
