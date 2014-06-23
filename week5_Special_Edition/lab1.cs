using System;

class lab4 {
	public static void Main(String[] args) {
		int[] arr = new int[2];
		string input;

		Console.Write("Input Row and Column : ");
		input = Console.ReadLine();
		string[] tmp = input.Split(' ');
		arr[0] = Convert.ToInt32(tmp[0]);
		arr[1] = Convert.ToInt32(tmp[1]);

		for (int i = 0; i < arr[0]; i++) {
			for (int j = 0; j < arr[1]; j++) {
				Console.Write("{0} ", (i + 1) * (j + 1));
			}
			Console.WriteLine();
		}
	}
}
