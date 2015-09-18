using System;
using System.Collections.Generic;
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
                    

                }
                    


                //put chessboardsqures in 2d array?

                // gives each square its appropriate location
                // give each square its appropriate color
                // 
                    
            }

        } // end constructor
        


    }
}
