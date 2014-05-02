using System;

namespace tmpLib {
	public class Easy {
		public static int[] inputInts() {
			string tmpstr = Console.ReadLine();
			string[] tmparr = tmpstr.Split(' ', ',');
			int[] output = new int[tmparr.Length];
			for(int i=0;i<tmparr.Length;i++) {
				output[i] = Int32.Parse(tmparr[i]);
			}
			return output;
		}

		public static int[] inputInts(int i) {
			for(;;) {
				int[] output = inputInts();
				if(output.Length==i) {
					return output;
				} else {
					Console.WriteLine("You should input {0} numbers", i);
				}
			}
		}

		public static int[] inputInts(string msg) {
			if(msg!=null) {
				Console.Write("{0}? ", msg);
			}
			int[] output = inputInts();
			return output;
		}
	}

/* 
 * test code
 * == lab 4
 *
	public class Test {
		public static void Main(string[] args) {
			int[] arrayee = Easy.inputInts("Input test numbers");
			foreach(int element in arrayee) {
				Console.WriteLine(element);
			}
		}
	}*/
}
