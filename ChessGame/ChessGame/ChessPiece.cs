﻿using System;
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
        public const int pieceMoveDirectionIterator = -1;
        public bool isTaken { get; set; }
        public Point pieceBoardLocation { get; set; }
        public bool hasKingInCheck { get; set; }

        
        // CONSTRUCTOR!!!           TAKES A COLOR PARAMETER
        public ChessPiece(int color)
        {
            pieceColor = color;
            isTaken = false;
            pieceBoardLocation = new Point();
        }

        // METHODS

        public virtual Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point upMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point upDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point leftMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point rightMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point downMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }

        public virtual Point downDiagRightMove(Point startingPoint, int numberOfRuns)
        {
            startingPoint.X = -1;
            startingPoint.Y = -1;
            return startingPoint;
        }


        public virtual List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {
            return new List<Point>();
        }





    }
}
