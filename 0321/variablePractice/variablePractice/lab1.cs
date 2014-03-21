using System;

namespace variablePractice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int kor1, kor2;
			int math1, math2;
			double avg1, avg2, avg3;
			String name1, name2;

			Console.WriteLine ("=========================== Score ===========================");
			Console.WriteLine ();

			kor1 = 80;
			kor2 = 88;
			math1 = 90;
			math2 = 60;

			name1 = "J.M Lim";
			name2 = "C.O Bae";

			avg1 = (kor1 + math1) / 2;
			avg2 = (kor2 + math2) / 2;
			avg3 = (avg1 + avg2) / 2;

			Console.WriteLine ("Name\t|     {0}\t|     {1}\t|     Average", name1, name2);
			Console.WriteLine ("-------------------------------------------------------------");
			Console.WriteLine ("Korean\t|\t{0}\t|\t{1}\t|\t", kor1, kor2);
			Console.WriteLine ("Math\t|\t{0}\t|\t{1}\t|\t", math1, math2);
			Console.WriteLine ("Average\t|\t{0}\t|\t{1}\t|\t{2}", avg1, avg2, avg3);

		}
	}
}
