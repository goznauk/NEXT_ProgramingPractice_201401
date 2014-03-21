using System;

namespace next {
	public class Student {
		public String name;
		public int kor;
		public int math;
		
		public Student() { }
		public Student(String name, int kor, int math) {
			this.name = name;
			this.kor = kor;
			this.math = math;
		}

		public float getAvg() {
			return (kor+math)/2;
		}
	}

	class Test{
		static void Main(String[] args) {
			//for Student s1
			Student s1 = new Student();
			//Student s2 = //implement
			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;

			Student s2 = new Student("Bae", 88, 60);

			float tavg = (s1.getAvg() + s2.getAvg())/2;

			Console.WriteLine("Average Score of {0} : {1}", s1.name, s1.getAvg());
			Console.WriteLine("Average Score of {0} : {1}", s2.name, s2.getAvg());
			Console.WriteLine("Total Average Score of {0} and {1} : {2}", s1.name, s2.name, tavg);
		}
	}
}
