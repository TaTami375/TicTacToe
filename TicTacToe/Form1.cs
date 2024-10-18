using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool first;
        private Image Tic;
        private Image Tac;
        public Form1()
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(TicTacToe.Properties.Resources.Tic))
            {
                Tic = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(TicTacToe.Properties.Resources.Tac))
            {
                Tac = Image.FromStream(ms);
            }
            first = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox11);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox21);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox31);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox12);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox22);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox32);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox13);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox23);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            MakeMove(pictureBox33);
        }

        private void MakeMove(PictureBox cell)
        {
            if (first)
            {
                cell.Image = Tic;
                first = false;
            }
            else
            {
                cell.Image = Tac;
                first = true;
            }

            cell.SizeMode = PictureBoxSizeMode.StretchImage;
            cell.Enabled = false;
        }
    }
}
