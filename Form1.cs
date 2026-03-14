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


            Pen pen = new Pen(Color.White, 5);

            pen.Width = 8;

            g.TranslateTransform(210, 50);

            g.RotateTransform(0); 

            
            g.DrawLine(pen, 200, 75, 200, 325);
            g.DrawLine(pen, 300, 75, 300, 325);

           
            g.DrawLine(pen, 100, 150, 400, 150);
            g.DrawLine(pen, 100, 250, 400, 250);

            
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

        public void Winner(Button btn1, Button btn2, Button btn3)
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
                CheckWinner();

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

        public bool CheckValue(Button btn1, Button btn2, Button btn3) 
        {
            if (IsCellUsed(btn1.Text) && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool CheckWinner() 
        {

            if (IsGameOver()) 
            {
                
                return false;
            }

            if(CheckValue(button1, button2, button3)) 
            {
                Winner(button1, button2, button3);
            }
            else if (CheckValue(button4, button5, button6)) 
            {
                Winner(button4, button5, button6);
            }
            else if (CheckValue(button7, button8, button9)) 
            {
                Winner(button7, button8, button9);
            }
            else if (CheckValue(button1, button4, button7)) 
            {
                Winner(button1, button4, button7);
            }
            else if (CheckValue(button2, button5, button8)) 
            {
                Winner(button2, button5, button8);
            }
            else if (CheckValue(button3, button6, button9)) 
            {
                Winner(button3, button6, button9);
            }
            else if (CheckValue(button1, button5, button9)) 
            {
                Winner(button1, button5, button9);
            }
            else if (CheckValue(button3, button5, button7)) 
            {
                Winner(button3, button5, button7);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Playing(button1);
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
