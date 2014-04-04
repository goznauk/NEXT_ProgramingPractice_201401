using System;

public class ex1 {
	public static void Line() {
		int x = Int32.Parse(Console.ReadLine());
		for(int i=0;i<x;i++) {
			Console.WriteLine("-----------------------------");
		}
	}

	static void Main(string[] args) {
		Console.Write("Number? ");
		Line();
		Console.Write("Another Number? ");
		Line();
		Console.WriteLine("End");
	}
}
