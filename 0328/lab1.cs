using System;

class Ex1 {
	static void Main(string[] args) {
		int sum = 0;
		String input = "0"; 
		int i;

		for(i=0;Convert.ToInt32(input)!=-1;i++) {
			input = Console.ReadLine();
			if(input!="-1") {
				sum = sum + Convert.ToInt32(input);
			}
		}

		Console.WriteLine("Sum : {0}, Average : {1}", sum, Convert.ToDouble(sum)/(i-1));
	}
}
