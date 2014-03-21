using System;

namespace next {
	class Ex3 {
		static void Main(String[] args) {
			const int SIZE = 5;
			int[] arr;
			int i, sum;
			arr = new int[SIZE];

			i = 0;
			while (i < SIZE) {
				Console.Write("num[{0}]? ", i);
				String cmd = Console.ReadLine();
				arr[i] = Convert.ToInt32(cmd);
				i++;
			}

			i = 0;
			sum = 0;
			while(i<SIZE) {
				sum += arr[i];
				i++;
			}

			Console.WriteLine("Sum = {0}", sum);
		}
	}
}
