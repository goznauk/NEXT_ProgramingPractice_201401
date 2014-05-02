﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      textBox2.KeyDown += new KeyEventHandler(my_key_handler);
    }

    private void my_key_handler (object sender, KeyEventArgs e) {
      if(e.KeyCode == Keys.Enter) {
        button1_Click(sender, e);
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if (textBox2.Text != "") {
        textBox1.Text += textBox2.Text + "\r\n";
        textBox2.Text = null;
      }
      textBox2.Focus();
    }

    private void button2_Click(object sender, EventArgs e) {
      textBox1.Text = null;
    }
  }
}
