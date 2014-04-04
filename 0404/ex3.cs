using System;

public class Ex3 {
	public static void doublePrint(int x) {
		int n = 2*x;
		Console.WriteLine(n);
	}

	static void Main(string[] args) {
		int x = 10;
		int y = 20;
		doublePrint(x);
		doublePrint(y);
		doublePrint(30);
		Console.WriteLine("Main x = {0}", x);
	}
}
