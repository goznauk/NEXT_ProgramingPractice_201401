using System;
using tmpLib;
/*
 * Please compile with tmpLib.cs
 * $ gmcs lab1.cs tmpLib.cs
 */

class lab4 {
	public static void Main(String[] args) {
		int[] arr;
		arr = Easy.inputInts(2, "Input the numbers");
		


		foreach(int i in arr) {
			Console.WriteLine(i);
		}
	}
}
