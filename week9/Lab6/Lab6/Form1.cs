using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Lab6 {
  public partial class Form1 : Form {
    bool playing;
    SoundPlayer sp;

    public Form1() {
      InitializeComponent();
      sp = new SoundPlayer(Properties.Resources.bell);
    }

    private void playButton_Click(object sender, EventArgs e) {
      if (playing) {
        sp.Stop();
        playButton.Cursor = Cursors.Default;
        playButton.Text = "재생";
        playing = false;
      } else {
        sp.PlayLooping();
        playButton.Cursor = Cursors.AppStarting;
        playButton.Text = "멈춤";
        playing = true;
      }

    }
  }
}
