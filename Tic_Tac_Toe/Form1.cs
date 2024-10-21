using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        Boolean checker;
        int plusone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button button in buttons)
            {
                button.Enabled = true; 
            }

            // Reset the score 
            button13.Text = "Player X:";
            button14.Text = "Player O:";
        }


        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void HighlightWinningButtons(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Gold;
            b2.BackColor = Color.Gold;
            b3.BackColor = Color.Gold;

            MessageBox.Show($"The Player {b1.Text} wins the match", "Tic Tac Toe");

            // Update the correct player's score
            if (b1.Text == "X")
            {
                plusone = int.Parse(button15.Text); // Player X score
                button15.Text = Convert.ToString(plusone + 1);
            }
            else if (b1.Text == "O")
            {
                plusone = int.Parse(button16.Text); // Player O score
                button16.Text = Convert.ToString(plusone + 1);
            }

            Enable_False();
        }

        void score()
        {
            // Horizontal checks
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                HighlightWinningButtons(button1, button2, button3);
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                HighlightWinningButtons(button4, button5, button6);
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                HighlightWinningButtons(button7, button8, button9);

            // Vertical checks
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                HighlightWinningButtons(button1, button4, button7);
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                HighlightWinningButtons(button2, button5, button8);
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                HighlightWinningButtons(button3, button6, button9);

            // Diagonal checks
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                HighlightWinningButtons(button1, button5, button9);
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                HighlightWinningButtons(button3, button5, button7);

            // Check for a tie
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("It's a tie!", "Tic Tac Toe");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            try
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button13.Text = "Player X:";
                button14.Text = "Player O:";

                // Reset score labels
                button15.Text = "0"; // Reset Player X score
                button16.Text = "0"; // Reset Player O score


                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;


            }

          

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe");
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                NewGame.Enabled = true;

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;

                checker =false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe");
            }
        
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure you want to exit?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe");
            }
        }

        private void Reset_Click()
        {
           
            foreach (var control in Controls)
            {
                if (control is Button button && button.Name.StartsWith("button") && button.Name != "button15" && button.Name != "button16")
                {
                    button.Enabled = true;
                    button.Text = "";
                    button.BackColor = Color.White;
                }
            }

            // Reset button15 and button16 
            button15.Text = "0"; // Reset Player X score
            button16.Text = "0"; // Reset Player O score

            checker = false; // Reset the player turn to "X"
        }

    }
}

