using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGame;
using System.Drawing;

namespace FrontEnd
{
    static class Program
    {

        public static chessForm myChessForm;
        
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
        [STAThread]
        static void Main()
        {
                // create a new instance of chess form
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool checkMate = false;

            myChessForm = new chessForm();
                // add chessBoardPanel to the form from chessBoard class
            myChessForm.Controls.Add(myChessForm.formChessGame.chessBoard.chessboardPanel);
            myChessForm.formChessGame.chessBoard.chessboardPanel.Size = new Size(myChessForm.Width, myChessForm.Height);

            Application.Run(myChessForm);

            // keep the game loop going until checkmate = true

            // if checkmate = true
            
                // display game over menu   

           

        }
    }
}
