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
        public bool isMoveClick = false;
        public ChessboardSquare previousClickedSquare = null;

        private int boardX;
        private int boardY;


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
                    chessboardSquareArray[row, col].boardLocation = new Point(row, col);

                    if (colorAlternator == 0)
                    {
                        
                        // give the picturebox a color
                        chessboardSquareArray[row, col].BackColor = Color.White;
                        // assign the color property of the square
                        chessboardSquareArray[row, col].squareColor = Color.White;
                        if (col == 7)
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
                        // assign the color property of the square
                        chessboardSquareArray[row, col].squareColor = Color.Black;

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

                    // SQUARE CLICKED EVENT HERE ***

        void pictureBox_Clicked(object sender, EventArgs e)
        {
            ChessboardSquare clickedSquare = (ChessboardSquare)sender;

            
            // determine if this click is a move click or display potential move click
            isMoveClick = isMoveClickCheck(clickedSquare, currentPotentialMoves);

            // if the square clicked is a square that exists in the potential move list from the previous click, move the piece 
            if (isMoveClick)
            {
                // remove previous hilighted squares
                unDisplayPotentialMoves(currentPotentialMoves);

                // is an enemy piece present on this spot? if so take it
                if(clickedSquare.squareChessPiece != null)
                {
                    // work on takePiece method
                        // remove piece from the board
                        // add to takenPieces list

                    // move the piece (work on all the changes that have to be made on piece move in piece move method)    
                    movePiece(previousClickedSquare, clickedSquare);
                }
                // if no piece needs to be taken, then just move the piece there
                else
                {
                    movePiece(previousClickedSquare, clickedSquare);
                }
                
                
            }

            // else if this is not a move click
            else
            {
                // remove previous hilighted squares
                if(currentPotentialMoves != null)
                {
                    unDisplayPotentialMoves(currentPotentialMoves);
                }
                
                // does the square clicked have a piece present?
                if(clickedSquare.squareChessPiece != null)
                {
                    // if so is the piece friend or foe?
                    //don't have the capability of determining this yet because friend/foe is relative to who's turn it is and I don't have that programmed out yet

                    //return potential moves
                    currentPotentialMoves = returnPotentialMoves(clickedSquare);

                    // color squares of potential moves
                    displayPotentialMoves(currentPotentialMoves);

                    // this is for testing and can be removed
                    Debug.WriteLine(clickedSquare.squareArrayRow.ToString() + "," + clickedSquare.squareArrayCol.ToString());

                }

                // else if it is an empty square, do nothing
                else
                {
                    Debug.WriteLine(clickedSquare.squareArrayRow.ToString() + "," + clickedSquare.squareArrayCol.ToString());
                }


            }

            // set the previousClickedSquare = clickedSquare
            previousClickedSquare = clickedSquare;

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



        public List<Point> returnPotentialMoves(ChessboardSquare chessSquare)
        {


            // list to return of potential moves
            List<Point> potentialMoveList = new List<Point>();

            // represents the current potential move that we will either add or not add to the list
            Point movePoint;

            // this is the iterator for our looping through outer loop potential moves for this square
            int outerIterator;

            // this is the iterator for our looping through inner loop potential moves for this square
            int innerIterator = 0;

            // clicked piece color
            int clickedPieceColor = chessSquare.squareChessPiece.pieceColor;

            // # of times inner loop should iterate
            int innerLoopEnd = 0;

            // store type of piece that is currently moving
            Object clickedPiece = chessSquare.squareChessPiece.GetType();

            // special case bool for not allowing a move to be added to potential move list
            bool canBeAdded = true;


            //* loop through each of the 8 directions, 1 direction at a time until it hits the boarder or another piece *//

            // outer loop ends once we have looped through each of the 8 directions pieces can move
            for(outerIterator = 0; outerIterator <= 7; outerIterator++)
            {

                // determine how many iterations the inner loop should do
                if (clickedPiece == typeof(PawnPiece))
                {
                    innerLoopEnd = 3;
                }
                else if (clickedPiece == typeof(HorsemanPiece))
                {
                    innerLoopEnd = 15;
                }
                else if (clickedPiece == typeof(KingPiece))
                {
                    innerLoopEnd = 0;
                }
                else
                {
                    innerLoopEnd = 7;
                }

                // ensure inner iterator is getting reset on each iteration
                innerIterator = 0;
                // inner loop ends once we hit another piece or the boarder's edge
                do
                {
                    // set movePoint variable to null at the top of each iteration
                    
                    movePoint = new Point(0, 0);
                    canBeAdded = true;
                  
                    // if piece type == pawn 
                    if (clickedPiece == typeof(PawnPiece))
                    {
                        // if piece color == white
                        if (clickedPieceColor == 0)
                        {
                            // switch statement for each of the potential moves of a pawn
                            switch (innerIterator)
                            {
                                // up diag left move
                                case 0:
                                    movePoint = chessSquare.squareChessPiece.upDiagLeftMove(chessSquare.boardLocation, 1);
                                    break;

                                // up move
                                case 1:
                                    movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 1);
                                    break;

                                // up move 2X
                                case 2:
                                    movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 2);
                                    break;

                                // up diag right move
                                case 3:
                                    movePoint = chessSquare.squareChessPiece.upDiagRightMove(chessSquare.boardLocation, 1);
                                    break;
                            }

                            // check if this is a diagonal move
                            if (innerIterator == 0 || innerIterator == 3)
                            {

                                // check if piece is outside the bounds of the board
                                if (isOutOfBounds(movePoint))
                                {
                                    // if outside board don't do anything

                                }

                                // check if there is a chesspiece present diagonally, the code will check to see if it an ally or enemy later and add it or not depending on which it is
                                else if (chessboardSquareArray[movePoint.X, movePoint.Y].squareChessPiece != null)
                                {
                                    canBeAdded = true;
                                }

                                // if there is no chesspiece present diagonally, this move cannot be added
                                else
                                {
                                    canBeAdded = false;
                                }

                            }

                            // check if pawn piece should be able to legally move 2 spaces forward (index "2" represents the 2 spaces forward move)
                            else if (innerIterator == 2)
                            {
                                // check if the pawn piece started on its original row
                                if (chessSquare.boardLocation.X == 6)
                                {
                                    // if so add to potential move list
                                    canBeAdded = true;
                                }
                                // else do not add
                                else
                                {
                                    canBeAdded = false;
                                }

                            }



                        }

                        // else (if piece color is black)
                        else
                        {
                            // inverse logic for as the white pieces
                            // switch statement for each of the potential moves of a pawn
                            switch (innerIterator)
                            {
                                // down diag left move
                                case 0:
                                    movePoint = chessSquare.squareChessPiece.downDiagLeftMove(chessSquare.boardLocation, 1);
                                    break;

                                // down move
                                case 1:
                                    movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 1);
                                    break;

                                // down move 2X
                                case 2:
                                    movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 2);
                                    break;

                                // down diag right move
                                case 3:
                                    movePoint = chessSquare.squareChessPiece.downDiagRightMove(chessSquare.boardLocation, 1);
                                    break;
                            }

                            // check if this is a diagonal move
                            if (innerIterator == 0 || innerIterator == 3)
                            {

                                // check if piece is outside the bounds of the board
                                if (isOutOfBounds(movePoint))
                                {
                                    // if outside board don't do anything

                                }

                                // check if there is a chesspiece present diagonally, the code will check to see if it an ally or enemy later and add it or not depending on which it is
                                else if (chessboardSquareArray[movePoint.X, movePoint.Y].squareChessPiece != null)
                                {
                                    canBeAdded = true;
                                }

                                // if there is no chesspiece present diagonally, this move cannot be added
                                else
                                {
                                    canBeAdded = false;
                                }

                            }

                            // check if pawn piece should be able to legally move 2 spaces forward (index "2" represents the 2 spaces forward move)
                            else if (innerIterator == 2)
                            {
                                // check if the pawn piece started on its original row
                                if (chessSquare.boardLocation.X == 1)
                                {
                                    // if so add to potential move list
                                    canBeAdded = true;
                                }
                                // else do not add
                                else
                                {
                                    canBeAdded = false;
                                }

                            }

                        }


                    }
                    // else if object type == knight
                    else if (clickedPiece == typeof(HorsemanPiece))
                    {
                        // check potential moves in each direction, to see if there is a chess piece on any of them
                        switch (innerIterator)
                        {
                            // UP
                            // up 2x left 1x
                            case 0:
                                movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.leftMove(movePoint, 1);
                                break;
                            // up 1x left 2x
                            case 1:
                                movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.leftMove(movePoint, 2);
                                break;
                            // up 2x right 1x
                            case 2:
                                movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.rightMove(movePoint, 1);
                                break;
                            // up 1x right 2x
                            case 3:
                                movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.rightMove(movePoint, 2);
                                break;
                            // RIGHT
                            // right 2x up 1x
                            case 4:
                                movePoint = chessSquare.squareChessPiece.rightMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.upMove(movePoint, 1);
                                break;
                            // right 1x up 2x
                            case 5:
                                movePoint = chessSquare.squareChessPiece.rightMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.upMove(movePoint, 2);
                                break;
                            // right 2x down 1x
                            case 6:
                                movePoint = chessSquare.squareChessPiece.rightMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.downMove(movePoint, 1);
                                break;
                            // right 1x down 2x
                            case 7:
                                movePoint = chessSquare.squareChessPiece.rightMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.downMove(movePoint, 2);
                                break;
                            // DOWN
                            // down 2x right 1x
                            case 8:
                                movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.rightMove(movePoint, 1);
                                break;
                            // down 1x right 2x
                            case 9:
                                movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.rightMove(movePoint, 2);
                                break;
                            // down 2x left 1x
                            case 10:
                                movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.leftMove(movePoint, 1);
                                break;
                            // down 1x left 2x
                            case 11:
                                movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.leftMove(movePoint, 2);
                                break;
                            // LEFT
                            // left 2x down 1x
                            case 12:
                                movePoint = chessSquare.squareChessPiece.leftMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.downMove(movePoint, 1);
                                break;
                            // left 1x down 2x
                            case 13:
                                movePoint = chessSquare.squareChessPiece.leftMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.downMove(movePoint, 2);
                                break;
                            // left 2x up 1x
                            case 14:
                                movePoint = chessSquare.squareChessPiece.leftMove(chessSquare.boardLocation, 2);
                                movePoint = chessSquare.squareChessPiece.upMove(movePoint, 1);
                                break;
                            // left 1x up 2x
                            case 15:
                                movePoint = chessSquare.squareChessPiece.leftMove(chessSquare.boardLocation, 1);
                                movePoint = chessSquare.squareChessPiece.upMove(movePoint, 2);
                                break;
                        }



                    }

                    // else 
                    else
                    {

                        // switch statement for each of the 8 directions if it isn't a knight, or pawn
                        switch (outerIterator)
                        {
                            // up move potentials
                            case 0:
                                movePoint = chessSquare.squareChessPiece.upMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // updiagright move potentials
                            case 1:
                                movePoint = chessSquare.squareChessPiece.upDiagRightMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // right move potentials
                            case 2:
                                movePoint = chessSquare.squareChessPiece.rightMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // downdiagright move potentials
                            case 3:
                                movePoint = chessSquare.squareChessPiece.downDiagRightMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // down move potentials
                            case 4:
                                movePoint = chessSquare.squareChessPiece.downMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // downdiagleft move potentials
                            case 5:
                                movePoint = chessSquare.squareChessPiece.downDiagLeftMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // left move potentials
                            case 6:
                                movePoint = chessSquare.squareChessPiece.leftMove(chessSquare.boardLocation, innerIterator);
                                break;

                            // updiagleft move potentials
                            case 7:
                                movePoint = chessSquare.squareChessPiece.upDiagLeftMove(chessSquare.boardLocation, innerIterator);
                                break;
                        }

                    }
                    // CHECKING FOR ALL PIECES

                    // check if we are outside the bounds of the board, if so, break
                    if (isOutOfBounds(movePoint))
                    {
                        if (clickedPiece == typeof(HorsemanPiece) || clickedPiece == typeof(PawnPiece))
                        {
                            // do nothing since these pieces use the inner iterator only
                        }
                        // if any other piece we want to break out of the inner loop, because we can move on to a different direction
                        else
                        {
                            break;
                        }

                    }
                    // if there is a special circumstance that prevents move from being added, stop here
                    else if (!canBeAdded)
                    {
                        // do nothing
                    }

                    // check if the returned square contains a chess piece
                    else if (chessboardSquareArray[movePoint.X, movePoint.Y].squareChessPiece != null)
                    {

                        // check if the move should not be added for any special circumstance EG. pawn enemy not diagonal
                        if (!canBeAdded)
                        {
                            // don't add to potential move list
                        }

                        // SOMETHING WRONG THIS THIS LOGIC
                        // if chess piece color is different then we can take that piece, this square can be added to potential move list
                        else if (chessboardSquareArray[movePoint.X, movePoint.Y].squareChessPiece.pieceColor != clickedPieceColor)
                        {
                            // add to potential move list
                            potentialMoveList.Add(movePoint);

                            if (clickedPiece == typeof(HorsemanPiece) || clickedPiece == typeof(PawnPiece))
                            {
                                // don't break from loop if this is a knight
                            }
                            else
                            {
                                // iterate to next move direction
                                break;  // break out of the loop
                            }
                            


                        }
                        else if(clickedPiece == typeof(HorsemanPiece))
                        {
                            // do nothing in this case if it is a knight
                        }

                        // if the chess peiece is the same color, this square is excluded from potential moves
                        else
                        {
                            break;  // break out of the loop
                        }


                    }
                    // if chessSquare has no chesspiece and is within bounds of the board it can be added to potential moves
                    else
                    {
                        potentialMoveList.Add(movePoint);
                    }

                    innerIterator++;

                    // iterate until we hit a chess piece on a square or we hit the board's edge
                } while (innerIterator <= innerLoopEnd);


                // if type is pawn or knight we don't need the outer iterator at all
                if (clickedPiece == typeof(PawnPiece) || clickedPiece == typeof(HorsemanPiece))
                {
                    break;
                }

                    // iterate until all directions have been covered
            }   // END OUTER LOOP


            //special conditions for pawn piece, but otherwise all moves should be handled by override


            return potentialMoveList;
        }

            
        public bool isOutOfBounds(Point potentialMove)
        {

            if(potentialMove.X > 7 || potentialMove.X < 0)
            {
                // point is out of bounds
                return true;
            }
            else if(potentialMove.Y > 7 || potentialMove.Y < 0)
            {
                // point is out of bounds
                return true;
            }
            else
            {
                // point is not out of bounds
                return false;
            }
        }


        public void displayPotentialMoves(List<Point> moves)
        {

            // hilight each chessboard square to show potential moves
            foreach (Point point in moves)
            {
                chessboardSquareArray[point.X, point.Y].BackColor = Color.Fuchsia;
            }

        }

       public void unDisplayPotentialMoves(List<Point> moves)
        {
            // change chessboard squares back to their original colors
            foreach (Point point in moves)
            {
                chessboardSquareArray[point.X, point.Y].BackColor = chessboardSquareArray[point.X, point.Y].squareColor;
            }
        }

            // method for checking if a click is a potential move click or a piece move click
        public bool isMoveClickCheck(ChessboardSquare clicked, List<Point> moveList)
        {
            bool isMove = false;


            
                // the only time movelist is null is probably on first click of the application instance
            if(moveList == null)
            {
                isMove = false;
            }
                // if square clicked exists in the potential move list set to true
            else if (moveList.Contains(clicked.boardLocation))
            {
                isMove = true;
            }
                // in any other case, it is not a move click
            else
            {
                isMove = false;
            }


            return isMove;
        }

        // THIS METHOD IS CALLED ANYTIME A CHESSPEICE IS MOVED
        public void movePiece(ChessboardSquare previousSquare, ChessboardSquare newSquare)
        {

            // set the newsquare's chesspiece = to the new chesspiece
            newSquare.squareChessPiece = previousSquare.squareChessPiece;

            // set the newsquare's image to the appropriate image
            placePiece(newSquare.boardLocation.X, newSquare.boardLocation.Y, previousSquare.squareChessPiece);

            // set previous square's image = null
            chessboardSquareArray[previousSquare.boardLocation.X, previousSquare.boardLocation.Y].Image = null;

            // take the current board location data from the square, and set that square on the board to null
            newSquare.squareChessPiece = previousSquare.squareChessPiece;
            previousSquare.squareChessPiece = null;

            //

        }

        // THIS METHOD IS 
        public void takePiece()
        {

        }

    }
}
