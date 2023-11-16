using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class Team
    {
         private List<Player> players;
        public List<Player> Players
        { 
            get 
            { 
                return players; 
            } 
        }
        private List<IGame> strategies;
        public List<IGame> Strategies
        {
            get
            {
                return strategies;
            }
        }
        public Team()
        {

        }
        public Team(List<Player> players)
        {
            this.players = players;
        }
        public Team(List<Player> players,List<IGame> strategies)
        {
            this.players = players;
            this.strategies = strategies;
        }
        public void AddGame(IGame game)
        {
            strategies.Add(game);
        }

        public void PlayGame()
        {
            foreach (var game in strategies)
            {
                game.Play();
            }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
