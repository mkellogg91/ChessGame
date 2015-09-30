using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChessGame
{


    public class ChessBoard
    {
        // PROPERTIES
        public Panel chessboardPanel { get; set; }
        public ChessboardSquare[,] chessboardSquareArray = new ChessboardSquare[8,8];
        public List<ChessPiece>whitePieces { get; set; }
        public List<ChessPiece> blackPieces { get; set; }

        private int boardX;
        private int boardY;

        //chesspiece declaration
        //public KingPiece whiteKing;
        //public QueenPiece whiteQueen;
        //public BishopPiece whiteBishop1;
        //public BishopPiece whiteBishop2;
        //public HorsemanPiece whiteHorseman1;
        //public HorsemanPiece whiteHorseman2;
        //public RookPiece whiteRook1;
        //public RookPiece whiteRook2;
        //public PawnPiece whitePawn1;
        //public PawnPiece whitePawn2;
        //public PawnPiece whitePawn3;
        //public PawnPiece whitePawn4;
        //public PawnPiece whitePawn5;
        //public PawnPiece whitePawn6;
        //public PawnPiece whitePawn7;
        //public PawnPiece whitePawn8;

        //public KingPiece blackKing;
        //public QueenPiece blackQueen;
        //public BishopPiece blackBishop1;
        //public BishopPiece blackBishop2;
        //public HorsemanPiece blackHorseman1;
        //public HorsemanPiece blackHorseman2;
        //public RookPiece blackRook1;
        //public RookPiece blackRook2;
        //public PawnPiece blackPawn1;
        //public PawnPiece blackPawn2;
        //public PawnPiece blackPawn3;
        //public PawnPiece blackPawn4;
        //public PawnPiece blackPawn5;
        //public PawnPiece blackPawn6;
        //public PawnPiece blackPawn7;
        //public PawnPiece blackPawn8;

        // CONSTRUCTOR HERE
        public ChessBoard()
        {
            initialize();

            chessboardPanel = new Panel();
            chessboardPanel.BackColor = Color.Beige;
            boardX = 10;
            boardY = 10;

            boardBuilder(); //sets up the board
            
            

        } // end constructor

        public void initialize()
        {
                // lists of black and white pieces
            whitePieces = new List<ChessPiece>();
            blackPieces = new List<ChessPiece>();


            whitePieces.Add(new KingPiece(0));
            whitePieces.Add (new QueenPiece(0));
            whitePieces.Add (new BishopPiece(0));
            whitePieces.Add (new BishopPiece(0));
            whitePieces.Add (new HorsemanPiece(0));
            whitePieces.Add (new HorsemanPiece(0));
            whitePieces.Add (new RookPiece(0));
            whitePieces.Add (new RookPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));
            whitePieces.Add (new PawnPiece(0));


            blackPieces.Add(new KingPiece(0));
            blackPieces.Add(new QueenPiece(0));
            blackPieces.Add(new BishopPiece(0));
            blackPieces.Add(new BishopPiece(0));
            blackPieces.Add(new HorsemanPiece(0));
            blackPieces.Add(new HorsemanPiece(0));
            blackPieces.Add(new RookPiece(0));
            blackPieces.Add(new RookPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));
            blackPieces.Add(new PawnPiece(0));

        }


        public void boardBuilder()
        {

            int colorAlternator = 0;

            // CREATING 64 CHESSBOARD SQUARES *****
            for (int row = 0; row < 8; row++)
            {

                boardX = 10;

                for (int col = 0; col < 8; col++)
                {

                    chessboardSquareArray[row, col] = new ChessboardSquare(boardX, boardY);

                    if(colorAlternator == 0)
                    {
                        
                        //give the picturebox a color
                        chessboardSquareArray[row, col].squarePictureBox.BackColor = Color.White;
                        if(col == 7)
                        {
                            colorAlternator = 0;
                        }
                        else
                        {
                            colorAlternator = 1;
                        }
                        
                    }
                    else
                    {
                        chessboardSquareArray[row, col].squarePictureBox.BackColor = Color.Black;

                        if (col == 7)
                        {
                            colorAlternator = 1;
                        }
                        else
                        {
                            colorAlternator = 0;
                        }
                       
                    }

                    // give the picturebox a location
                    chessboardSquareArray[row, col].squarePictureBox.Location = chessboardSquareArray[row, col].point;

                    // add picturebox to the chessboard panel
                    chessboardPanel.Controls.Add(chessboardSquareArray[row, col].squarePictureBox);

                    

                    // iterate the x position
                    boardX += 100;

                } // end inner loop


                // iterate the y position
                boardY += 100;

            } // end outer loop


            // place pieces on board
            placePiece(4, 7, whitePieces[0]);




        } // end board builder


        public void placePiece(int col, int row, ChessPiece chessPiece)
        {

            // set square's image box = chessPiece's image
            chessboardSquareArray[col, row].squarePictureBox.Image = chessPiece.chesspieceImage;
            chessboardSquareArray[col, row].squareChessPiece = chessPiece;

        }



    }
}
