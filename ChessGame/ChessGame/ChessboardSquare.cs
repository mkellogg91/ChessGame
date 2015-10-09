using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace ChessGame
{
    public class ChessboardSquare
    {

        // POSITION PROPERTIES
        public int squareArrayRow { get; set; }
        public int squareArrayCol { get; set; }
        public int squareSize_x { get; set; }
        public int squareSize_y { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A COLOR
        public string squareColor { get; set; }
        // CHESSBOARD SQUARES WILL HAVE A CHESSPEICE OBJECT
        public ChessPiece squareChessPiece { get; set; }
        public Size pictureBoxSize { get; set; }
        public Point point { get; set; }


        // ACTUAL VISUAL REPRESENTATION OF CHESSBOARD SQUARE
        public PictureBox squarePictureBox { get; set; }

        //temporary
        public Button buttonTest { get; set; }


        
        //picOneFaceUpA.MouseClick += new MouseEventHandler(your_event_handler);

        // CONSTRUCTOR
        public ChessboardSquare()
        {

            squarePictureBox = new PictureBox();
            Initialize(10, 10);
            

        }

        // OVERLOAD CONSTRUCTOR FOR POSITION VALUES
        public ChessboardSquare(int x, int y)
        {
            squarePictureBox = new PictureBox();
            Initialize(x, y);

        }

        public void Initialize(int x, int y)
        {

            pictureBoxSize = new Size(100, 100);

            point = new Point(x, y);

            squarePictureBox.Size = pictureBoxSize;
            squarePictureBox.BackColor = Color.White;
            squarePictureBox.BorderStyle = BorderStyle.FixedSingle;

                //ADD EVENT HANDLER FOR EACH SQUARE
            this.squarePictureBox.MouseClick += new MouseEventHandler(pictureBox_Clicked);
            
        }

                //ADD CODE WHEN SQUARE CLICKED
        void pictureBox_Clicked(object sender, EventArgs e)
        {
            
            


            //if 1st time clicking this square or if it is outside move range
            
                //if piece == null and not in move range
                    //don't do anything 

                //if first time getting clicked -> display potential moves

                //else if 2nd time getting clicked
                    //if in moving range for that piece
                        //move piece 

                    //else if not in moving range for that piece
                        //

            //display potential moves
                //hilight squares where user could move piece


            //this.squareChessPiece.



            Debug.WriteLine(Convert.ToString(this.squareArrayRow) + "," + Convert.ToString(this.squareArrayCol));

        }



    }
}
