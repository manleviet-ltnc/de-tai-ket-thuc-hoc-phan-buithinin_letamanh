using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreesGame
{
    public partial class Form1 : Form
    {
        Boolean up = false, down = false, right = false, left = false;
        Random Rd = new Random();
        static ArrayList mangChiSoRong = new ArrayList();
        bool dangChoi = false;
        Label[,] game;

        public Form1()
        {
            InitializeComponent();
            game = new Label[,] {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up && down == false)
            {
                up = true;
                down = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                up = false;
                down = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                up = false;
                down = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                up = false;
                down = false;
                right = false;
                left = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            lbl17.Text = "0";
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            btnExit.Visible = false;
            dangChoi = true;
            btnNew.Visible = false;
            btnNew.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "";
                }
            }
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continueToolStripMenuItem.Visible = true;
            lblScore.Visible = true;
            lbl17.Visible = true;

            if (dangChoi == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            }
            dangChoi = true;
            lbl17.Text = "0";
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            btnExit.Visible = false;
            btnNew.Visible = false;
            btnNew.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = true;
                    Game[i, j].Text = "";
                }
            }
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblScore.Visible = true;
            lbl17.Visible = true;

            if (dangChoi == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            }
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            btnExit.Visible = false;
            btnNew.Visible = false;
            btnNew.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void CapNhatMau()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (game[i, j].Text == "")
                    {
                        game[i, j].BackColor = System.Drawing.Color.CadetBlue;
                    }
                    if (game[i, j].Text == "1")
                    {
                        game[i, j].BackColor = System.Drawing.Color.SkyBlue;
                        game[i, j].ForeColor = System.Drawing.Color.White;

                    }
                    if (game[i, j].Text == "2")
                    {
                        game[i, j].BackColor = System.Drawing.Color.Pink;
                        game[i, j].ForeColor = Color.White;

                    }
                    if (game[i, j].Text == "3")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (game[i, j].Text == "6")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (game[i, j].Text == "12")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (game[i, j].Text == "24")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (game[i, j].Text == "48")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Black;
                    }
                    if (game[i, j].Text == "96")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Pink;
                    }
                    if (game[i, j].Text == "192")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Pink;
                    }
                    if (game[i, j].Text == "384")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Yellow;
                    }
                    if (game[i, j].Text == "768")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Yellow;
                    }
                    if (game[i, j].Text == "1536")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Gold;
                    }
                    if (game[i, j].Text == "3042")
                    {
                        game[i, j].BackColor = System.Drawing.Color.White;
                        game[i, j].ForeColor = System.Drawing.Color.Gold;
                    }

                }
            }

        }

        public void KhoiTaoManGame()
        {
            mangChiSoRong.Clear();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (game[i, j].Text == "")
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
                if (NgauNhien == 1 || NgauNhien == 2 || NgauNhien == 3 || NgauNhien == 4)
                {
                    game[i0, j0].Text = "1";
                }
                else if (NgauNhien == 5 || NgauNhien == 6 || NgauNhien == 7)
                {
                    game[i0, j0].Text = "2";
                }
                else
                {
                    game[i0, j0].Text = "3";
                }
            }
            CapNhatMau();
        }

        private void FrmThreesGame_Load(object sender, EventArgs e)
        {
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();
            KhoiTaoManGame();

        }
       

    }
}
