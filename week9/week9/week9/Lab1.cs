using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace week9
{
    class Timer
    {
        static void PrintSec(int sec)
        {
            int i = 0;
            while (i < sec)
            {
                Console.WriteLine(++i);
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Timer.PrintSec(10);
            Console.WriteLine("Bye");
        }
    }
}
