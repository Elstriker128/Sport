using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Football : Player
    {
        public int YellowCards { get; set; }
        public Football(string teamName, string name, string surname, DateTime birtdate, int playedGames, int score, int yellowCards):
            base(teamName, name, surname, birtdate, playedGames, score)
        {
            this.YellowCards = yellowCards;
        }
        
    }
}
