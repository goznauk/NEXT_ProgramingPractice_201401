using System;

class lab1 {
	public static void Main(String[] args) {
		int i, j, k, num;
		String tmpstr;
		Console.WriteLine("Input the number : ");
//		tmpstr = Console.ReadLine();
//		num = Convert.ToInt32(tmpstr);
		num = Int32.Parse(Console.ReadLine());

		for(i=num;i>0;i--) {
			for(j=0;j<i;j++) {
				Console.Write(" ");
			}
			for(k=0;k<2*(num-i)+1;k++){
				Console.Write("*");
			}
			Console.Write("\n");
		}
	}
}
