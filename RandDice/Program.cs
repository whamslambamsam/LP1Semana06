using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            int s = Convert.ToInt32(args[1]);
            int total = 0;
            Random rand = new Random(s);

            for(int i = 0; i < n; i++)
            {
                int randnum = rand.Next(1, 7);
                total += randnum;
            }

            Console.WriteLine(total);
        }
    }
}
