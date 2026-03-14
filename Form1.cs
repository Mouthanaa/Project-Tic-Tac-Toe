using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private bool _GameOver = false;

        private void Tic_Tac_Toe(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // لون أبيض
            Pen pen = new Pen(Color.White, 5);

            pen.Width = 8;
            // مركز الدوران
            g.TranslateTransform(210, 50);

            // زاوية الميل
            g.RotateTransform(0); // غيّر الرقم لتعديل الميل

            // الخطوط العمودية
            g.DrawLine(pen, 200, 75, 200, 325);
            g.DrawLine(pen, 300, 75, 300, 325);

            // الخطوط الأفقية
            g.DrawLine(pen, 100, 150, 400, 150);
            g.DrawLine(pen, 100, 250, 400, 250);

            // إعادة التحويل للوضع الطبيعي
            g.ResetTransform();
        }

        public bool IsCellUsed(string check) 
        {
            return check != "?";
        }

        public bool IsGameOver() 
        {
            if (_GameOver) 
            {
                MessageBox.Show("Game Over!", MessageBoxIcon.Error.ToString());
                return true;
            }
            else 
            {
                return false;
            }

        }

        public void CheckWinner(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.Yellow;
            btn2.BackColor = Color.Yellow;
            btn3.BackColor = Color.Yellow;
            _GameOver = true;

            if(btn1.Text == "X") 
            {
                LbWinOrLoseOrDraw.Text = "Player1";
            }
            else 
            {
                LbWinOrLoseOrDraw.Text = "Player2";
            }
                LbCheckPlayer.Text = "Game Over";
        }

        public void Playing(Button btn) 
        {
            if (IsGameOver())
            {

                return;
            }
            if (IsCellUsed(btn.Text) == false)
            {
                btn.Text = CheckPlayer();
                btn.ForeColor = Color.YellowGreen;
                WhoWinOrDraw();

            }
            else
            {
                MessageBox.Show("Wrong Choose!", MessageBoxIcon.Error.ToString());
            }
        }

        public bool IsDraw() 
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name != "BtRestart" && btn.Text == "?")
                {
                    return false;
                }
            }

            return true;
        }

        public void Draw() 
        {
            _GameOver = true;
            LbWhoWinOrDraw.Text = "Draw";
            LbCheckPlayer.Text = "Game Over";

        }

        public bool WhoWinOrDraw() 
        {

            if (IsGameOver()) 
            {
                
                return false;
            }

                if (IsCellUsed(button2.Text))
            {
            
                    if (button2.Text == button3.Text && button2.Text == button4.Text)
                    {
                            CheckWinner(button2, button3, button4); 
                    } 
                    else if (button2.Text == button5.Text && button2.Text == button8.Text)
                    {
                        CheckWinner(button2, button5, button8);
                    }
                    else if (button2.Text == button6.Text && button2.Text == button10.Text)
                    {
                        CheckWinner(button2, button6, button10);
                    }
            }

            if (IsCellUsed(button3.Text))
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    CheckWinner(button3, button6, button9);
                }
            }
             if (IsCellUsed(button4.Text))
            {
                if (button4.Text == button6.Text && button4.Text == button8.Text)
                {
                    CheckWinner(button4, button6, button8);
                }
                else if(button4.Text == button7.Text && button4.Text == button10.Text) 
                {
                    CheckWinner(button4, button7, button10);
                }
            }if (IsCellUsed(button5.Text)) 
            {
                if (button5.Text == button6.Text && button5.Text == button7.Text)
                {
                    CheckWinner(button5, button6, button7);
                }
            } if (IsCellUsed(button8.Text)) 
            {
                if (button8.Text == button9.Text && button8.Text == button10.Text)
                {
                    CheckWinner(button8, button9, button10);
                }
            }

            if (IsDraw()) 
            {
                Draw();
            }



                return _GameOver;

        }

        public string CheckPlayer() 
        {
            if(LbCheckPlayer.Text == "Player1") 
            {
                LbCheckPlayer.Text = "Player2";
                return "X";
            }
            else 
            {
                LbCheckPlayer.Text = "Player1";
                return "O";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Playing(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Playing(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Playing(button4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Playing(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Playing(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Playing(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Playing(button8);
        }                                      
                                               
        private void button9_Click(object sender, EventArgs e)
        {
            Playing(button9);
        }                                      
                                               
        private void button10_Click(object sender, EventArgs e)
        {
            Playing(button10);
        }

        private void BtRestart_Click(object sender, EventArgs e)
        {
            _GameOver = false;
            LbCheckPlayer.Text = "Player1";
            LbWinOrLoseOrDraw.Text = "In Progress";
            LbWhoWinOrDraw.Text = "Winner";

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name != "BtRestart")
                {
                    btn.Text = "?";
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.Red;
                }
            }


        }
    }
}
