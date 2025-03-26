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
            crono1.Stop();
            // Get the elapsed time as a TimeSpan Value.
            TimeSpan ts1 = crono1.Elapsed;
        }
    }
}
