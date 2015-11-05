using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ChessGame
{
    public class ChessboardSquare : PictureBox
    {

        // POSITION PROPERTIES
        public int squareArrayRow { get; set; }
        public int squareArrayCol { get; set; }
        public int squareSize_x { get; set; }
        public int squareSize_y { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A COLOR
        public Color squareColor { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A CHESSPEICE OBJECT
        public ChessPiece squareChessPiece { get; set; }
        public Size pictureBoxSize { get; set; }
        public Point point { get; set; }
        public Point boardLocation { get; set; }

        
        //picOneFaceUpA.MouseClick += new MouseEventHandler(your_event_handler);

        // CONSTRUCTOR
        public ChessboardSquare()
        {

            Initialize(10, 10);
            
        }

        // OVERLOAD CONSTRUCTOR FOR POSITION VALUES
        public ChessboardSquare(int x, int y)
        {
            
            Initialize(x, y);

        }

        public void Initialize(int x, int y)
        {

            pictureBoxSize = new Size(100, 100);

            point = new Point(x, y);

            this.Size = pictureBoxSize;
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

        }


    }
}
