using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Basketball : Player
    {
        public int BallsDef { get; set; }
        public int Pass { get; set; }
        public Basketball(string teamName, string name, string surname, DateTime birtdate, int playedGames, int score, int ballsDef, int pass):
            base(teamName,name,surname,birtdate,playedGames,score)
        {
            this.BallsDef = ballsDef;
            this.Pass = pass;
        }
     
    }
}
