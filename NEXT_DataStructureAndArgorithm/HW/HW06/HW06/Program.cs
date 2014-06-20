using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * HW06
 * Polynomial Class
 * 1. AddTerm(double coef, int exp);
 * (a) Modeling Term
 * (b) Initialize Polynomial
 * 2. Print Polynomial
 * 3. Delete by exp
 * 4. Simplify the Polynomial
 * 
 */

namespace HW06 {
  class Program {
    class Term {
      public double coef;
      public int exp;
      public Term prev;
      public Term next;

      public void delete() {
        prev.next = next;
      }
    }

    class Polynomial {
      public Term iTerm;

      public Polynomial() { iTerm = null; }

      public void simpleDelete(int exp) {
        for (Term i = iTerm; i != null; i = i.next) {
          if (i.exp == exp) {
            i.coef = 0;
          }
        }
        simplify();
      }

      public void delete(int exp) {
        for (Term i = iTerm; i != null; i = i.next) {
          if (i.exp == exp) {
            if (i == iTerm) { iTerm = i.next; } else { i.prev.next = i.next; }
          }
        }
      }

      public void simplify() {
        Polynomial result = new Polynomial();
        for (Term i = iTerm; i != null; i = i.next) {
          for (Term j = i.next; j != null; j = j.next) {
            if (i.exp == j.exp) {
              i.coef += j.coef;
              j.delete();
            }
          }
          if (i.coef == 0) {
            i.delete();
          }
        }
      }

      public void addTerm(double coef, int exp) {
        Term t = new Term();
        t.coef = coef;
        t.exp = exp;
        if (iTerm == null) {
          iTerm = t;
        } else {
          t.next = iTerm;
          iTerm = t;
          t.next.prev = iTerm;
        }
      }

      public void printPoly() {
        Console.WriteLine("Print Polynominal");
        for (Term i = iTerm; i != null; i = i.next) {
          if (i != iTerm) {
            if (i.coef > 0) { Console.Write(" +"); } else if (i.coef < 0) { Console.Write(" "); }
          }

          if(i.coef==0){
            //do nothing
          } else if (i.exp == 0) {
            Console.Write("{0}", i.coef);
          } else if (i.coef == 1) {
            Console.Write("x^{0}", i.exp);
          } else {
            Console.Write("{0}x^{1}", i.coef, i.exp);
          }
        }
        Console.WriteLine();
      } 
    }

    static void Main(string[] args) {
      Polynomial p = new Polynomial();
      p.addTerm(3, 2);
      p.addTerm(1, 3);
      p.addTerm(3, 0);
      p.addTerm(-3, 2);
      p.addTerm(4, 3);
      p.printPoly();
      p.simplify();
      Console.WriteLine("Polynomial simplified");
      p.printPoly();

      p.delete(3);
      Console.WriteLine("the Terms has exp 3 are deleted.");
      p.printPoly();

      Console.ReadLine();
    }
  }
}



