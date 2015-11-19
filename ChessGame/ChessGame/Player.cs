using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
            // bool representing if it is player's turn
        public bool isPlayerTurn { get; set; }

        // Constructor
        public Player()
        {
            // set player turn to false by default
            isPlayerTurn = false;
        }

    }
}
