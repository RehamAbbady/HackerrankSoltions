using System;

namespace Comparator
{
    public class Player
    {
        string name;
        int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public static int Compare(Player a, Player b)
        {
            if (a.score < b.score)
            {
                return 1;
            }
            else if (a.score > b.score)
            {
                return -1;
            }
            else
            {
                return a.name.CompareTo(b.name);
            }
        }
    }



   
class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("reham", 50);
            Player p2 = new Player("molly", 50);
            Console.WriteLine(Player.Compare(p2, p1));

        }
    }
}
