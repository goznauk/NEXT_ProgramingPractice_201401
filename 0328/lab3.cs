using System;

class lab2 {
	static void Main(string[] args) {
		int i, mNum;
		string m1;

		Console.WriteLine("Input the number : ");
		m1 = Console.ReadLine();
		mNum = Convert.ToInt32(m1);

		for(i=1;i<=9;i++) {
			Console.WriteLine("{0} X {1} = {2}", mNum, i, mNum*i);
		}
	}
}
