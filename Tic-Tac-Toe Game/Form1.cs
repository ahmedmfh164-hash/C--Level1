using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Custom;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Custom;


            e.Graphics.DrawLine(Pen, 496, 117, 496, 516);
            e.Graphics.DrawLine(Pen, 681, 117, 681, 516);

            e.Graphics.DrawLine(Pen, 319, 251, 858, 251);
            e.Graphics.DrawLine(Pen, 319, 386, 858, 386);



        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {


            if (btn1.Text != "?" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Text == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;


        }

        void EndGame()
        {

            lblTurnPlayer.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lblPlayerWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lblPlayerWinner.Text = "Player2";
                    break;

                default:

                    lblPlayerWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void CheckWinner()
        {


            //checked rows
            //check Row1
            if (CheckValues(btnNum1, btnNum2, btnNum3))
                return;

            //check Row2
            if (CheckValues(btnNum4, btnNum5, btnNum6))
                return;

            //check Row3
            if (CheckValues(btnNum7, btnNum8, btnNum9))
                return;

            //checked cols
            //check col1
            if (CheckValues(btnNum1, btnNum4, btnNum7))
                return;

            //check col2
            if (CheckValues(btnNum2, btnNum5, btnNum8))
                return;

            //check col3
            if (CheckValues(btnNum3, btnNum6, btnNum9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(btnNum1, btnNum5, btnNum9))
                return;

            //check Diagonal2
            if (CheckValues(btnNum3, btnNum5, btnNum7))
                return;


        }

        void Change(Button button)
        {
            if (button.Text=="?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        button.Text="X";
                        button.ForeColor=Color.Yellow;
                        PlayerTurn= enPlayer.Player2;
                        lblTurnPlayer.Text = "Player 2";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        button.Text="O";
                        button.ForeColor=Color.SpringGreen;
                        PlayerTurn = enPlayer.Player1;
                        lblTurnPlayer.Text = "Player 1";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }

            else

            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount ==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

         
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
         Change((Button)sender);
        }


        private void RestButton(Button btn)
        {
            btn.Text="?";
            btn.ForeColor=Color.Red;
            btn.BackColor=Color.Black;

        }
        private void RestartGame()
        {

            RestButton(btnNum1);
            RestButton(btnNum2);
            RestButton(btnNum3);
            RestButton(btnNum4);
            RestButton(btnNum5);
            RestButton(btnNum6);
            RestButton(btnNum7);
            RestButton(btnNum8);
            RestButton(btnNum9);

            PlayerTurn = enPlayer.Player1;
            lblTurnPlayer.Text = "Player 1";
            GameStatus.PlayCount =0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblPlayerWinner.Text = "In Progress";



        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();

        }





    }
}
