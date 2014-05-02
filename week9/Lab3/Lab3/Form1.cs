using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3 {
  public partial class Form1 : Form {
    bool isclicked = false;
    int i = 0;

    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      i++;
      label1.Text = i + " times clicked";

      switch (isclicked) {
        case true :
          label2.Text = "isClicked = false";
          isclicked = false;
          break;

        case false :
          label2.Text = "isClicked = true";
          isclicked = true;
          break;
      }


    }

    private void Form1_Load(object sender, EventArgs e) {

    }
  }
}
