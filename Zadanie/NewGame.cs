using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class NewGame : IGame
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public NewGame()
        {

        }
        public NewGame(string name)
        {
            this.name = name;
        }
        public void Play()
        {
            if (name == null)
            {
                Console.WriteLine("Новая игра");
            }
            else
            {
                Console.WriteLine($"Игра в {name}");
            }
        }
    }
}
