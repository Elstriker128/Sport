using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1257);
            Console.OutputEncoding = Encoding.GetEncoding(1257);
            Encoding.GetEncoding(1257);
            Console.Write("Input city:");
            string chosenCity = Console.ReadLine();
            Register register = InOut.ReadPlayers(@"Data.txt");
            List<Team> list = InOut.ReadTeamInfo(@"Team.txt");
            Register final = register.Selection(list, chosenCity);
            InOut.PrintPlayers("Final picks",final);
        }
    }
}
