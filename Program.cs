using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTestingExercise
{
    class Program
    {
        public static List<Player> playerList()
        {
            List<Player> listPlayers = new List<Player>
            {
                new Player{PlayerId=1,PlayerName="Rohit Sharma",PlayerTeam="India"},
                new Player{PlayerId=2,PlayerName="David Warner",PlayerTeam="Australia"},
                new Player{PlayerId=3,PlayerName="Virat Kohli",PlayerTeam="India"},
            };
            return listPlayers;
        }
        static void Main(string[] args)
        {
        }
    }
}
