using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Timers;

namespace Lab8 {
  public interface IModel : INotifyPropertyChanged {
    FUNCTION Function { get; set; }
    STATUS Status { get; set; }
    string Display { get; set; }

    //Start/Pause Function(Not used in CurrentClock)
    void Start();
    void Pause();

    //Display Making Function
    void Calculate();
    void Calculate(object source, EventArgs e);
  }

  abstract class Model : IModel {
    private FUNCTION function;
    private STATUS status;
    private string display;

    public Model() {
      status = STATUS.INITIALIZED;
      onValueChanged("Function");
      onValueChanged("Status");
      onValueChanged("Display");
    }

    #region IModel Members
   
    public FUNCTION Function {
      get { return function; }
      set {
        if (function == value) { return; }
        function = value;
        onValueChanged("Function");
      }
    }

    public STATUS Status {
      get { return status; }
      set {
        if (status == value) { return; }
        status = value;
        onValueChanged("Status");
      }
    }

    public string Display {
      get { return display; }
      set {
        if (display == value) { return; }
        display = value;
        onValueChanged("Display");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void onValueChanged(string propertyName) {
      if (null != PropertyChanged) {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    #endregion

    #region IModel Methods
    //Start/Pause Function(Not used in CurrentClock)
    virtual public void Start() { Status = STATUS.STARTED; }
    virtual public void Pause() { Status = STATUS.PAUSED; }

    //Display Making Function
    abstract public void Calculate();
    public void Calculate(object source, EventArgs e) { Calculate(); }

    #endregion  
  }

  class CurrentClockModel : Model {
    public CurrentClockModel()
      : base() {
      Function = FUNCTION.CURRENTCLOCK;
      Calculate();
    }

    public override void Calculate() {
      Display = DateTime.Now.ToString("yyyy/MM/dd\nhh:mm:ss:ff");
    }
  }

  class StopWatchModel : Model {
    DateTime startedTime;
    TimeSpan total, each;

    public StopWatchModel()
      : base() {
      Function = FUNCTION.STOPWATCH;
      total = new TimeSpan();
      Display = "00:00:00";
    }

    public override void Start() {
      Status = STATUS.STARTED;

      startedTime = DateTime.Now;
      each = new TimeSpan();
    }

    public override void Pause() {
      Status = STATUS.PAUSED;

      each = DateTime.Now - startedTime;
      total += each;
    }

    public override void Calculate() {
      each = DateTime.Now - startedTime;
      Display = string.Format("{0:d2}:{1:d2}:{2:d2}",
        (total + each).Minutes, (total + each).Seconds, (total + each).Milliseconds / 10);
    }
  }

  class TimeAttackModel : Model {
    DateTime goal;
    TimeSpan interval;

    TimeSpan Interval {
      get { return interval; }
      set { interval = value; }
    }

    public TimeAttackModel(TimeSpan interval)
      : base() {
      Function = FUNCTION.TIMERCLOCK;
      this.interval = interval;
      Display = string.Format("{0:d2}:{1:d2}:{2:d2}:{3:d2}", 
        interval.Hours, interval.Minutes, interval.Seconds, interval.Milliseconds / 10);
    }

    public override void Start() {
      Status = STATUS.STARTED;
      goal = DateTime.Now.Add(interval);
    }

    public override void Pause() {
      Status = STATUS.PAUSED;
      interval = goal - DateTime.Now;
    }

    public override void Calculate() {
      interval = goal - DateTime.Now;
      Display = string.Format("{0:d2}:{1:d2}:{2:d2}:{3:d2}", 
        interval.Hours, interval.Minutes, interval.Seconds, interval.Milliseconds / 10);
    }
  }
}