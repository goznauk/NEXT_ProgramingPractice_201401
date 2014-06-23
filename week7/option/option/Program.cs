using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace option {
  class Program {
    static void Main(string[] args) {
      List<Student> mStudents = new List<Student>();
      string input;

      Console.WriteLine("Please Input the Name (Exit to qqq)");
      for(; ; ) {
        input = Console.ReadLine();
        if (input == "qqq") { break; }
        mStudents.Add(new Student(input, mStudents.Count));
      }
      Console.WriteLine();

      Console.WriteLine("The List of Students you've typed");
      for (int i = 0; i < mStudents.Count; i++) {
        Console.WriteLine("[{0:D3}] {1}", mStudents[i].id, mStudents[i].name);
      }
      
      Console.Write("How many students to choose? [1~{0}]  ", mStudents.Count);
      int num = int.Parse(Console.ReadLine());

      Random r = new Random();
      for (int i = 0; i < num; i++) {
        int j = r.Next(0, mStudents.Count);
        Console.WriteLine("[{0:D3}] {1}", mStudents[j].id, mStudents[j].name);
        mStudents.RemoveAt(j);
      }
      Console.Read();
    }

    public class Student {
      public string name;
      public int id;

      public Student(string name, int id) {
        this.name = name;
        this.id = id;
      }
    }
  }
}