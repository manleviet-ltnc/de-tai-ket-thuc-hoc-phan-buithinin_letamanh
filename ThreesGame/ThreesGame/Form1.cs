using System;
using System.Collections;
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
        static ArrayList mangChiSoRong = new ArrayList();

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

        public void KhoiTaoManGame()
        {
            mangChiSoRong.Clear();

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
                        mangChiSoRong.Add(i * 4 + j + 1);
                    }
                }
            }

            if (mangChiSoRong.Count > 0)
            {

                int chiSoHinh = int.Parse(mangChiSoRong[Rd.Next(0, mangChiSoRong.Count - 1)].ToString());
                int i0 = (chiSoHinh - 1) / 4;
                int j0 = (chiSoHinh - 1) - i0 * 4;
                int NgauNhien = Rd.Next(1, 10);
                if (NgauNhien == 1 || NgauNhien == 2 || NgauNhien == 3 || NgauNhien == 4 || NgauNhien == 5 || NgauNhien == 6)
                {
                    Game[i0, j0].Text = "1";
                }
                else
                {
                    Game[i0, j0].Text = "2";
                }

            }
            CapNhatMau();
        }

        private void frmThreesGame_Load(object sender, EventArgs e)
        {
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
        }
    }
}
