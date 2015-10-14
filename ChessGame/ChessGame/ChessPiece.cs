using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessGame
{
    public class ChessPiece
    {

        // PROPERTIES

        public Image chesspieceImage { get; set; }
        public int pieceColor { get; set; }         // 0 = WHITE    1 = BLACK
        public bool isValidMove { get; set; }
       

        
        // CONSTRUCTOR!!!           TAKES A COLOR PARAMETER
        public ChessPiece(int color)
        {
            pieceColor = color;
        }

        // METHODS

        public Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y -= 1;

            }
            return startingPoint;

        }

        public Point upMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
            }
            return startingPoint;

        }

        public Point upDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public Point leftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        public Point rightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y -= 1;
            }
            return startingPoint;

        }

        public Point downMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
            }
            return startingPoint;

        }

        public Point downDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }


        public virtual List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {
            return new List<Point>();
        }





    }
}
