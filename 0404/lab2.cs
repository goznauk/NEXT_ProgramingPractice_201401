using System;

class lab2 {
	public static void Main(String[] args) {
		int i, j, num1, num2;
		Console.WriteLine("Input the number : ");
		num1 = Int32.Parse(Console.ReadLine());
		num2 = Int32.Parse(Console.ReadLine());

		for(i=0;i<num1;i++) {
			for(j=0;j<num2;j++) {
				Console.Write("{0:D2} ", i*10 + j);
			}
			Console.Write("\n");
		}
	}
}
