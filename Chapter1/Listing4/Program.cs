﻿using System;
using System.Threading;

namespace Listing4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
                    {
                        while (!stopped)
                        {
                            Console.WriteLine("Running...");
                            Thread.Sleep(1000);
                        }
                    }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
