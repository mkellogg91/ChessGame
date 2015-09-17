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

            

            List<ChessboardSquare> chessboardSquareList = new List<ChessboardSquare>();
            
            // CREATING 64 CHESSBOARD SQUARES
            for (int numOfSquares = 1; numOfSquares < 65; numOfSquares++)
            {
                chessboardSquareList[numOfSquares] = new ChessboardSquare();

                // gives each square its appropriate location
                // give each square its appropriate color
                // 
                    
            }

        } // end constructor
        


    }
}
