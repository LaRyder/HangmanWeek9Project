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
        public UserInterface ui;
        private bool Lose;
        private bool Win;
        public void Results()
        {
            if (Lose == true)
            {
                ui.Write("You Lose!\nPress Enter to Quit: ");
                ui.Input();
            }
            if (Win == true) // when bool becomes true
            {
                ui.Write("You Win!\nPress Enter to Quit: ");
                ui.Input();
            }
        }
    }
}
