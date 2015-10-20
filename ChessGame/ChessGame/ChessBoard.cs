using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChessGame
{


    public class ChessBoard
    {
        // PROPERTIES
        public Panel chessboardPanel { get; set; }
        public ChessboardSquare[,] chessboardSquareArray = new ChessboardSquare[8,8];
        public List<ChessPiece>whitePieces { get; set; }
        public List<ChessPiece> blackPieces { get; set; }
        private List<Point> currentPotentialMoves;

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


            blackPieces.Add(new KingPiece(1));
            blackPieces.Add(new QueenPiece(1));
            blackPieces.Add(new BishopPiece(1));
            blackPieces.Add(new BishopPiece(1));
            blackPieces.Add(new HorsemanPiece(1));
            blackPieces.Add(new HorsemanPiece(1));
            blackPieces.Add(new RookPiece(1));
            blackPieces.Add(new RookPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));
            blackPieces.Add(new PawnPiece(1));

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
                        
                        //setting the square's location values
                    chessboardSquareArray[row, col].squareArrayRow = row;
                    chessboardSquareArray[row, col].squareArrayCol = col;

                    if (colorAlternator == 0)
                    {
                        
                        //give the picturebox a color
                        chessboardSquareArray[row, col].BackColor = Color.White;
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
                        chessboardSquareArray[row, col].BackColor = Color.Black;

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
                    chessboardSquareArray[row, col].Location = chessboardSquareArray[row, col].point;

                    // add picturebox to the chessboard panel
                    chessboardPanel.Controls.Add(chessboardSquareArray[row, col]);

                    // subscribe to action listener

                    chessboardSquareArray[row, col].MouseClick += new MouseEventHandler(this.pictureBox_Clicked);

                    // iterate the x position
                    boardX += 100;

                } // end inner loop


                // iterate the y position
                boardY += 100;

            } // end outer loop


            // place white pieces on board
            placePiece(7, 0, whitePieces[6]); //rook
            placePiece(7, 1, whitePieces[4]); //horse
            placePiece(7, 2, whitePieces[2]); //bishop
            placePiece(7, 3, whitePieces[1]); //queen
            placePiece(7, 4, whitePieces[0]); //king
            placePiece(7, 5, whitePieces[3]); //bishop
            placePiece(7, 6, whitePieces[5]); //horse
            placePiece(7, 7, whitePieces[7]); //rook
            placePiece(6, 0, whitePieces[8]); //pawn
            placePiece(6, 1, whitePieces[9]); //pawn
            placePiece(6, 2, whitePieces[10]); //pawn
            placePiece(6, 3, whitePieces[11]); //pawn
            placePiece(6, 4, whitePieces[12]); //pawn
            placePiece(6, 5, whitePieces[13]); //pawn
            placePiece(6, 6, whitePieces[14]); //pawn
            placePiece(6, 7, whitePieces[15]); //pawn

            // place black pieces on board
            placePiece(0, 0, blackPieces[6]); //rook
            placePiece(0, 1, blackPieces[4]); //horse
            placePiece(0, 2, blackPieces[2]); //bishop
            placePiece(0, 3, blackPieces[1]); //queen
            placePiece(0, 4, blackPieces[0]); //king
            placePiece(0, 5, blackPieces[3]); //bishop
            placePiece(0, 6, blackPieces[5]); //horse
            placePiece(0, 7, blackPieces[7]); //rook
            placePiece(1, 0, blackPieces[8]); //pawn
            placePiece(1, 1, blackPieces[9]); //pawn
            placePiece(1, 2, blackPieces[10]); //pawn
            placePiece(1, 3, blackPieces[11]); //pawn
            placePiece(1, 4, blackPieces[12]); //pawn
            placePiece(1, 5, blackPieces[13]); //pawn
            placePiece(1, 6, blackPieces[14]); //pawn
            placePiece(1, 7, blackPieces[15]); //pawn




    } // end board builder

        void pictureBox_Clicked(object sender, EventArgs e)
        {

            ChessboardSquare theSender = ((ChessboardSquare)sender);





            //if 1st time clicking this square or if it is outside move range

            //if piece == null and not in move range
            //don't do anything 

            //if first time getting clicked -> display potential moves

            //currentPotentialMoves = theSender.squareChessPiece.returnPotentialMoves(theSender);

            //now that we have all potential moves let's eliminate moves that are prohibited for various reasons such as: other pieces blocking, king in check
            //eg: pawnpiece that doesn't have an enemy piece diagonally cannot move diagonnally
            //check board for exceptions


            //else if 2nd time getting clicked
            //if in moving range for that piece
            //move piece 

            //else if not in moving range for that piece
            //

            //display potential moves
            //hilight squares where user could move piece


            //this.squareChessPiece.



            //return potential moves
            currentPotentialMoves = theSender.squareChessPiece.returnPotentialMoves(theSender);

            //validate the returned list of potentail moves
            validateMoves(theSender, currentPotentialMoves);

            //color squares of potential moves
            displayPotentialMoves(currentPotentialMoves);

            Debug.WriteLine(theSender.squareArrayRow.ToString() + "," + theSender.squareArrayCol.ToString());

        } //end picturebox clicked event



        public void placePiece(int col, int row, ChessPiece chessPiece)
        {

                // set square's image box = chessPiece's image
            chessboardSquareArray[col, row].Image = chessPiece.chesspieceImage;
                //center image in picturebox
            chessboardSquareArray[col, row].SizeMode = PictureBoxSizeMode.CenterImage;
                //set Square's chessPiece property to the passed in chessPiece
            chessboardSquareArray[col, row].squareChessPiece = chessPiece;

        }


        public List<Point> validateMoves(ChessboardSquare movingFromChessSquare, List<Point> pointList)
        {

            // variables
            bool enemyPieceDiagonal = false;

            // eliminate moves from the list that are not permissible moves
            foreach(Point point in pointList)
            {
                //call moveEliminator for each point in the point list
                //if true do nothing
                if(moveEliminator(point))
                {
                    //no action required the point is valid
                }

                else
                {
                    //remove from list, this point is invalid
                    pointList.Remove(point);

                }

            }
            //return list of possible moves
            return pointList;

        }

        public bool moveEliminator(Point move)
        {
            bool isValidMove = true;

            // is the move outside the bounds of the board?
            if(move.X > 7 || move.X < 0 || move.Y < 0 || move.Y > 7)
            {
                isValidMove = false;
            }

            // is there a piece in the way of this move?
            else if (chessboardSquareArray[move.X, move.Y].squareChessPiece != null)
            {
                //is the piece on this square a friendly or enemy piece?
                isValidMove = false;

                //**still needs some work
            }

            // return the result of the validity check
            return isValidMove;
        }


        public void displayPotentialMoves(List<Point> moves)
        {

            // hilight each chessboard square to show potential moves
            foreach(Point point in moves)
            {
                chessboardSquareArray[point.X, point.Y].BackColor = Color.Fuchsia;
            }

        }


    }
}
