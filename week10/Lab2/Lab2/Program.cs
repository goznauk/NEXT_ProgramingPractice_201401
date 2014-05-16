using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2 {
  class FileWrite {
    public void WriteSth(string fileName, string endStr, bool append) {
      string dir = Directory.GetCurrentDirectory();
      Console.WriteLine("Current Working Directory\n - {0}", dir);
      string fullFileName = dir + "\\" + fileName;
      Console.WriteLine("Current Full Filename\n - {0}", fullFileName);
      StreamWriter sw = new StreamWriter(fileName, append, Encoding.GetEncoding("euc-kr"));
      string inputStr = "";
      while (true) {
        Console.Write("Input Line >> ");
        inputStr = Console.ReadLine();
        if (inputStr == endStr) break;
        sw.WriteLine(inputStr);
      }
      sw.Close();
    }

    static void Main(string[] args) {
      FileWrite fw = new FileWrite();
      fw.WriteSth("FileByLab2.txt", "{/Q", true);
    }
  }
}
