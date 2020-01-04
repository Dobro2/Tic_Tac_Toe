using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
         GFX engine;
         Board theBoard;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new GFX(toPass);

            theBoard = new Board();
            theBoard.initBoard();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theBoard.reset();
            engine.setUpCanvas();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projekt gry na zaliczenie przedmiotu");
        }
    }
}
