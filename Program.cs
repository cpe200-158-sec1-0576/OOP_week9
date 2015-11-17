using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Game.Setting(player1, player2);
            do
                Game.Play(player1, player2);
            while (player1.PlayedDeck.Cards.Count != 0);
            Game.WhoWinGame(player1, player2);
            System.Console.ReadKey();
        }
    }
}
