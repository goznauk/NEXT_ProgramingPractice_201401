using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

enum Bots { 심심이, 삼삼이, 숨숨이, 송송이 };


namespace Lab5 {
  public partial class Form1 : Form {
    Bots mBot = Bots.심심이;
    string sReply = "어쩌라고~";

    public Form1() {
      InitializeComponent();
      inputBox.KeyDown += new KeyEventHandler(my_key_handler);
      timer1.Tick += new EventHandler(reply);
    }

    private void CheckedChanged() {
      if (radioButton1.Checked == true) {
        mBot = Bots.심심이;
      } else if(radioButton2.Checked == true){
        mBot = Bots.삼삼이;
      } else if (radioButton3.Checked == true) {
        mBot = Bots.숨숨이;
      } else {
        mBot = Bots.송송이;
      }
      inputBox.Focus();
    }

    private void reply(object sender, EventArgs e) {
      displayBox.Text += mBot + "\t: " + sReply + "\r\n";
      timer1.Stop();
    }

    private void my_key_handler(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        button1_Click(sender, e);
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if (inputBox.Text != "") {
        displayBox.Text += "나\t: " + inputBox.Text + "\r\n";
        
        timer1.Start();
      }
      inputBox.Text = null;
      inputBox.Focus();
    }

    private void button2_Click(object sender, EventArgs e) {
      displayBox.Text = null;
      inputBox.Focus();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e) {
      CheckedChanged();
    }
    private void radioButton2_CheckedChanged(object sender, EventArgs e) {
      CheckedChanged();
    }
    private void radioButton3_CheckedChanged(object sender, EventArgs e) {
      CheckedChanged();
    }
    private void radioButton4_CheckedChanged(object sender, EventArgs e) {
      CheckedChanged();
    }
  }
}