using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] plyrName = new String[11]; // only 11 since that is how many are in a starting lineup
            int[] number = new int[11];
            String[] pos = new String[11];
            bool result;

            for (int i = 0; i < plyrName.Length; i++)
            {
                try
                {
                    Console.WriteLine("Enter the player name: ");
                    plyrName[i] = Console.ReadLine();
                    Console.WriteLine("Enter the player number 1 - 99: ");
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error!");
                }
            }

            

            for (int j = 0; j < plyrName.Length; j++)
            {
                Console.WriteLine("");
            }

        }
    }
}
