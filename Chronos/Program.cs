using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);

            Stopwatch crono2 = new Stopwatch();
            crono2.Start();
            Thread.Sleep(250);

            crono1.Stop();
            crono2.Stop();

            // Get the elapsed time as a TimeSpan Value.
            TimeSpan ts1 = crono1.Elapsed;
            Console.WriteLine(string.Format("{0:F4}", crono1.Elapsed.TotalSeconds));
            TimeSpan ts2 = crono1.Elapsed;
            Console.WriteLine(string.Format("{0:F4}", crono2.Elapsed.TotalSeconds));
        }
    }
}
