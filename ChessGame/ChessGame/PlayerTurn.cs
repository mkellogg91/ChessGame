using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class PlayerTurn
    {

        public bool hasMoved { get; set; }


        // Constructor!!
        public PlayerTurn()
        {
            // set hasMoved to false by default
            hasMoved = false;
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
