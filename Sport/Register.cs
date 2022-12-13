using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Register
    {
        private List<Player> allPlayers;
        public Register()
        {
            this.allPlayers = new List<Player>();
        }
        public Register(List<Player> players) : this()
        {
            foreach (Player player in players)
            {
                this.allPlayers.Add(player);
            }
        }
        public void Add(Player player)
        {
            allPlayers.Add(player);
        }
        public int Count()
        {
            return this.allPlayers.Count;
        }
        public Player Get(int index)
        {
            return this.allPlayers[index];
        }
        public bool Contains(Player player)
        {
            return this.allPlayers.Contains(player);
        }
        public double Average(List<Team> team, string city, out double BallAve)
        {
            double bsum = 0;
            double fsum = 0;
            double bcount = 0;
            double fcount = 0;
            double FootAve = 0;
            BallAve = 0;
            for (int i = 0; i < team.Count; i++)
            {
                if (team[i].City.Equals(city))
                {
                    foreach (Player player in this.allPlayers)
                    {
                        if (player is Basketball)
                        {
                            if (player.TeamName == team[i].TeamName)
                            {
                                bcount++;
                                bsum += player.Score;
                            }
                        }
                        else
                        {
                            if (player.TeamName == team[i].TeamName)
                            {
                                fcount++;
                                fsum += player.Score;
                            }
                        }
                    }
                }
            }
            FootAve = fsum / fcount;
            BallAve = bsum / bcount;
            return FootAve;
        }
        public Register Selection(List<Team> team, string city)
        {
            double BallAve;
            Register final = new Register();
            double FootAve = this.Average(team, city, out BallAve);
            for (int i = 0; i < team.Count; i++)
            {
                Team currentTeam = team[i];
                foreach (Player player in this.allPlayers)
                {
                    if (player is Basketball && currentTeam.City==city && currentTeam.TeamName.Equals(player.TeamName) && player.PlayedGames == currentTeam.Games && player.Score >= BallAve)
                    {
                        final.Add(player);
                    }
                    else if (player is Football && currentTeam.City == city && currentTeam.TeamName.Equals(player.TeamName) && player.PlayedGames == currentTeam.Games && player.Score >= FootAve)
                    {
                        final.Add(player);
                    }
                }
            }
            return final;
        }

    }
}
