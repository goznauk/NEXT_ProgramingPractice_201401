using System;

class lab4 {
	public static void Main(String[] args) {
		string input;
		string[] tmp;
		int x, y;

		Console.Clear();

		Console.Write("Input Number : ");
		int n = Convert.ToInt32(Console.ReadLine());

		
		bool[,] arr = new bool[n,n];

		for(int i=0; i<n; i++) {
			for(int j=0; j<n; j++) {
				arr[i,j] = true;
			}
		}
		
		for(int i=0; i<n; i++) {
			for(int j=0; j<n; j++) {
				if(arr[i,j]) {
					Console.Write("0 ");
				} else {
					Console.Write("  ");
				}
			}
			Console.WriteLine();
		}

		for(;;) {
			Console.Write("Input the pos to delete : ");
			input = Console.ReadLine();
			tmp = input.Split(' ');

			x = Convert.ToInt32(tmp[0]);
			y = Convert.ToInt32(tmp[1]);

			if(x>=n || y>=n) { continue; }
			if(x<0 || y<0) { break; }
			if(arr[x,y]) {
				arr[x,y] = false;
				arr[y,x] = false;
				Console.Clear();
				Console.WriteLine();
				for(int i=0; i<n; i++) {
					for(int j=0; j<n; j++) {
						if(arr[i,j]) {
							Console.Write("0 ");
						} else {
							Console.Write("  ");
						}
					}
					Console.WriteLine();
				}
			} else {
				continue;
			}
		}
	}
}
