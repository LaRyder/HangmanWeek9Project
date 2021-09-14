using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Guess
    {
        private UserInterface userinterface;
        private List<char> guesses = new List<char>();
        private string answer;
        private int lives;
        private char letter;

        public Guess(int lives, string answer)
        {
            userinterface = new UserInterface();
            this.lives = lives;
            this.answer = answer;
        }

        //Welcome Message
        public void DisplayWelcome()
        {
            HideAnswer();
            userinterface.Tell($"Welcome to Hangman, Let's Play!\nThe words is {HideAnswer()}");
        }
        //Tells the user whether or not the guess was correct, and how my many lives are left
        public void GuessCheck()
        {
            letter = userinterface.Input("Please enter a letter to guess: ");
            var correct = IsLetterInAnswer(letter);

            if (correct)
            {
                guesses.Add(letter);
                userinterface.Tell("You got it!");
            }
            else
            {
                lives--;
                userinterface.Tell($"Incorrect! You have {lives} guesses remaining.");
            }
        }

        public bool IsLetterInAnswer(char letter)
        {
            return answer.Contains(letter);
        }
       
        public void WordSoFar()
        {
            userinterface.Tell($"{HideAnswer()}");
        }
        //Hides the answer until a letter is guessed correctly
        public string HideAnswer()
        {
            var sb = new StringBuilder();

            foreach (var let in answer)
            {
                if (guesses.Contains(let))
                {
                    sb.Append(let);
                }
                else
                {
                    sb.Append("* ");
                }
            }
            return sb.ToString();
        }


        //Displays how many lives are remaining
        public void DisplayLives()
        {
            userinterface.Tell($"You have {lives} guesses remaining.");
        }

       //When guessed incorectly, takes away a life
        public bool Death()
        {
            return lives < 1;
        }

        //If guessed correctly, returns a letter for the random word
        public bool CheckWin()
        {
            foreach (var let in answer)
            {
                if (!guesses.Contains(let)) return false;
            }
            return true;
        }
    }
}
