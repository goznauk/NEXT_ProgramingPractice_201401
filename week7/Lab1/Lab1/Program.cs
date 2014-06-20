using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
  class Program {
    static void Main(string[] args) {
      Stack<string> mStack = new Stack<string>();
      Console.Write("Input the number :");
      string[] numbers = Console.ReadLine().Split(' ', ',');
      foreach (string s in numbers) {
        mStack.Push(s);
      }
      for (; ; ) {
        if (mStack.Count > 0) {
          Console.Write("{0} ", mStack.Pop());
        } else {
          break;
        }
      }
      Console.WriteLine();
    }
  }
}
