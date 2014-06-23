using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4 {
  class Program {
    static void Main(string[] args) {
      int cursorPos;
      List<int> mList = new List<int>();
      Console.Write("Original List : ");
      for (int i = 1; i <= 10; i++) { mList.Add(i); }
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("EveryBody Shuffling");
      Console.WriteLine("000% ------------------------------");
      Thread.Sleep(500);
      
      cursorPos = Console.CursorTop - 1;
      for (int i = 1; i <= 30; i++) {
        Thread.Sleep(10 + i * 10);
        Console.SetCursorPosition(0, cursorPos);
        Console.Write("{0:d3}%", (i / 3) * 10);
        Console.SetCursorPosition(4 + i, cursorPos);
        Console.Write('#');
      }
      Console.WriteLine();

      Console.Write("Shuffled : ");
      shuffle(ref mList);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      Console.WriteLine();

      Thread.Sleep(500);

      Console.WriteLine("EveryBody Shuffling");
      Console.WriteLine("000% ------------------------------");
      Thread.Sleep(500);

      cursorPos = Console.CursorTop - 1;
      for (int i = 1; i <= 30; i++) {
        Thread.Sleep(200 - i * 5);
        Console.SetCursorPosition(0, cursorPos);
        Console.Write("{0:d3}%", (i / 3) * 10);
        Console.SetCursorPosition(4 + i, cursorPos);
        Console.Write('#');
      }
      Console.WriteLine();

      Console.Write("Shuffled : ");
      shuffle(ref mList);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("Your Lotto Number : ");
      // Lotto~
      List<int> lottoList = new List<int>();
      for (int i = 1; i <= 45; i++) {
        lottoList.Add(i);
      }
      shuffle(ref lottoList);
      for (int i = 0; i < 6; i++) {
        Console.Write("{0} ", lottoList[i]);
      }
      Console.WriteLine();
      Console.Read();
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
        i = r.Next(0, list.Count);
        j = r.Next(0, list.Count);

        swapIntList(ref list, i, j);
        if (t > 1000) { break; }
      }
    }
  }
}
