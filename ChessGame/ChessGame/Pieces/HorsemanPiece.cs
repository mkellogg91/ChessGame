﻿using System;
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


        // METHODS
        public void pieceMove(ChessboardSquare previousChessSquare, ChessboardSquare newChessSquare)
        {

        }


        public override List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {

            List<Point> potentialMoveList = new List<Point>();

            Point movePoint;

            
                //add down 2x left 1x
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                movePoint = leftMove(movePoint, 1);
                potentialMoveList.Add(movePoint);

                //add down 1x left 2x
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                movePoint = leftMove(movePoint, 2);
                potentialMoveList.Add(movePoint);

                //add up 1x left 2x
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                movePoint = leftMove(movePoint, 2);
                potentialMoveList.Add(movePoint);

                //add up 2x left 1x
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                movePoint = leftMove(movePoint, 1);
                potentialMoveList.Add(movePoint);

                //add down 2x right 1x
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                movePoint = rightMove(movePoint, 1);
                potentialMoveList.Add(movePoint);

                //add down 1x right 2x
                movePoint = downMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                movePoint = rightMove(movePoint, 2);
                potentialMoveList.Add(movePoint);

                //add up 1x right 2x
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 1);
                movePoint = rightMove(movePoint, 2);
                potentialMoveList.Add(movePoint);

                //add up 2x right 1x
                movePoint = upMove(new Point(chessSquare.squareArrayRow, chessSquare.squareArrayCol), 2);
                movePoint = rightMove(movePoint, 1);
                potentialMoveList.Add(movePoint);
            

            return potentialMoveList;

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

        public Point downMove(Point startingPoint, int numberOfRuns)
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
