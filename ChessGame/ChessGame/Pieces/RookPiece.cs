﻿using System;
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
                chesspieceImage = Image.FromFile("../Images/white_rook.PNG");
            }
            else   // ELSE BLACK PIECE
            {
                chesspieceImage = Image.FromFile("../Images/black_rook.PNG");
            }
        }

        // PROPERTIES



        // METHODS
        public void pieceMove(RookPiece rook)
        {

        }
        


    }
}
