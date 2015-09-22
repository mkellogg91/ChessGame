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

        public Int16 squareXPos = 10;
        public Int16 squareYPos = 10;

        // CONSTRUCTOR HERE
        public ChessBoard()
        {

            ChessboardSquare[,] chessboardSquareArray = new ChessboardSquare[7,7];
            //List<ChessboardSquare> chessboardSquareList = new List<ChessboardSquare>();
            
            // CREATING 64 CHESSBOARD SQUARES
            for (int row = 0; row < 8; row++)
            {



                for (int col = 0; col < 8; col++)
                {

                    chessboardSquareArray[row, col] = new ChessboardSquare();

                    // place squares in specific locations
                    chessboardSquareArray[row, col].squarePictureBox.Location = new Point();

                    // set position value to the elements position property
                    chessboardSquareArray[row, col].squarePos_x = squareXPos;
                    chessboardSquareArray[row, col].squarePos_y = squareYPos;

                    // iterate the x position
                    squareXPos += 100;



                }

                // set position value to the elements position property
                chessboardSquareArray[row, col].squarePos_x = squareXPos;

                // iterate the y position
                squareYPos += 100;
                    
            }

        } // end constructor
        


    }
}
