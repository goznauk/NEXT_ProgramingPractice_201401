using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|모든파일(*.*)|*.*";

    }
    
    private void button1_Click(object sender, EventArgs e) {
      if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)) {
        return;
      }
      Image img = Image.FromFile(openFileDialog1.FileName);
      pictureBox1.Width = img.Width;
      pictureBox1.Height = img.Height;
      pictureBox1.Image = img;
    }

    private void button2_Click(object sender, EventArgs e) {

    }

    private void pictureBox1_Click(object sender, EventArgs e) {

    }
  }
}
