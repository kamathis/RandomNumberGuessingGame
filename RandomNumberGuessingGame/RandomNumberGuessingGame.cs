using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================
 Kristi Mathis

 Windows 10

 Microsoft Visual Studio 2017 Community Edition
 CIS 169
 Chapter 05 Programming Assignment
 This program generates a random number between 1 and 100,
 then asks the user for a guess and depending on if the guess 
 is too high, too low, or correct, displays a message. On a 
 correct guess the number of guesses is also displayed, and then
 the program resets so the game can start over.


 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

namespace RandomNumberGuessingGame
{
    public partial class RandomNumberGuessingGame : Form
    {
        public RandomNumberGuessingGame()
        {
            InitializeComponent();

        }

        //variables
        int number = 0;
        int count = 1;

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int guess = 0;

            //Try to parse the textbox
            if (int.TryParse(guessTextBox.Text, out guess))
            {
                //guess is too high
                if (guess > number)
                {
                    resultLabel.Text = "Too high, try again.";
                    guessTextBox.Text = "";
                    guessTextBox.Focus();
                    count++;
                }
                //guess is too low
                if (guess < number)
                {
                    resultLabel.Text = "Too low, try again.";
                    guessTextBox.Text = "";
                    guessTextBox.Focus();
                    count++;
                }
                //Displays correct message, number of guesses, generates new random number, and resets guess counter
                while (guess == number)
                {
                    resultLabel.Text = "Congratulations! It took you " + count + " guesses to correctly guess the number.";
                    guessTextBox.Text = "";
                    guessTextBox.Focus();
                    Random rand = new Random();
                    number = rand.Next(100) + 1;
                    count = 1;
                }
            }
            else 
            {
                //A number wasn't entered
                MessageBox.Show("Enter a valid number");        
            }
        }
            

        private void RandomNumberGuessingGame_Load(object sender, EventArgs e)
        {
            //Generate a random number between 1-100
            Random rand = new Random();
            number = rand.Next(100) + 1;
        }
    }
}

