using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandClock {

  public enum Milliseconds { HALFDAY = 43200000, HOUR = 3600000, MINUTE = 60000, SECOND = 1000 };
  public enum CenterCoordinate { X = 300, Y = 300, RADIOUS = 200, OUTERRADIOUS = 205 };

  public partial class Form1 : Form {
    Graphics mGraphics;
    Coordinate center;
    ClockCoordinate mClock;
    Pen hourPen, minutePen, secondPen, mPen;

    Bitmap B;

    public Form1() {
      InitializeComponent();

      this.Paint += new PaintEventHandler(Form1_Paint);
      center = new Coordinate((int)CenterCoordinate.X, (int)CenterCoordinate.Y);
      mClock = new ClockCoordinate(center);
      hourPen = new Pen(Color.Black, 5);
      hourPen.Alignment = PenAlignment.Outset;
      hourPen.EndCap = LineCap.DiamondAnchor;
      minutePen = new Pen(Color.Black, 3);
      secondPen = new Pen(Color.Red, 2);
      secondPen.EndCap = LineCap.RoundAnchor;
      mPen = new Pen(Color.Black);
      mGraphics = this.CreateGraphics();
      mGraphics.Clear(Color.Linen);

      this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
    }

    private void Form1_Paint(object sender, PaintEventArgs e) {
      if (B != null) {
        e.Graphics.DrawImage(B, 0, 0);
      }
    }          
  

    protected override void OnPaintBackground(PaintEventArgs e) {
      //do not delete background
      //base.OnPaintBackground(e);
    }


    private void timer1_Tick(object sender, EventArgs e) {
      //manual double buffering - create bitmap
      if (B == null || B.Width != ClientSize.Width || B.Height != ClientSize.Height) {
        B = new Bitmap(ClientSize.Width, ClientSize.Height);
      }
      Graphics mGraphics = Graphics.FromImage(B);
      mGraphics.Clear(SystemColors.Window);

      //draw Clock
      this.Text = "Analog Clock : " + DateTime.Now.ToString();

      mClock.calculate(DateTime.Now);
      mGraphics.SmoothingMode = SmoothingMode.HighQuality;

      //clock
      mGraphics.DrawEllipse(minutePen, 100, 100, 400, 400);

      for (int i = 0; i < 60; i++) {
        if (i % 5 == 0) {
          // Draw 5 minute ticks
          mGraphics.DrawLine(minutePen,
          center.x + (float)((float)CenterCoordinate.RADIOUS / 1.00F * Math.Sin(i * 6 * Math.PI / 180)),
          center.y - (float)((float)CenterCoordinate.RADIOUS / 1.00F * Math.Cos(i * 6 * Math.PI / 180)),
          center.x + (float)((float)CenterCoordinate.RADIOUS / 1.12F * Math.Sin(i * 6 * Math.PI / 180)),
          center.y - (float)((float)CenterCoordinate.RADIOUS / 1.12F * Math.Cos(i * 6 * Math.PI / 180)));
        } else {
          // draw 1 minute ticks
          mGraphics.DrawLine(mPen,
          center.x + (float)((float)CenterCoordinate.RADIOUS / 1.00F * Math.Sin(i * 6 * Math.PI / 180)),
          center.y - (float)((float)CenterCoordinate.RADIOUS / 1.00F * Math.Cos(i * 6 * Math.PI / 180)),
          center.x + (float)((float)CenterCoordinate.RADIOUS / 1.07F * Math.Sin(i * 6 * Math.PI / 180)),
          center.y - (float)((float)CenterCoordinate.RADIOUS / 1.07F * Math.Cos(i * 6 * Math.PI / 180)));
        }
      }
  
      //hour
      mGraphics.DrawLine(hourPen,
        center.x, center.y, mClock.hCoordinate.x, mClock.hCoordinate.y);
        mGraphics.DrawEllipse(hourPen, 294, 294, 10, 10);

      //minute
      mGraphics.DrawLine(minutePen,
        center.x, center.y, mClock.mCoordinate.x, mClock.mCoordinate.y);
      mGraphics.DrawEllipse(minutePen, 295, 295, 8, 8);

      //second
      mGraphics.DrawLine(secondPen,
        center.x, center.y, mClock.sCoordinate.x, mClock.sCoordinate.y);

      mGraphics.DrawEllipse(secondPen, 296, 296, 6, 6);

      Invalidate();
    }
  }


  public class Coordinate {
    public float x, y;

    public Coordinate(float x, float y) {
      this.x = x;
      this.y = y;
    }
  }


  public class RadiousCoordinate {
    Coordinate center;
    double radious;
    double degree; //radian

    public RadiousCoordinate(Coordinate center, double degree) {
      this.center = center;
      this.degree = degree;
    }

    //size 0~1
    public Coordinate toCoordinate(float size) {
      radious = 0.98 * size * (float)CenterCoordinate.RADIOUS;
      return new Coordinate(center.x + (float)(radious * Math.Sin(degree)),
        center.y - (float)(radious * Math.Cos(degree)));
    }
  }

  public class ClockCoordinate {
    public bool isInitial = true;  
    public Coordinate hCoordinate;
    public Coordinate mCoordinate;
    public Coordinate sCoordinate;

    DateTime mDateTime;
    int simpleTime;
    Coordinate center;

    public ClockCoordinate(Coordinate center) {
      this.center = center;
    }

    public void calculate(DateTime time) {
      isInitial = false;
      RadiousCoordinate temp;
      mDateTime = time;
      simpleTime = (int)mDateTime.TimeOfDay.TotalMilliseconds;

      //hour
      simpleTime = simpleTime % (int)Milliseconds.HALFDAY;
      temp = new RadiousCoordinate(center,
        ((double)simpleTime / (int)Milliseconds.HALFDAY) * 2 * Math.PI);
      hCoordinate = temp.toCoordinate(0.75F);

      //minute
      simpleTime = simpleTime % (int)Milliseconds.HOUR;
      temp = new RadiousCoordinate(center,
        ((double)simpleTime / (int)Milliseconds.HOUR) * 2 * Math.PI);
      mCoordinate = temp.toCoordinate(0.9F);

      //second
      simpleTime = simpleTime % (int)Milliseconds.MINUTE;
      simpleTime = simpleTime - simpleTime % 40;

      temp = new RadiousCoordinate(center,
        ((double)simpleTime / (int)Milliseconds.MINUTE) * 2 * Math.PI);
      sCoordinate = temp.toCoordinate(1);

      return;
    }
  }
}
