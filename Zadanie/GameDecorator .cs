using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class GameDecorator : IGame
    {
        private readonly Team team;
        private readonly IGame game;

        public GameDecorator(Team team, IGame game)
        {
            this.team = team;
            this.game = game;
        }

        public void Play()
        {
            team.PlayGame();

            Console.WriteLine("Новая игра:");
            game.Play();
        }
    }
}
