using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Maze {
  public enum DIRECTION { U, R, D, L, NULL=-1 }
  public enum BLOCKTYPE { ROAD, WALL, CURSOR, GOAL }
  public enum OPTION { AUTOMATIC=1, MANUAL }

  public class Coordinate {
    public int x { get; set; }
    public int y { get; set; }

    public Coordinate(int x, int y) {
      this.x = x;
      this.y = y;
    }

    public Coordinate getAnonymusCoordinate(int x, int y, int xx, int yy) {
      Coordinate tmp = new Coordinate(x + xx, y + yy);
      return tmp;
    }

    public Coordinate addDirection(DIRECTION dir) {
      switch (dir) {
        case DIRECTION.U:
          return getAnonymusCoordinate(this.x, this.y, 0, -1);
        case DIRECTION.D:
          return getAnonymusCoordinate(this.x, this.y, 0, 1);
        case DIRECTION.R:
          return getAnonymusCoordinate(this.x, this.y, 1, 0);
        case DIRECTION.L:
          return getAnonymusCoordinate(this.x, this.y, -1, 0);
        default:
          return null;
      }
    }

    public void moveDirection(DIRECTION dir) {
      this.x = this.addDirection(dir).x;
      this.y = this.addDirection(dir).y;
    }
  }

  public class Block {
    public Coordinate coordinate { get; set; }
    public BLOCKTYPE blocktype { get; set; }

    public Block() {
      this.coordinate = new Coordinate(0, 0);
      this.blocktype = BLOCKTYPE.ROAD;
    }
    public Block(Coordinate coordinate, BLOCKTYPE blocktype) {
      this.coordinate = coordinate;
      this.blocktype = blocktype;
    }

    public void drawBlock() {
      Console.SetCursorPosition(coordinate.x, coordinate.y);
      switch (blocktype) {
        case BLOCKTYPE.WALL:
          Console.Write("#");
          break;
        case BLOCKTYPE.CURSOR:
          Console.Write("@");
          break;
        case BLOCKTYPE.ROAD:
          Console.Write("");
          break;
        case BLOCKTYPE.GOAL:
          Console.Write("X");
          break;
      }
    }
  }

  public class Goal : Block {
    public Goal() {
      // this.coordinate = coordinate;
      this.blocktype = BLOCKTYPE.GOAL;
    }

    public void setGoal(Coordinate coordinate) {
      this.coordinate = coordinate;
    }
  }

  public class Cursor : Block {
    
    public Cursor(Coordinate coordinate) : base(coordinate, BLOCKTYPE.CURSOR) { }

    public void move(DIRECTION dir) {
      this.coordinate.moveDirection(dir);
    }

    public bool canMove(Map map, DIRECTION dir) {
      return map.isRoad(this.coordinate.addDirection(dir));
    }
    
    public bool isGoal(Goal goal) {
      if (this.coordinate == goal.coordinate) {
        Console.WriteLine("gogogogogoal");
      }
      return this.coordinate == goal.coordinate;
    }
  }

  public class Route {
    int moved;
    Coordinate coordinate;
    DIRECTION direction;

    public Route(int moved, Coordinate coordinate, DIRECTION dir) {
      this.moved = moved;
      this.coordinate = coordinate;
      this.direction = dir;
    }

    public DIRECTION getDirection() {
      return direction;
    }

    public DIRECTION getInvertedDirection() {
      if (direction != DIRECTION.NULL) {
        return (DIRECTION)(((int)direction + 2) % 4);
      }
      return DIRECTION.NULL;
    }

    public Coordinate getCoordinate() {
      return coordinate;
    }
  }

  public class Map {
  
    public Block[,] blocks = new Block[11,11];
    public Cursor cursor = new Cursor(new Coordinate(1, 1));
    public Goal goal = new Goal();


    public Map(int[,] source) {
      for (int i = 0; i < 11; i++) {
        for (int j = 0; j < 11; j++) {
          blocks[i,j] = new Block(new Coordinate(i,j), (BLOCKTYPE)source[i,j]);
        }
      }
    }

    public bool isRoad(Coordinate mCoordinate) {
      return blocks[mCoordinate.x,mCoordinate.y].blocktype == BLOCKTYPE.ROAD;
    }

    public void drawMap() {
      Console.Clear();
      foreach (Block b in blocks) {
        b.drawBlock();
      }
      goal.drawBlock();
      cursor.drawBlock();
    }  
  }

  class Program {
    public static int getOption() {
      Console.WriteLine("Choose Your Option!");
      Console.WriteLine("1. Automatic");
      Console.WriteLine("2. Manual");
      Console.WriteLine();
      Console.Write("Input the number of your option : ");
      return int.Parse(Console.ReadLine());
    }
    public static void findAnswer(Map map) {
      Stack<Route> routeStack = new Stack<Route>();
      routeStack.Push(new Route(0,null,DIRECTION.NULL));
      Coordinate lastPoint = new Coordinate(0, 0);
      int moves = 0;

      for (; ; ) {
        int i = 0;

        for (int dir = (int)routeStack.Peek().getInvertedDirection() + 1; ; dir++) {
          i++;
          DIRECTION d = (DIRECTION)(dir % 4);

          //test code
          Console.SetCursorPosition(0, 14);
          Console.WriteLine("dir = {0}, DIRECTION = {1}, i = {2}", dir, (int)d, i);

          //갈 방향이 왔던 곳이면 방향 ++
          if (lastPoint == map.cursor.coordinate.addDirection(d)) { continue; }

          //막다른 길이 아니면 가고, 막다른 길이면 팝

          if (map.cursor.canMove(map, d)) {
            routeStack.Push(new Route(moves, map.cursor.coordinate, d));

            lastPoint = map.cursor.coordinate;
            map.cursor.move(d);
            map.drawMap();
            moves++;
            break;
          }

          if (i >= 4) {
            lastPoint = map.cursor.coordinate;
            map.cursor.move(routeStack.Pop().getInvertedDirection());
            map.drawMap();
            moves++;
            break;
          }
        }
        Console.SetCursorPosition(0, 16);
        Console.WriteLine("{0} times moved", moves);

        Thread.Sleep(100);
        

//        if (map.goal.isGoal(map.cursor.coordinate)) 
     //   if (map.goal.coordinate == map.cursor.coordinate) {
        if (map.cursor.coordinate.x == 9 && map.cursor.coordinate.y == 9) {
          Console.SetCursorPosition(0, 13);
          Console.WriteLine("Finished");
          return;
        }
      }
    }


    public static void manualMove(Map map) {
      int moved = 0;
      ConsoleKeyInfo cki;
      DIRECTION dir = DIRECTION.NULL;
      Console.SetCursorPosition(0, 17);
      Console.WriteLine("Press Q to EXIT");
      

      while (true) {
        cki = Console.ReadKey(true);
        switch (cki.Key) {
          case ConsoleKey.LeftArrow:
            dir = DIRECTION.L;
            break;
          case ConsoleKey.RightArrow:
            dir = DIRECTION.R;
            break;
          case ConsoleKey.UpArrow:
            dir = DIRECTION.U;
            break;
          case ConsoleKey.DownArrow:
            dir = DIRECTION.D;
            break;
          case ConsoleKey.Q:
            return;
          default:
            break;
        }
        if (map.cursor.canMove(map, dir)) {
          map.cursor.move(dir);
          map.drawMap();
          moved++;
        }

        Console.SetCursorPosition(0, 16);
        Console.WriteLine("{0} times moved", moved);

      //  if (map.cursor.isGoal(map.goal)) {
        if (map.cursor.coordinate.x == 9 && map.cursor.coordinate.y == 9) {
          Console.SetCursorPosition(0, 13);
          Console.WriteLine("You Win!");
          break;
        }
      }

    }

    public static Map setMap(int[,] source) {
      Map map = new Map(source);
      map.goal.setGoal(new Coordinate(9, 9));
      map.drawMap();
      return map;
    }


    static void Main(string[] args) {

      //Worst Case Map Source!
      int[,] mapSource = new int[,] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 }, { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1 }, { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

      int option;

      for (; ; ) {
        option = getOption();
        if (option == 1 || option == 2) { break; }
        Console.WriteLine("UNEXPECTED INPUT : PLEASE PRESS 1 OR 2");
      }

      Console.Clear();
      Map mMap = setMap(mapSource);

      switch (option) {
        case (int)OPTION.AUTOMATIC:
          findAnswer(mMap);
          break;
        case (int)OPTION.MANUAL:
          manualMove(mMap);
          Console.SetCursorPosition(0, 18);
          break;
      }
      Console.WriteLine("Press Any Key To Exit");
      Console.WriteLine("Thank You");

      ConsoleKeyInfo toExit = Console.ReadKey(false);
    }
  }
}
