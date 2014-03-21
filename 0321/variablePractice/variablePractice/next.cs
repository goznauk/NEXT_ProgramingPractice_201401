using System;

namespace next {
	class Ex1 {
		static void Main(String[] args) {
			String m1;
			Console.Write("Type Something: ");
			m1 = Console.ReadLine();
			Console.WriteLine("Read: " + m1);

			Console.Write("Type Some int number: ");
			m1 = Console.ReadLine();
			int x = Convert.ToInt32(m1);
			x = 2*x;
			Console.WriteLine("Num: {0}/2", x);
		}
	}
}
