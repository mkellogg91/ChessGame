﻿using System;
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

        public int startingPoint { get; set; }

        // CONSTRUCTOR
        public PawnPiece(int color) : base(color)
        {
            
            
            //DETERMINE PIECE IMAGE AND STARTING POINT
            if (pieceColor == 0)   // IF WHITE PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("white_pawn");
                startingPoint = 6;
                //chesspieceImage = Image.FromFile("../Images/white_pawn.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("black_pawn");
                startingPoint = 1;
                //chesspieceImage = Image.FromFile("../Images/black_pawn.PNG");
            }
        }


        public override Point upDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y -= 1;

            }
            return startingPoint;

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
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X -= 1;
                startingPoint.Y += 1;
            }
            return startingPoint;

        }

        public override Point leftMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //pawns don't move left and right
        }

        public override Point rightMove(Point startingPoint, int numberOfRuns)
        {
            return startingPoint;   //pawns don't move left and right
        }

        public override Point downDiagLeftMove(Point startingPoint, int numberOfRuns)
        {
            for (int x = 0; x < numberOfRuns; x++)
            {
                startingPoint.X += 1;
                startingPoint.Y -= 1;
            }
            return startingPoint;

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
