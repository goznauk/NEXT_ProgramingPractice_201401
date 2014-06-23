using System;

class lab4 {
	public static void Main(String[] args) {
		Console.Write("Input Number : ");
		int input = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < input + 1; i++) {
			for (int j = 0; j < input; j++) {
				if(j < i) { Console.Write('#'); }
				else { Console.Write('*'); }
			}
			Console.WriteLine();
		}
	}
}
