using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class Form1 : Form
    {

        int movesCount = 0;
        private bool playerXturn = true;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            // Add click event handler for each button
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Click += button1_Click;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            // If the button is already clicked, do nothing
            if (button.Text != "")
                return;

            // Set X or O based on the player's turn
            button.Text = playerXturn ? "X" : "O";

            // Check for winner
            if (CheckForWinner())
            {
                MessageBox.Show((playerXturn ? "X" : "O") + " wins!");
                ResetGame();
                return;
            }

            // Increment moves count
            movesCount++;

            // Check for draw
            if (movesCount == 9)
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
                return;
            }

            // Switch player's turn
            playerXturn = !playerXturn;


        }
        private bool CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(button1.Text, button2.Text, button3.Text))
                    return true;
                if (CheckLine(button4.Text, button5.Text, button6.Text))
                    return true;
                if (CheckLine(button7.Text, button8.Text, button9.Text))
                    return true;
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(button1.Text, button4.Text, button7.Text))
                    return true;
                if (CheckLine(button2.Text, button5.Text, button8.Text))
                    return true;
                if (CheckLine(button3.Text, button6.Text, button9.Text))
                    return true;
            }

            // Check diagonals
            if (CheckLine(button1.Text, button5.Text, button9.Text))
                return true;
            if (CheckLine(button3.Text, button5.Text, button7.Text))
                return true;

            return false;
        }

        private bool CheckLine(string a, string b, string c)
        {
            return !string.IsNullOrWhiteSpace(a) && a == b && b == c;
        }

        private void ResetGame()
        {
            
         
                // Clear button text
                foreach (Control control in Controls)
                {
                    if (control is Button button)
                    {
                        button.Text = "";
                    }
                }

                // Reset game variables
                playerXturn = true;
                movesCount = 0;
          

        }

    }
}   

