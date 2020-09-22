using System;
using System.Threading;
using Controller;

namespace WindesRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Initialize();
            Data.NextRace();
            Console.WriteLine(Data.CurrentRace.Track.name);
            for (; ; )
            {
                Thread.Sleep(100);
            }

        }
    }
}
