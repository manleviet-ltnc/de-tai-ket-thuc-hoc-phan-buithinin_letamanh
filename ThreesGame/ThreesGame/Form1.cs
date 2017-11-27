using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreesGame
{
    public partial class frmThreesGame : Form
    {
        Random Rd = new Random();
        int[,] mangChiSoRong = new int[4, 4];
        public frmThreesGame()
        {
            InitializeComponent();
        }
        public void CapNhatMau()
        {
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (Game[i, j].Text == "")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.CadetBlue;
                    }
                    if (Game[i, j].Text == "1")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.SkyBlue;
                        Game[i, j].ForeColor = System.Drawing.Color.White;

                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Pink;
                        Game[i, j].ForeColor = System.Drawing.Color.White;

                    }
                    if (Game[i, j].Text == "3")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (Game[i, j].Text == "6")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (Game[i, j].Text == "12")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (Game[i, j].Text == "24")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (Game[i, j].Text == "48")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (Game[i, j].Text == "96")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Pink;
                    }
                    if (Game[i, j].Text == "192")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Pink;
                    }
                    if (Game[i, j].Text == "384")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Yellow;
                    }
                    if (Game[i, j].Text == "768")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Yellow;
                    }
                    if (Game[i, j].Text == "1536")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Gold;
                    }
                    if (Game[i, j].Text == "3042")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.White;
                        Game[i, j].ForeColor = System.Drawing.Color.Gold;
                    }
                    
                }
            }

        }

    }
}
