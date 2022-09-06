using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gameList = new List<string>() { "Call of Duty: Black Ops", "Super Mario Kart", "Pokemon", "Mortal Kombat" , "Madden" };
            //gameList.Add("Call of Duty: Black Ops");
            //gameList.Add("Super Mario Kart");
            //gameList.Add("Pokemon");
            //gameList.Add("Mortal Kombat");
            //gameList.Add("Madden");

            gameList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
