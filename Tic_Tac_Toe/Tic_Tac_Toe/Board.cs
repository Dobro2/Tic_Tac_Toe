using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tic_Tac_Toe
{
    class Board
    {
        private Rectangle[,] slots = new Rectangle[3, 3];
        private Holder[,] holders = new Holder[3,3];

        public const int X = 0;
        public const int O = 1;
        public const int B = 2;

        public void initBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    slots[x, y] = new Rectangle(x * 167, y * 167, 167, 167);
                    holders[x, y] = new Holder();
                    holders[x, y].setValue(B);
                    holders[x, y].setLocation(new Point(x,y));
                }
            }
        }
    }
     class Holder
    {
        private Point location;
        private int value = Board.B;
        public void setLocation(Point p)
            {
            location = p;
            }
    public Point getLocation()
        {
            return location;
        }
        public void setValue(int i)
        {
            value = i;
        }
        public int getValue()
        {
            return value;
        }

        }
}
