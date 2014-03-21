using System;

namespace next {
	public class Circle {
		private int x; 
		private int y;
		private double r;
		
		public Circle(int x, int y, double r) : this() {
			this.x = x;
			this.y = y;
			this.r = r;
		}

		public Circle() { }
		
		public void initCircle(int i) {
			string tmpstr;

			Console.Write("Input the x, y, r of Circle {0}: ", i);
			tmpstr = Console.ReadLine();
			string[] data = tmpstr.Split(' ', ',');
			this.x = Convert.ToInt32(data[0]);
			this.y = Convert.ToInt32(data[1]);
			this.r = Convert.ToDouble(data[2]);
		}

		public int getx() { return x; }
		public int gety() { return y; }
		public double getr() { return r; }

	}

	class CircleTest {
		static void Main(String[] args) {
			Circle c1 = new Circle();
			Circle c2 = new Circle();

			Console.WriteLine("Circle Collision Test");
			Console.WriteLine();

			c1.initCircle(1);
			c2.initCircle(2);

//			Just for Check it is working
//			Console.WriteLine("{0}, {1}, {2}", 
//					c1.getx(), c2.gety(), c1.getr());
		
			int dx = c1.getx() - c2.getx();
			int dy = c1.gety() - c2.gety();
			double distance = Math.Sqrt(dx*dx + dy*dy);
			double rSum = c1.getr() + c2.getr();

			if(distance > rSum) {
				Console.WriteLine("The circles are not crashing");
			}
			else if(distance == rSum) {
				Console.WriteLine("The circles are kissing");
			} else {
				Console.WriteLine("The circles are crashing");
			}
		}
	}
}
