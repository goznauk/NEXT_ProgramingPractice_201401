using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class Program {
    static void Main(string[] args) {
      List<int> mList = new List<int>();
      for (int i = 1; i <= 10; i++) { mList.Add(i); }

      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      swapIntList(ref mList, 0, 9);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();

      uint a, b;

      for (; ; ) {
        Console.Write("Input the position of numbers : ");
        string tmpStr = Console.ReadLine();
        string[] pos = tmpStr.Split(' ', ',');
        if (pos.Length == 2 
          && uint.TryParse(pos[0], out a) 
          && uint.TryParse(pos[1], out b) 
          && a < 10 && b < 10) { 
          break;
        }
        Console.WriteLine("Unexpected Input : Please Input 2 Numbers [0~9]");
      }

      swapIntList(ref mList, (int)a, (int)b);
      foreach (int i in mList) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
    }

    static void swapIntList(ref List<int> list, int pos1, int pos2) {
      int tmp1 = list.ElementAt(pos1);
      int tmp2 = list.ElementAt(pos2);

      list.RemoveAt(pos1);
      list.Insert(pos1, tmp2);
      list.RemoveAt(pos2);
      list.Insert(pos2, tmp1);
    }
  }
}
