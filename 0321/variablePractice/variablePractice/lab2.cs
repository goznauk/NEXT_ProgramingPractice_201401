using System;

namespace next {
	class Ex1 {
		static void Main(String[] args) {
			String m1;
			String m2;
			String m3;
			Console.Write("Type Your Name: ");
			m3 = Console.ReadLine();
			Console.Write("Type Bottom Line length: ");
			m1 = Console.ReadLine();
			Console.Write("Type Height length: ");
			m2 = Console.ReadLine();

			int x = Convert.ToInt32(m1);
			int y = Convert.ToInt32(m2);
			double s = x*y/2;
			Console.WriteLine("Area of the {0}'s Triangle : {1}", m3, s);
		}
	}
}
