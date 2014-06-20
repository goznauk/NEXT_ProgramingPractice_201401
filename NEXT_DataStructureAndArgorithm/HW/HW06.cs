/*
 * Polynomial Class
 * 1. AddTerm(double coef, int exp);
 * (a) Modeling Term
 * (b) Initialize Polynomial
 * 2. void Print();
 * 3. Modeling -> x^2 - 2x + 1
 * 4. Print the result
 * 5. Simplify the Polynomial
 * 6. 
 */


using System;

class PolynomialPractice {
	class Term {
		public double coef;
		public int exp;
		public Term next;
		public Term prev;
	}

	class Polynomial {
		public Term first;
		public Polynomial() {
			first = null;
		}
		public Polynomial simplify() {
			Polynomial result = new Polynomial();
			for(Term t = first; t != null; t = t.next) {
				double coef = t.coef;
				int exp = t.exp;
				for(Term u = t.next; u != null; u = u.next) {
					if(exp == u.exp) {
						coef += u.coef;
						u.coef = 0;
						u.prev.next = u.next;
					}
				}
			}
			return result;
		}
		public void addTerm(double coef, int exp) {
			Term t = new Term();
			t.coef = coef;
			t.exp = exp;
			if(first == null) {
				first = t;
				t.next = null;
			} else {
				t.next = first;
				first = t;
				t.next.prev = first;
			}
		}
		public void printPoly() {
			Console.WriteLine("Printpoly :");
			for(Term t = first; t != null; t = t.next) {
				if(t.coef == 1) {
					Console.Write("+ x^{1}", t.exp);
				} else {
					Console.Write("+ {0}x^{1}", t.coef, t.exp);
				}
			}
			Console.WriteLine();
		}
	}

	static void Main() {
		Polynomial p = new Polynomial();
		p.addTerm(1,2);
		p.addTerm(-1,1);
		p.addTerm(1,2);
		p.addTerm(1,0);
		p.addTerm(2,2);
		p.addTerm(1,3);
		p.printPoly();
		p.simplify().printPoly();
	}
}
