using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      openFileDialog.Filter = "text file(*.txt)|*.txt|All files(*.*)|*.*";
      saveFileDialog.Filter = "text file(*.txt)|*.txt|All files(*.*)|*.*";
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e) {
      statusToolStripStatusLabel.Text = LoadToolStripMenuItem.Text;
      string result = "";

      if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("euc-kr"));
        statusToolStripStatusLabel.Text = openFileDialog.FileName;

        while (sr.Peek() != -1) {
          string line = sr.ReadLine();
          result += line + "\r\n";
        }
        sr.Close();

        textBox.Text = result;
        
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
      if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true, Encoding.GetEncoding("euc-kr"));
        sw.Write(textBox.Text);
        sw.Close();
      }
    }
  }
}
