// See https://aka.ms/new-console-template for more information
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

            for (int i = 0; i < plyrName.Length; i++)
            {
                Console.WriteLine("Enter the player name: ");
                plyrName[i] = Console.ReadLine();
                Console.WriteLine("Enter the player number 1 - 99: ");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] > 99 || number[i]<0)
                {
                    Console.WriteLine("Outside of the boundry! Please enter a valid number within 1 - 99: ");
                    number[i] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < plyrName.Length; j++)
            {
                Console.WriteLine("");
            }

        }
    }
}
