using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Team
    {
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }
        public int Games { get; set; }
        public Team(string teamName, string city, string coach, int games)
        {
            this.TeamName = teamName;
            this.City = city;
            this.Coach = coach;
            this.Games = games;
        }
    }
}
