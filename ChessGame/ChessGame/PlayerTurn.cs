using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class PlayerTurn
    {

        public bool hasMoved { get; set; }
        public int colorPlayerTurn { get; set; }

        // Constructor!!
        public PlayerTurn()
        {
            // set hasMoved to false by default
            hasMoved = false;

            // by default white player goes first, white = 0, black = 1
            colorPlayerTurn = 0;
        }

        // this switches turn from black player to white player and vice versa
        public int switchTurns()
        {
            if(colorPlayerTurn == 0)
            {
                colorPlayerTurn = 1;
            }
            else if(colorPlayerTurn == 1)
            {
                colorPlayerTurn = 0;
            }

            return colorPlayerTurn;
        }

        public bool kingCheckChecker()
        {
            // kingInCheck is false by default until shown to be true
            bool kingInCheck = false;

            // logic to check if king is in check here


            // return bool result
            return kingInCheck;
        }
    }
}
