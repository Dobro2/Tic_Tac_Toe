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
        public int movesMade = 0;

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
        public void detectHit(Point loc)
        {
            if (loc.Y <= 500)
            {
                int x = 0;
                int y = 0;

                if (loc.X < 167)
                {
                    x = 0;
                }
                else if (loc.X > 167 && loc.X < 334)
                {
                    x = 1;
                }
                else if (loc.X > 334)
                {
                    x = 2;
                }
                if (loc.Y < 167)
                {
                    y = 0;
                }
                else if (loc.Y > 167 && loc.Y < 334)
                {
                    y = 1;
                }
                else if (loc.Y > 334 && loc.Y < 500)
                {
                    y = 2;
                }
                movesMade++;

                if (movesMade % 2 == 0)
                {
                    GFX.drawX(new Point(x, y));
                }
                else
                {
                    GFX.drawO(new Point(x, y));

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
