using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST {
  class Student {
    public int id;
    public string name;
    public string picture;

    public void showInfo() {
      Console.WriteLine("Student Info");
      Console.WriteLine("ID\t: {0}", id);
      Console.WriteLine("Name\t: {0}", name);
      Console.WriteLine("Picture\t: {0}", picture);
    }
  }

  class NODE {
    public Student mStudent;
    public NODE left, right;

    public NODE(Student student) {
      this.mStudent = student;
      left = null;
      right = null;
    }
  }

  class BinarySearchTree {
    NODE root;
    static int count = 0;

    public BinarySearchTree() {
      root = null;
    }


    public void add(Student student) {
      NODE newNode = new NODE(student);

      if (root == null) { root = newNode; } else { insertNode(root, newNode); }
      count++;
    }

    public void insertNode(NODE root, NODE newNode) {
      NODE temp = root;

      if (newNode.mStudent.id < temp.mStudent.id) {
        if (temp.left == null) {
          temp.left = newNode;
        } else {
          temp = temp.left;
          insertNode(temp, newNode);
        }
      } else if (newNode.mStudent.id > temp.mStudent.id) {
        if (temp.right == null) {
          temp.right = newNode;
        } else {
          temp = temp.right;
          insertNode(temp, newNode);
        }
      } else {
        Console.WriteLine("ERROR : The ID already exists");
      }
    }

    public Student search(int id) {
      NODE temp = searchNode(this.root, id);
      if (temp != null) {
        return searchNode(this.root, id).mStudent;
      }
      return null;
    }

    public NODE searchNode(NODE root, int id) {
      if (root == null) { return null; }

      if (root.mStudent.id == id) { return root; }

      if (root.left == null && root.right == null) { return null; }

      if (id < root.mStudent.id) {
        return searchNode(root.left, id);
      } else {
        return searchNode(root.right, id);
      }
    }

    public Boolean delete(int id) {
      NODE parent = root;
      NODE current = root;
      Boolean isLeft = true;

      while (current.mStudent.id != id) {
        parent = current;
        if (id < current.mStudent.id) {
          current = current.left;
          isLeft = true;
        } else {
          current = current.right;
          isLeft = false;
        }

        if (current == null) { return false; }
      }

      if (current.left == null && current.right == null) {
        if (current == root) {
          root = null;
        } else if (isLeft) {
          parent.left = null;
        } else {
          parent.right = null;
        }
      } else if (current.right == null) {
        if (current == root) { 
          root = current.left;
        } else if (isLeft) {
          parent.left = current.left;
        } else {
          parent.right = current.left;
        }
      } else if (current.left == null) {
        if (current == root) {
          root = current.right;
        } else if (isLeft) {
          parent.left = current.right;
        } else {
          parent.right = current.right;
        }
      } else {
        NODE successor = findSuccessor(current);
        if (current == root) {
          root = successor;
        } else if (isLeft) {
          parent.left = successor;
        } else {
          parent.right = successor;
        }
        successor.left = current.left;
      }
      return true;
    }

    public NODE findSuccessor(NODE delNode) {
      NODE successorParent = delNode;
      NODE successor = delNode;
      NODE current = delNode.right;
      while (current != null) {
        successorParent = successor;
        successor = current;
        current = current.left;
      }
      if (successor != delNode.right) {
        successorParent.left = successor.right;
        successor.right = delNode.right;
      }
      return successor;
    }

    public void printTree() {
      printNode(root, 0);
    }

    public void printNode(NODE root, int count) {
      string output = "";
      if (root != null) {
        printNode(root.left, count + 1);
        output = string.Format("-[{0:D2}] {1:D4} : {2}", count, root.mStudent.id, root.mStudent.name);
        for (int i = 0; i < count; i++) { output = "  " + output; }
        Console.WriteLine(output);
        printNode(root.right, count + 1);
      }
    }
  }


  class Program {
    static void Main(string[] args) {
      BinarySearchTree bst = new BinarySearchTree();
      Random r = new Random();
      int[] id = new int[20];

      for (int i = 20; i < 40; i++) {
        Student temp = new Student();
        temp.id = i*r.Next(1, 25);
        id[i-20] = temp.id;
        temp.name = "name" + i.ToString();
        temp.picture = "pic";
        bst.add(temp);
      }
      bst.printTree();

      Console.WriteLine();

      Student mStudent = new Student();
      mStudent = bst.search(id[5]);
      Console.WriteLine("The Sixth Inserted Student");
      Console.WriteLine("ID : {0:D4} / Name : {1}", mStudent.id, mStudent.name);
      Console.WriteLine();

      bst.delete(mStudent.id);
      Console.WriteLine("the student whos id is {0:D4} is deleted", mStudent.id);
      bst.printTree();
      Console.WriteLine();

      for (; ; ) {
        Console.Write("Input the ID you want to delete : ");
        try {
          int input = int.Parse(Console.ReadLine());
          mStudent = bst.search(input);
          if (mStudent != null) {
            bst.delete(input);
            bst.printTree();
            Console.WriteLine();
            break;
          } else {
            Console.WriteLine("There is no such People has that ID");
            Console.WriteLine();
          }
        } catch (FormatException e) {
          Console.WriteLine("Unexpected Input");
          Console.WriteLine();
          continue;
        }
      }
      
      Console.Read();
    }
  }
}
