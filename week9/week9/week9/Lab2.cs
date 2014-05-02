using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace week9 {
  class Timer {
    public static void PrintSec(int sec) {
      int i = 0;
      while (i < sec) {
        Console.WriteLine(++i);
        Thread.Sleep(1000);
      }
    }

    public static void PrintTimer(int hour, int min, int sec) {
      //DateTime mDateTime = new DateTime(hour, min, sec);
      int net = hour*3600 + min*60 + sec;
      
      while (net > 0) {
        Console.WriteLine("{0}:{1}:{2}", net/3600, (net%3600)/60, (net%3600)%60);
        Thread.Sleep(1000);
        net--;
      }
    }

    public static void StopWatch() {
      int i = 0;
      while(true) {
        Console.WriteLine("{0}.{1}", i/10, i%10);
        Thread.Sleep(100);
        i++;
      }
    }

    public static void printTime() {
      DateTime mTime = new DateTime();
      while (true) {
        mTime = DateTime.Now;
        Console.WriteLine(mTime.ToString("yyyy-MM-dd-HH-mm-ss"));
        Thread.Sleep(1000);
      }
    }

    static void Main(string[] args) {
      Timer.printTime();
      Console.WriteLine("Bye");
    }
  }
}
