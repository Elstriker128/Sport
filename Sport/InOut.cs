using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;
using System.Reflection.Emit;
using System.Net;

namespace Sport
{
    public class InOut
    {
        public static Register ReadPlayers(string filename)
        {
            Register register = new Register();
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string teamName = values[0];
                string name = values[1];
                string surname = values[2];
                DateTime birtdate = DateTime.Parse(values[3]);
                int playedGames = int.Parse(values[4]);
                int score = int.Parse(values[5]);
                int both = int.Parse(values[6]);
                if (values[7].Length != 0)
                {
                    int ballsDef = both;
                    int pass = int.Parse(values[7]);
                    Basketball ballPlayer = new Basketball(teamName, name, surname, birtdate, playedGames, score, ballsDef, pass);
                    if (!register.Contains(ballPlayer))
                    {
                        register.Add(ballPlayer);
                    }

                }
                else
                {
                    int yellowCards = both;
                    Football footPlayer = new Football(teamName, name, surname, birtdate, playedGames, score, yellowCards);
                    if (!register.Contains(footPlayer))
                    {
                        register.Add(footPlayer);
                    }
                }
            }
            return register;
        }
        public static List<Team> ReadTeamInfo(string filename)
        {
            List<Team> teamInfo = new List<Team>();
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string teamName = values[0];
                string city = values[1];
                string coach = values[2];
                int games = int.Parse(values[3]);
                Team singular = new Team(teamName, city, coach, games);
                teamInfo.Add(singular);
            }
            return teamInfo;
        }
        public static void PrintPlayers(string label, Register found)
        {
            Console.WriteLine(new string('-', 98));
            Console.WriteLine("| {0,-94} |", label);
            Console.WriteLine(new string('-', 98));
            for (int i = 0; i < found.Count(); i++)
            {
                Player current = found.Get(i);
                if (current is Basketball)
                {
                    Console.WriteLine("| {0,-15} | {1,-8} | {2,-15} | {3,-12:yyyy-MM-dd} | {4,-12} | {5,-8} | {6,-16} | {7,-8} |",
            "Team", "Name", "Surname", "Birthdate", "Played Games", "Score","Balls Defended", "Passes");
                    Basketball ballPlayer = (Basketball)current;
                    Console.WriteLine("{0} {1,-16} | {2,-8} |", ballPlayer.ToString(), ballPlayer.BallsDef, ballPlayer.Pass);
                    Console.WriteLine();
                }
                else if (current is Football)
                {
                    Console.WriteLine("| {0,-15} | {1,-8} | {2,-15} | {3,-12:yyyy-MM-dd} | {4,-12} | {5,-8} | {6,-12} |",
            "Team", "Name", "Surname", "Birthdate", "Played Games", "Score", "Yellow Card");
                    Football footPlayer = (Football)current;
                    Console.WriteLine("{0}  {1,-11} |", footPlayer.ToString(), footPlayer.YellowCards);
                    Console.WriteLine();
                }
            }
        }
    }
}
