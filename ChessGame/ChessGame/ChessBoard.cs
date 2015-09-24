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
        

        private int boardX;
        private int boardY;

        // CONSTRUCTOR HERE
        public ChessBoard()
        {

            chessboardPanel = new Panel();
            boardX = 10;
            boardY = 10;
            boardBuilder(); //sets up the board
            

        } // end constructor


        public void boardBuilder()
        {
            // CREATING 64 CHESSBOARD SQUARES *****
            for (int row = 0; row < 8; row++)
            {

                boardX = 10;

                for (int col = 0; col < 8; col++)
                {

                    chessboardSquareArray[row, col] = new ChessboardSquare(boardX, boardY);

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

            

        } // end board builder
        


    }
}
