using System;

class lab2 {
	static void Main(string[] args) {
		Random r = new Random();
		int rNum = r.Next(1, 11);
		int i, mNum;
		string m1;

		for(i=0;;i++) {
			Console.WriteLine("Guess the number : ");
			m1 = Console.ReadLine();
			mNum = Convert.ToInt32(m1);
			
			if(mNum>rNum) {
				Console.WriteLine("Too big");
			} else if(mNum<rNum) {
				Console.WriteLine("Too Small");
			} else if(mNum==rNum) {
				Console.WriteLine("You're Right!");
				Console.WriteLine("{0} times tried.", i+1);
				break;
			}
		}
	}
}

