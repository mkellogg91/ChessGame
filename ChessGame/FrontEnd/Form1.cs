using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGame;

namespace FrontEnd
{
    public partial class chessForm : Form
    {

        public newChessGame formChessGame { get; set; }

        public chessForm()
        {
            InitializeComponent();
            chessForm_Load();
        }

        private void chessForm_Load()
        {

            formChessGame = new newChessGame();
        }
    }
}
