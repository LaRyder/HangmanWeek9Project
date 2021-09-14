using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    //Contains the win and lose statements
    class Result
    {
        public UserInterface userInterface;
        public Result()
        {
            userInterface = new UserInterface();
        }

        public void Win()
        {
            userInterface.Tell("You win!\nPress Enter to Quit: ");
            Console.ReadKey();
        }

        public void Lose()
        {
            userInterface.Tell("You Lose!\nPress Enter to Quit: ");
            Console.ReadKey();
        }
    }
}
