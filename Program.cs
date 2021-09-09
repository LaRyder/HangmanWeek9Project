using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman, Let's play!");
           
            string[] HangmanWords = new string [1];

            HangmanWords[0] = "apple";

            Random wordGuess = new Random();

            var words = wordGuess.Next(0, 1);

            string correctAnswer = HangmanWords[words];

            char[]guessedLetters = new char[correctAnswer.Length];

            Console.Write("Please enter a letter to guess: ");
           

            for (int i = 0; i < correctAnswer.Length; i++)
                guessedLetters[i] ='*';

            while (true)
            {
                char userInput = char.Parse(Console.ReadLine());
                for (int k = 0; k < correctAnswer.Length; k++)

                {
                    if (userInput == correctAnswer[k])
                        guessedLetters[k] = userInput;
                }
                    Console.WriteLine(guessedLetters);
            }
        }
    }
}
