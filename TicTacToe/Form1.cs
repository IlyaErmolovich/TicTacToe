using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CellClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox cell && cell.Image == null)
            {
                if(e.Button == MouseButtons.Left)
                {
                    cell.Image = Properties.Resources.cross;
                } else if (e.Button == MouseButtons.Right) 
                {
                    cell.Image = Properties.Resources.circle;
                }
            }
        }
    }
}
