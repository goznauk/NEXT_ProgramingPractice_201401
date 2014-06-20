using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4 {
  class Program {
    static void Main(string[] args) {
      List<int> mList = new List<int>();
      Console.Write("Original List : ");
      for (int i = 1; i <= 10; i++) { mList.Add(i); }
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();


      Console.WriteLine("EveryBody Shuffling");
      Console.WriteLine("000% ----------");
      Thread.Sleep(500);
      for (int i = 1; i <= 10; i++) {
        Thread.Sleep(100+i*30);
        Console.SetCursorPosition(0, 2);
        Console.Write("{0:d3}%", i * 10);
        Console.SetCursorPosition(4 + i, 2);
        Console.Write('#');
      }
      Console.SetCursorPosition(0,3);

      Console.Write("Shuffled : ");
      shuffle(ref mList);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();


      Thread.Sleep(500);

      Console.WriteLine("EveryBody Shuffling");
      Console.WriteLine("000% ----------");
      Thread.Sleep(500);
      for (int i = 1; i <= 10; i++) {
        Thread.Sleep(400-i*35);
        Console.SetCursorPosition(0, 7);
        Console.Write("{0:d3}%", i * 10);
        Console.SetCursorPosition(4 + i, 7);
        Console.Write('#');
      }
      Console.SetCursorPosition(0, 8);

      Console.Write("Shuffled : ");
      shuffle(ref mList);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      Console.ReadKey();
    }

    static void swapIntList(ref List<int> list, int pos1, int pos2) {
      int tmp1 = list.ElementAt(pos1);
      int tmp2 = list.ElementAt(pos2);

      list.RemoveAt(pos1);
      list.Insert(pos1, tmp2);
      list.RemoveAt(pos2);
      list.Insert(pos2, tmp1);
    }

    static void shuffle(ref List<int> list) {
      int i, j;
      int t = 0;
      Random r = new Random();
      int seed = Environment.TickCount;

      for (; ; ) {
        t++;
        i = r.Next(0, 10);
        j = r.Next(0, 10);

        swapIntList(ref list, i, j);
        if (t > 50) { break; }
      }
    }
  }
}
