using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * HW07
 * Polynomial Class
 * after HW06
 * 1. reverse print
 * 2. sorting
 */

namespace HW07 {
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

      public int getCount() {
        int count = 0;
        for (Term i = iTerm; i != null; i = i.next) {
          count++;
        }
        return count;
      }

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

          if (i.coef == 0) {
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

      public void reversePrintPoly() {
        Console.WriteLine("Print Reverse Polynominal");
        string output = "";
        for (Term i = iTerm; i != null; i = i.next) {
          if (i.coef == 0) {
            //do nothing
          } else if (i.exp == 0) {
            output = i.coef.ToString() + output;
          } else if (i.coef == 1) {
            output = "x^" + i.exp.ToString() + output;
          } else {
            output = i.coef.ToString() + "x^" + i.exp.ToString() + output;
          }

          if (i.next != null) {
            if (i.coef > 0) { output = " +" + output; } else if (i.coef < 0) { output = " " + output; }
          }
        }
        Console.WriteLine(output);
      }

      public void sort() {
        simplify();
        int count = getCount();
        Term t = iTerm.next;
        for (int i = 1; i < count; i++) {
          Term u = iTerm;
          for (int j = 0; j < count - i; j++) {
            if (u.exp < u.next.exp) {
              double coef;
              int exp;
              coef = u.next.coef;
              exp = u.next.exp;
              u.next.coef = u.coef;
              u.next.exp = u.exp;
              u.coef = coef;
              u.exp = exp;
//              printPoly();
            }
            u = u.next;
          }
          t = t.next;
        }
        Console.WriteLine("Sorted");
      }
    }

    static void Main(string[] args) {
      Polynomial p = new Polynomial();
      p.addTerm(3, 2);
      p.addTerm(1, 3);
      p.addTerm(3, 0);
      p.addTerm(-3, 2);
      p.addTerm(4, 3);
      p.addTerm(1, 5);
      p.addTerm(-2, 4);
      p.addTerm(2, 1);
      p.printPoly();
      p.reversePrintPoly();
      p.simplify();
      Console.WriteLine("Polynomial simplified");
      p.printPoly();

      p.sort();
      p.printPoly();

      p.delete(3);
      Console.WriteLine("the Terms has exp 3 are deleted.");
      p.printPoly();
      Console.ReadLine();
    }
  }
}



