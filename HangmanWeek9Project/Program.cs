using System;
using System.Collections.Generic;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman, Let's play!");
            Console.Write("Please enter a letter: ");
            Console.ReadLine();

            var answer = new List<string>()
            {
               "Apple",
            };

            char[] letterbank = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        }
    }
}
