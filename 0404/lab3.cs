using System;
using tmpLib;
/*
 * Please Compile with tmpLib.cs
 * gmcs lab3.cs tmpLib.cs
 */
class lab3 {
	public static void Main(String[] args) {
		Console.WriteLine("Input the size of Array");

		int n = Int32.Parse(Console.ReadLine());
		int[,] array1 = new int[n,n];
		
		for(int i=0;i<n;i++) {
			Console.WriteLine("Input the {0} numbers of Row {1}", n, i+1);
			int[] tmpArr = Easy.inputInts(n);
			for(int j=0;j<n;j++) {
				array1[i,j]=tmpArr[j];
			}
		}

		Console.WriteLine();
		Console.WriteLine("Result");
		Console.WriteLine();

		for(int i=0;i<n;i++) {
			for(int j=0;j<n;j++) {
				Console.Write("{0}\t", array1[i,j]);
			}
			Console.Write("\n");
		}


/*
 * Test Code
 *
 *
		int[] arr = easySplit.splitInt(3);
		foreach(int element in arr) {
			Console.WriteLine(element);
		}
*/
	}
}
