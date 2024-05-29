using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool _gameOver = false;
        private int emptyCellCount = 9;

        public Form1()
        {
            InitializeComponent();
            InitField();
        }
        private void InitField()
        {
            pictureBox1.Image = null;
            pictureBox1.Tag = null;
            pictureBox2.Image = null;
            pictureBox2.Tag = null;
            pictureBox3.Image = null;
            pictureBox3.Tag = null;
            pictureBox4.Image = null;
            pictureBox4.Tag = null;
            pictureBox5.Image = null;
            pictureBox5.Tag = null;
            pictureBox6.Image = null;
            pictureBox6.Tag = null;
            pictureBox7.Image = null;
            pictureBox7.Tag = null;
            pictureBox8.Image = null;
            pictureBox8.Tag = null;
            pictureBox9.Image = null;
            pictureBox9.Tag = null;
        }

        private void GameOver(string winner)
        {
            if (winner == "Cross")
            {
                result.Text = "Победитель: крестики";
            }
            else if (winner == "Circle")
            {
                result.Text = "Победитель: нолики";
            } else if(winner == "ничья")
            {
                result.Text = "Ничья";
            }
            _gameOver = true;
            restart.Enabled = true;
        }

        private void CheckWinner()
        {
            if (pictureBox1.Tag != null &&
               pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag)
            {
                GameOver(pictureBox1.Tag.ToString());
                return;
            }
            if(pictureBox1.Tag != null &&
               pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag)
            {
                GameOver(pictureBox1.Tag.ToString());
                return;
            }
            if (pictureBox7.Tag != null &&
               pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag)
            {
                GameOver(pictureBox7.Tag.ToString());
                return;
            }
            if (pictureBox9.Tag != null &&
               pictureBox9.Tag == pictureBox6.Tag && pictureBox9.Tag == pictureBox3.Tag)
            {
                GameOver(pictureBox9.Tag.ToString());
                return;
            }
            if (pictureBox1.Tag != null &&
              pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag)
            {
                GameOver(pictureBox1.Tag.ToString());
                return;
            }
            if (pictureBox3.Tag != null &&
              pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag)
            {
                GameOver(pictureBox3.Tag.ToString());
                return;
            }
            if (pictureBox4.Tag != null &&
              pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag)
            {
                GameOver(pictureBox4.Tag.ToString());
                return;
            }
            if (pictureBox2.Tag != null &&
              pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag)
            {
                GameOver(pictureBox2.Tag.ToString());
                return;
            }
        }

        private void CellClick(object sender, MouseEventArgs e)
        {
            if (!_gameOver && sender is PictureBox cell && cell.Image == null)
            {
                if(e.Button == MouseButtons.Left)
                {
                    cell.Image = Properties.Resources.cross;
                    cell.Tag = "Cross";
                } else if (e.Button == MouseButtons.Right) 
                {
                    cell.Image = Properties.Resources.circle;
                    cell.Tag = "Circle";
                }

                CheckWinner();
                emptyCellCount--;
            }
            if (emptyCellCount == 0)
            {
                GameOver("ничья");
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            InitField();
            restart.Enabled = false;
            result.Text = string.Empty;
            _gameOver = false;
            emptyCellCount = 9;
        }
    }
}
