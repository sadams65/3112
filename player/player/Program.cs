using System;
namespace HelloWorld
{

    public class Team
    {
        public Team(string name, int teamSize)
        {
            Name = name;
            
            TeamSize = teamSize;
            Players = new Player[teamSize];
        }



        public string Name { get; set; }
        
        public int TeamSize { get; set; }
        public Player[] Players { get; set; }
    }



    public class Player
    {
        public Player(string name, int number, string position)
        {
            Name = name;
            Number = number;
            Position = position;
        }



        public string Name { get; }
        public int Number { get; set; }
        public string Position { get; set; }
    }

    

    public class DoIt
    {
        public DoIt()
        {
            string sizeInput;
            int teamSize;
            string plyrNum;
            int number;
            string position;
            
            //Inside a constructor u do not write code that does logic
            Console.Write("Please enter the team name: ");
            string teamName = Console.ReadLine();
            do
            {
                Console.Write("Please enter the amount of players: ");
                sizeInput = Console.ReadLine();
            } while (!int.TryParse(sizeInput, out teamSize));    

            Team t = new Team(teamName, teamSize);



            //Loading the array with data
            for (int i = 0; i < t.Players.Length; i++)
            {
                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();
                do
                {
                    Console.Write("Please enter a number: ");
                    plyrNum = Console.ReadLine();
                } while (!int.TryParse(plyrNum, out number));
                
                Console.Write("Please enter a position: ");
                position = Console.ReadLine();



               



                t.Players[i] = new Player(name, number, position);
            }



            for (int i = 0; i < t.Players.Length; i++)
            {
                Console.WriteLine("Name -- " + t.Players[i].Name + " -- Number -- " + t.Players[i].Number);
                Console.WriteLine("Position -- " + t.Players[i].Position + "\n");
            }




        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoIt doit = new DoIt();
        }
    }
}
