using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1 {
  class FileRead {
    public void ReadAndPrint(string fileName) {
      string dir = Directory.GetCurrentDirectory();
      Console.WriteLine("Current Working Directory\n - {0}", dir);
      string fullFileName = dir + "\\" + fileName;
      Console.WriteLine("Current Full Filename\n - {0}", fullFileName);
      StreamReader sr = new StreamReader(fullFileName, Encoding.GetEncoding("euc-kr"));
      Console.WriteLine("Now Reading File + {0}", fileName);
      int n = 0;
      while (sr.Peek() != -1) {
        n++;
        string line = sr.ReadLine();
        Console.WriteLine("{0:00}: {1}", n, line);
      }
      sr.Close();
    }


    static void Main(string[] args) {
      FileRead fr = new FileRead();
      fr.ReadAndPrint("sevenbit.txt");
      
    }
  }
}
