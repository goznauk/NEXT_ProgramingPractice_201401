using System;

class lab2 {
	static void Main(string[] args) {
		string tmpstr;
		int i;
		int sum = 0;
		int[] ipt;
		string[] input;

		for(;;) {
			Console.WriteLine("Input : initial, final, step");
			tmpstr = Console.ReadLine();
			input = tmpstr.Split(' ', ',');
			ipt = new int[input.Length];
		/*
			foreach(int i in input) {
				ipt[i] = Convert.ToInt32(input[i]);
			}
		*/

			for(i=0;i<input.Length;i++) {
				ipt[i] = Convert.ToInt32(input[i]);
			}

			if(input.Length==3) {
				break;
			} else {
				Console.WriteLine("Unexpected input : please type it again");
			}
		}

		for(int a=ipt[0]; a<=ipt[1]; a=a+ipt[2]) {
			sum = sum + a;
			Console.WriteLine("{0}", sum);
		}

//		Console.WriteLine("Result");
	}
}
