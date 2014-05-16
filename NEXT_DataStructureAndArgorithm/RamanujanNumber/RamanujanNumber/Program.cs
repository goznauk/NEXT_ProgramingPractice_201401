using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamanujanNumber {
  class Program {
    class RamaNum{
      public long sum;
      public string A, B;
      public RamaNum(long lSum, int lDetail1, int lDetail2) {
        this.sum = lSum;
        this.A = parseDetail(lDetail1);
        this.B = parseDetail(lDetail2);
      }

      public string parseDetail(int detail) {
        int a, b;
        a = detail / 1000;
        b = detail % 1000;

        return a + "^3" + " + " + b + "^3";
      }

      public void printRamanum() {
        Console.WriteLine("Ramanujan Number : {0}", sum);
        Console.WriteLine(sum + " = " + A + " = " + B);
      }
    }
    static void Main(string[] args) {
      int limit = 100;
      long sum = 0;
      int detail = 0;
      Hashtable hash = new Hashtable();
      List<RamaNum> result = new List<RamaNum>();

      for (int i = 0; i < limit; i++) {
        for (int j = i; j < limit; j++) {
          try {
            sum = i * i * i + j * j * j;
            detail = i * 1000 + j;
            hash.Add(sum, detail);
          } catch {
            result.Add(new RamaNum(sum, int.Parse(hash[sum].ToString()), detail));
//          Console.WriteLine("Key = {0} : Details = {1} / {2}", sum, hash[sum], detail);
          }
        }
      }
      result.Sort(delegate(RamaNum r1, RamaNum r2) { return r1.sum.CompareTo(r2.sum); });
      foreach (RamaNum r in result) {
        r.printRamanum();
      }
    }
  }
}