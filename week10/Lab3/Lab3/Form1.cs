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
  public partial class Lab3 : Form {
    public Lab3() {
      InitializeComponent();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
    }

    private void ConfirmButton_Click(object sender, EventArgs e) {
      newMenuToolStripMenuItem.DropDownItems.Add(InputTextBox.Text);
      InputTextBox.Text = null;
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e) {
      PrintLabel.Text = toolStripMenuItem4.Text;
    }

    private void leftToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void centerToolStripMenuItem_Click(object sender, EventArgs e) {
    }

    private void leftTooStripMenuItem_Click(object sender, EventArgs e) {

    }
  }
}
