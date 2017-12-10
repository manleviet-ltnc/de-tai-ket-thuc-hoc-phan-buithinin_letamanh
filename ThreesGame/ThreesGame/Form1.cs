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
    public partial class frmThreesGame : Form
    {
        SoundPlayer sound = new SoundPlayer(Application.StartupPath + "/andiem.wav");
        SoundPlayer sound2 = new SoundPlayer(Application.StartupPath + "/blip.wav");
        Random Rd = new Random();
        bool dangChoi = true;
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
                        Game[i, j].ForeColor = Color.White;

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
                if (NgauNhien == 1 || NgauNhien == 2 || NgauNhien == 3 || NgauNhien == 4)
                {
                    Game[i0, j0].Text = "1";
                }
                else if (NgauNhien == 5 || NgauNhien == 6 || NgauNhien == 7)
                {
                    Game[i0, j0].Text = "2";
                }
                else
                {
                    Game[i0, j0].Text = "3";
                }
            }
            CapNhatMau();
        }

        public void LenTren()
        {
            bool khongLenDuoc = true;
            bool anDiem = false;
            bool kTraKhoiTao = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int oRong = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                anDiem = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j; m >= 0; m--)
                        {
                            if (Game[m, i].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool ktra = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        khongLenDuoc = false;
                                        lbl17.Text = (int.Parse(lbl17.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            Game[j - oRong, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                khongLenDuoc = false;
                                Game[j - oRong, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                khongLenDuoc = false;
                                Game[j - oRong, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                    }

                }
            }

            if (khongLenDuoc == false && anDiem == true)
            {
                sound.Play();
            }
            if (khongLenDuoc == false && anDiem == false)
            {
                sound2.Play();
            }
            if (kTraKhoiTao == true)
            {
                KhoiTaoManGame();
            }
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
        public void XuongDuoi()
        {
            bool khongXuongDuoc = true;
            bool anDiem = false;
            bool kTraKhoiTao = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int oRong = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                anDiem = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j + 1; m <= 3; m++)
                        {
                            if (Game[m, i].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool ktra = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        khongXuongDuoc = false;
                                        lbl17.Text = (int.Parse(lbl17.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        ktra = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            Game[j + oRong, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                khongXuongDuoc = false;
                                Game[j + oRong, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                khongXuongDuoc = false;
                                Game[j + oRong, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
            if (khongXuongDuoc == false && anDiem == true)
            {
                sound.Play();
            }
            if (khongXuongDuoc == false && anDiem == false)
            {
                sound2.Play();
            }
            if (kTraKhoiTao == true)
            {
                KhoiTaoManGame();
            }
        }

        public bool KetThuc()
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
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, j].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[j, i].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[j, i].Text == Game[k, i].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }

        private void frmThreesGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (KetThuc() == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    LenTren();

                }
                if (e.KeyCode == Keys.Down)
                {
                    XuongDuoi();
                }
            }
            else
            {
                continueToolStripMenuItem.Visible = false;
                dangChoi = false;
                btnNew.Visible = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
                btnNew.Enabled = true;
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.frmThreesGame_KeyDown);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThreesGame_KeyDown);
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
    }
}
