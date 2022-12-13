using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public abstract class Player
    {
        public string TeamName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birtdate { get; set; }
        public int PlayedGames { get; set; }
        public int Score { get; set; }
        public Player(string teamName, string name, string surname, DateTime birtdate, int playedGames, int score)
        {
            TeamName = teamName;
            Name = name;
            Surname = surname;
            Birtdate = birtdate;
            PlayedGames = playedGames;
            Score = score;
        }
        public override string ToString()
        {
            string info;
            info = string.Format("| {0,-15} | {1,-8} | {2,-15} | {3,-12:yyyy-MM-dd} | {4,-12} | {5,-8} |",
                     this.TeamName, this.Name, this.Surname, this.Birtdate, this.PlayedGames, this.Score);
            return info;
        }

    }
}
