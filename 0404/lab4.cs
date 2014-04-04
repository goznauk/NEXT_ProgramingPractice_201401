using System;
using tmpLib;
/*
 * Please compile with tmpLib.cs
 * $ gmcs lab4.cs tmpLib.cs
 */

class lab4 {
	public static void Main(String[] args) {
		int[] array = Easy.inputInts("Input the numbers");
		foreach(int i in array) {
			Console.WriteLine(i);
		}
	}
}
