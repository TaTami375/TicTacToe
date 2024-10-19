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
            ChekWin();
            ChekDraw();
        }

        private void ChekWin()
        {
            if (!first)
            {
                if((pictureBox11.Image==Tic && pictureBox12.Image == Tic && pictureBox13.Image == Tic) ||
                    (pictureBox21.Image == Tic && pictureBox22.Image == Tic && pictureBox23.Image == Tic)||
                    (pictureBox31.Image == Tic && pictureBox32.Image == Tic && pictureBox33.Image == Tic)||
                    (pictureBox11.Image == Tic && pictureBox21.Image == Tic && pictureBox31.Image == Tic)||
                    (pictureBox12.Image == Tic && pictureBox22.Image == Tic && pictureBox32.Image == Tic)||
                    (pictureBox13.Image == Tic && pictureBox23.Image == Tic && pictureBox33.Image == Tic)||
                    (pictureBox11.Image == Tic && pictureBox22.Image == Tic && pictureBox33.Image == Tic)||
                    (pictureBox13.Image == Tic && pictureBox22.Image == Tic && pictureBox31.Image == Tic))
                {
                    MessageBox.Show(this, "Победа крестиков");
                    ClearField();
                }
            }
            else
            {
                if ((pictureBox11.Image == Tac && pictureBox12.Image == Tac && pictureBox13.Image == Tac) ||
                    (pictureBox21.Image == Tac && pictureBox22.Image == Tac && pictureBox23.Image == Tac) ||
                    (pictureBox31.Image == Tac && pictureBox32.Image == Tac && pictureBox33.Image == Tac) ||
                    (pictureBox11.Image == Tac && pictureBox21.Image == Tac && pictureBox31.Image == Tac) ||
                    (pictureBox12.Image == Tac && pictureBox22.Image == Tac && pictureBox32.Image == Tac) ||
                    (pictureBox13.Image == Tac && pictureBox23.Image == Tac && pictureBox33.Image == Tac) ||
                    (pictureBox11.Image == Tac && pictureBox22.Image == Tac && pictureBox33.Image == Tac) ||
                    (pictureBox13.Image == Tac && pictureBox22.Image == Tac && pictureBox31.Image == Tac))
                {
                    MessageBox.Show("Победа ноликов");
                    ClearField();
                }
            }
        }

        private void ClearField()
        {
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox21.Enabled = true;
            pictureBox22.Enabled = true;
            pictureBox23.Enabled = true;
            pictureBox31.Enabled = true;
            pictureBox32.Enabled = true;
            pictureBox33.Enabled = true;
            first = true;
        }

        private void ChekDraw()
        {
            if ((!pictureBox11.Enabled && !pictureBox12.Enabled && !pictureBox13.Enabled &&
                !pictureBox21.Enabled && !pictureBox22.Enabled && !pictureBox23.Enabled &&
                !pictureBox31.Enabled && !pictureBox32.Enabled && !pictureBox33.Enabled))
            {
                MessageBox.Show(this, "Ниичья");
                ClearField();
            }
        }
    }
}
