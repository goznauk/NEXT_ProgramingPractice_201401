using System;

public class Ex5 {
	public static int ReadInt(string msg) {
		Console.Write("{0}? ", msg);
		return Int32.Parse(Console.ReadLine());
	}

	public static double Divide(int x, int y) {
		return (double)x/y;
	}

	static void Main(string[] args) {
		int x = ReadInt("First Number");
		int y = ReadInt("Second Number");
		double z = Divide(x,y);
		Console.WriteLine(z);
	}
}
