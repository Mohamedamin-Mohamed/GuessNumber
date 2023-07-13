using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Number_Game
{
    public partial class Form1 : Form
    {
        int number = 0;
        static string message;
        static int random = 0;

        //these variable will calculate the difference between the user guessed number and the previous one
        static int difference = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            check();
        }
        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(GuessTextBox.Text);
                if (random - number < difference)
                {
                    GuessTextBox.BackColor = Color.Blue;
                }
                else
                {
                    GuessTextBox.BackColor = Color.Red;
                }
                if (number > random)
                {
                    message = "Too high";
                    GuessTextBox.Focus();
                }
                else if (number < random)
                {
                    message = "Too low";
                    GuessTextBox.Focus();
                }
                else
                {
                    message = "Correct";
                    GuessTextBox.BackColor = Color.Green;
                    GuessButton.Enabled = false;
                }
                DisplayLabel.Text = message;
                difference = random - number;
            }
            catch (Exception ex)
            {
                DisplayLabel.Text = ex.Message;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            var randGen = new Random();
            random = randGen.Next(1, 1001);

            //we assign random with 800 for testing purposes
            random = 600;
            GuessButton.Enabled = true;
            GuessTextBox.Clear();
            GuessTextBox.BackColor = Color.White;
            DisplayLabel.Text = "";
            GuessTextBox.Focus();
        }

       
    }
}
