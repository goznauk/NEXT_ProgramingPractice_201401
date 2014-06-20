using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
  class Program {
    static void Main(string[] args) {
      //HashTable version
      /*
      Hashtable hash = new Hashtable();
      for (; ; ) {
        String tmpStr = Console.ReadLine();
        if (tmpStr.Equals("-999")) { break; }
        try {
          hash.Add(tmpStr, null);
        } catch {
          hash.Remove(tmpStr);
        }
        ICollection keys = hash.Keys;
        foreach (string i in keys) {
          Console.Write("{0} ", i);
        }
        Console.WriteLine();
      }
       */

      List<string> mList = new List<string>();

      for (; ; ) {
        Console.Write("Input the number : ");
        string tmpStr = Console.ReadLine();
        int result;
        if (tmpStr.Equals("-999")) { break; }
        if (!int.TryParse(tmpStr, out result)) { continue; }

        if (mList.IndexOf(tmpStr) == -1) { mList.Add(tmpStr); } else { mList.Remove(tmpStr); }

        foreach (string s in mList) {
          Console.Write("{0} ", s);
        }
        Console.WriteLine();
      }
    }
  }
}
