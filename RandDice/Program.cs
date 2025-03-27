using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(args[0]);
            int s = Int32.Parse(args[1]);
            int total = 0;
            Random r1 = new Random(s);
            for (int i = 0; i < n; i++)
            {
                int randnum = (r1.Next(1, 7));
                total += randnum;
            }

            Console.WriteLine(total);



        }
    }
}
