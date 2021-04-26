using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string playerA_choice;
        string playerB_choice;
        int playerA_score;
        int playerB_score;
        int random_value;
        int quits_value;
        Random random_number = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Score();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            Player_A.Image = Properties.Resources.rock_png; 
            playerA_choice = "rock";
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            Player_A.Image = Properties.Resources.paper_png;
            playerA_choice = "paper";
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            Player_A.Image = Properties.Resources.scissors_png;
            playerA_choice = "scissors";
        }

        private void Player_A_Click(object sender, EventArgs e)
        {
            
        }
        private void PlayerBChoice()
        {
            random_value = random_number.Next(1, 4);
            if (random_value == 1)
            {
                Player_B.Image = Properties.Resources.rock_png;
                playerB_choice = "rock";
            }
            else if (random_value == 2)
            {
                Player_B.Image = Properties.Resources.paper_png;
                playerB_choice = "paper";


            }
            else if (random_value == 3)
            {
                Player_B.Image = Properties.Resources.scissors_png;
                playerB_choice = "scissors";
            }
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            if (playerA_score == 0 && playerB_score == 0)
            {
                label2.Visible = false;
                WinnerTable.Visible = false;
                ScoreA.Text = "0";
                ScoreB.Text = "0";
                quits_number.Text = "0";

            }
            if (playerA_choice == null)
            {
                MessageBox.Show("Please select a move", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PlayerBChoice();
            }
            Score();
        }
        private void Score()
        {
            if (playerA_choice == "rock" && playerB_choice == "paper")
            {
                playerB_score++;
                ScoreB.Text = playerB_score.ToString();

            }
            if (playerA_choice == "rock" && playerB_choice == "scissors")
            {
                playerA_score++;
                ScoreA.Text = playerA_score.ToString();

            }
            if (playerA_choice == "rock" && playerB_choice == "paper")
            {
                playerB_score++;
                ScoreB.Text = playerB_score.ToString();

            }
            if (playerA_choice == "paper" && playerB_choice == "rock")
            {
                playerA_score++;
                ScoreA.Text = playerA_score.ToString();

            }
            if (playerA_choice == "paper" && playerB_choice == "scissors")
            {
                playerB_score++;
                ScoreB.Text = playerB_score.ToString();

            }
            if (playerA_choice == "scissors" && playerB_choice == "rock")
            {
                playerB_score++;
                ScoreB.Text = playerB_score.ToString();

            }
            if (playerA_choice == "scissors" && playerB_choice == "paper")
            {
                playerA_score++;
                ScoreA.Text = playerA_score.ToString();

            }
            if (playerA_choice == "rock" && playerB_choice == "rock")
            {
                quits_value++;
                quits_number.Text = quits_value.ToString();

            }
            if (playerA_choice == "paper" && playerB_choice == "paper")
            {
                quits_value++;
                quits_number.Text = quits_value.ToString();

            }
            if (playerA_choice == "scissors" && playerB_choice == "scissors")
            {
                quits_value++;
                quits_number.Text = quits_value.ToString();

            }
            if (playerA_score + playerB_score + quits_value == 100)
            {
                label2.Visible = true;
                WinnerTable.Visible = true;
                if (playerA_score > playerB_score)
                {
                    label2.Text = "Player A wins" + playerA_score + "of 100 games Player B wins" + playerB_score + "of 100 games" + "Tie:" + quits_number + "of 100 games";
                    playerA_score = 0;
                    playerB_score = 0;
                   
                    Player_A.Image = null;
                    Player_B.Image = null;
                    playerA_choice = null;
                    playerB_choice = null;
                }
                else if (playerB_score > playerA_score)
                {
                    label2.Text = "Player B wins" + playerB_score + "of 100 games" + " Player A wins" + playerA_score + "of 100 games" + "Tie:" + quits_number + "of 100 games"; ;
                    playerA_score = 0;
                    playerB_score = 0;
                  
                    Player_A.Image = null;
                    Player_B.Image = null;
                    playerA_choice = null;
                    playerB_choice = null;


                }
                else if (playerB_score == playerA_score)
                {
                  
                    label2.Text = "Quits";
                 
                    playerA_score = 0;
                    playerB_score = 0;

                    Player_A.Image= null;
                    Player_B.Image = null;
                    playerA_choice = null;
                    playerB_choice = null;


                }
            }

        }

        private void Player_B_Click(object sender, EventArgs e)
        {

        }

        private void Result_Table_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ScoreA_Click(object sender, EventArgs e)
        {

        }
    }
}
