using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Game
    {
        private UserInterface userinterface;
        private Dictionary dictionary;
        private Guess guess;
        private Result result;
        public string answer;
        private int guesses;

        public Game()
        {
            userinterface = new UserInterface();
            dictionary = new Dictionary();
            this.answer = dictionary.GetAnswer();
            this.guesses = 6;
        }

        public void Run()
        {
            HideAnswer();
            userinterface.Write($"Welcome to Hangman, Let's Play!\nThe words is {HideAnswer()}\nYou have {guesses} remaining\n");
        }

        public string HideAnswer()
        {
            var sb = new StringBuilder();

            foreach (var foo in answer) //for loop to add * for each char in the string
            {
                {
                    sb.Append("* "); //this takes the place of numbers in GuessDisplay List
                }
            }
            return sb.ToString();
        }
    }
}
