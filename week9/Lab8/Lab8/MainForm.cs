using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8 {
  public enum FUNCTION { CURRENTCLOCK, STOPWATCH, TIMERCLOCK, NULL=-1}
  public enum STATUS { INITIALIZED, STARTED, PAUSED }
  public enum FORMAT { MMSSFF, HHMMSSFF }

  public interface IView : INotifyPropertyChanged {
    FUNCTION Function { get; set; }
    STATUS Status { get; set; }
    string Display { get; set; }
    event EventHandler startButtonClicked;
    event EventHandler resetButtonClicked;
  }

  public partial class MainForm : Form, IView {

    Presenter mPresenter;

    public MainForm() {
      InitializeComponent();
      functionLabel.Text = "HELLO";
      mPresenter = new Presenter(this);
    }

    #region IView Member
    public FUNCTION Function {
      get {
        switch (functionLabel.Text) {
          case "CURRENTCLOCK":
            return FUNCTION.CURRENTCLOCK;
          case "STOPWATCH":
            return FUNCTION.STOPWATCH;
          case "TIMERCLOCK":
            return FUNCTION.TIMERCLOCK;
          default:
            return FUNCTION.NULL;
        }
      }
      set {
        if (functionLabel.Text == value.ToString()) { return; }
        functionLabel.Text = value.ToString();
        OnValueChanged("Function");
      }
    }

    STATUS IView.Status {
      get {
        if (startButton.Text == "Start") {
          return STATUS.PAUSED;
        } else {
          return STATUS.STARTED;
        }
      }
      set {
        if (value == STATUS.STARTED) {
          startButton.Text = "Pause";
        } else {
          startButton.Text = "Start";
        }
       // change("Status");
      }
    }

    string IView.Display {
      get { return timeLabel.Text; }
      set { timeLabel.Text = value; }
    }

    public event EventHandler startButtonClicked {
      add { startButton.Click += value; }
      remove { startButton.Click -= value; }
    }

    public event EventHandler resetButtonClicked {
      add { resetButton.Click += value; }
      remove { resetButton.Click -= value; }
    }

    #endregion



    #region INotifyPropertyChanged Members
    public event PropertyChangedEventHandler PropertyChanged;

    private void OnValueChanged(string propertyName) {
      if (PropertyChanged != null) {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
    #endregion


    private void clockRadioButton_CheckedChanged(object sender, EventArgs e) {
      Function = FUNCTION.CURRENTCLOCK;
    }

    private void stopWatchRadioButton_CheckedChanged(object sender, EventArgs e) {
      Function = FUNCTION.STOPWATCH;
    }

    private void timerRadioButton_CheckedChanged(object sender, EventArgs e) {
      Function = FUNCTION.TIMERCLOCK;
    }

    private void startButton_Click(object sender, EventArgs e) {
      if (functionLabel.Text == "HELLO") {
        MessageBox.Show("Please Select the Function.");
        return;
      }
    }

    private void resetButton_Click(object sender, EventArgs e) {
      mPresenter.reset();
    }
  }
}
