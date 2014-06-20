using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;


namespace Lab8 {
  public class Presenter {
    private IModel model;
    private readonly IView view;
    private static Timer mTimer = new Timer();
    
    public Presenter(IView view) {
      this.view = view;
      view.PropertyChanged += new PropertyChangedEventHandler(view_onchange);
    }

    public void setFunction(FUNCTION f) {
      switch (f) {
        case FUNCTION.CURRENTCLOCK:
          model = new CurrentClockModel();
          Start();
          return;
        case FUNCTION.STOPWATCH:
          model = new StopWatchModel();
          return;
        case FUNCTION.TIMERCLOCK:
          for (; ; ) {
            TimerDialog tDialog = new TimerDialog();
            System.Windows.Forms.DialogResult dResult = tDialog.ShowDialog();
            if (dResult == System.Windows.Forms.DialogResult.OK
              || dResult == System.Windows.Forms.DialogResult.Cancel) {
              model = new TimeAttackModel(tDialog.TimerSetting);
              return;
            }
          }
      }
    }

    public void init(FUNCTION f) {
      if (model != null) {
        if (model.Status == STATUS.STARTED) { model.Pause(); }
      }
      if (mTimer.Enabled == true) { mTimer.Stop(); }

     // MessageBox.Show(string.Format("init Called, init({0})", f.ToString()));

      setFunction(f);

      view.Display = model.Display;

      view.startButtonClicked +=
        (sender, args) => {
          if (model.Status == STATUS.STARTED) { Pause(); } else { Start(); }
        };
      
      model.PropertyChanged += model_PropertyChanged;
    }

    public void reset() {
      setFunction(model.Function);
      view.Display = model.Display;  
    }

    public void Start() {
      if (model != null) {
        model.Start();

        mTimer.Interval = 10;
        mTimer.Tick += new EventHandler(model.Calculate);
        mTimer.Start();
      }
    }

    public void Pause() {
      if (model.Function == FUNCTION.CURRENTCLOCK) { return; }
      model.Pause();
      mTimer.Stop();
    }

    private void model_PropertyChanged(object sender, PropertyChangedEventArgs e) {
      updateViewWithModel();
    }

    private void updateViewWithModel() {
      view.Display = model.Display;
      view.Status = model.Status;
    }

    private void view_onchange(object sender, EventArgs e) {
      updateModelwithView();
    }

    private void updateModelwithView() {
      init(view.Function);
    }
  }
}
