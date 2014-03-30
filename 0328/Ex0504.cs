using System;

class Ex0501 {
	static void Main(string[] args) {
		int mNum;
		string tmpstr; 

		for(;;) {
			Console.WriteLine("Input the number");
			tmpstr = Console.ReadLine();
			try {
				mNum = Convert.ToInt32(tmpstr);
				//Console.WriteLine("{0}", mNum);
				if(mNum>0) {
					for(int i=1;i<=mNum;i++) {
						for(int j=1;j<=i;j++) {
							Console.Write("*");
						}
						Console.Write("\n");
					}
					break;
				} else {
					Console.WriteLine("Unexpected Input : the number must be bigger than 0");
				}
			} catch (FormatException e) {
				Console.WriteLine("Unexpected Input : not a sequence of digits");
			} catch (OverflowException e) {
				Console.WriteLine("Unexpected Input : the number is too big");
			}
		}
	}
}

