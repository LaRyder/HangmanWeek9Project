using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class UserInterface
    {
        public void Tell(string tell)
        {
            throw new NotImplementedException();
        }

        public void Write(string toCon)
        {
            Console.Write(toCon);
        }
        public void Input()
        {
            Console.ReadLine();
        }
    }
}
