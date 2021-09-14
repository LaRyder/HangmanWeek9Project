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
        private Game game;
        int guesses = 6;

        private void GuessLoop()
        {
            GuessTime();
        }
        public void GuessTime()
        {
            var continueGame = true;

            while (continueGame)
            {
                DisplayInformation();
               // ShowGameInfo();
                Guess();
            }
        }

        private void DisplayInformation()
        {
            var Answer = game.Answer();
            userinterface.Tell(Answer);
        }

        private void Guess()
        {
            var guess = ui.AskforChar("Please enter a letter to guess: ");
            var correct = game.IsLetterInAnwer(guess);

            if (correct)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                guesses--;
                Console.WriteLine($"Incorrect! You have {guesses} remaining.");
            }
        }
    }
}
