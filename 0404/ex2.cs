using System;

public class ex2 {
	public static void Method1() {
		int x = 50;
		Console.WriteLine("Method1 x = {0}", x);
	}

	static void Main(string[] args) {
		int x = 20;
		Console.WriteLine("Main x = {0}", x);
		Method1();
		Console.WriteLine("Main x = {0}", x);
	}
}
