using System;

class Ex0501 {
	static void Main(string[] args) {
		int i = 1;

		while(i<=5) {
			int j = 1;

			while(j<=i) {
				Console.Write("*");
				j++;
			}
			Console.Write("\n");
			i++;
		}

		Console.WriteLine();

		int k = 5;

		do {
			int l = k;
			do {
				Console.Write("*");
				l--;
			} while (l>=1);

			Console.Write("\n");
			k--;
		} while (k>=1);
	}
}

