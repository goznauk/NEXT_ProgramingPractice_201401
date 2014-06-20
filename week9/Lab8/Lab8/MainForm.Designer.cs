namespace Lab8 {
  partial class MainForm {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다.
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
    /// </summary>
    private void InitializeComponent() {
      this.timeLabel = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.resetButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.timerRadioButton = new System.Windows.Forms.RadioButton();
      this.stopWatchRadioButton = new System.Windows.Forms.RadioButton();
      this.clockRadioButton = new System.Windows.Forms.RadioButton();
      this.functionLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.timeLabel.Font = new System.Drawing.Font("Consolas", 20F);
      this.timeLabel.Location = new System.Drawing.Point(12, 77);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(239, 146);
      this.timeLabel.TabIndex = 0;
      this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // startButton
      // 
      this.startButton.AutoSize = true;
      this.startButton.Font = new System.Drawing.Font("맑은 고딕", 15F);
      this.startButton.Location = new System.Drawing.Point(262, 187);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(120, 38);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // resetButton
      // 
      this.resetButton.AutoSize = true;
      this.resetButton.Font = new System.Drawing.Font("맑은 고딕", 15F);
      this.resetButton.Location = new System.Drawing.Point(398, 187);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(120, 38);
      this.resetButton.TabIndex = 2;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.timerRadioButton);
      this.groupBox1.Controls.Add(this.stopWatchRadioButton);
      this.groupBox1.Controls.Add(this.clockRadioButton);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 17F);
      this.groupBox1.Location = new System.Drawing.Point(262, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(256, 169);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "기능 선택";
      // 
      // timerRadioButton
      // 
      this.timerRadioButton.AutoSize = true;
      this.timerRadioButton.Location = new System.Drawing.Point(23, 119);
      this.timerRadioButton.Name = "timerRadioButton";
      this.timerRadioButton.Size = new System.Drawing.Size(90, 35);
      this.timerRadioButton.TabIndex = 3;
      this.timerRadioButton.TabStop = true;
      this.timerRadioButton.Text = "Timer";
      this.timerRadioButton.UseVisualStyleBackColor = true;
      this.timerRadioButton.CheckedChanged += new System.EventHandler(this.timerRadioButton_CheckedChanged);
      // 
      // stopWatchRadioButton
      // 
      this.stopWatchRadioButton.AutoSize = true;
      this.stopWatchRadioButton.Location = new System.Drawing.Point(23, 78);
      this.stopWatchRadioButton.Name = "stopWatchRadioButton";
      this.stopWatchRadioButton.Size = new System.Drawing.Size(146, 35);
      this.stopWatchRadioButton.TabIndex = 3;
      this.stopWatchRadioButton.TabStop = true;
      this.stopWatchRadioButton.Text = "StopWatch";
      this.stopWatchRadioButton.UseVisualStyleBackColor = true;
      this.stopWatchRadioButton.CheckedChanged += new System.EventHandler(this.stopWatchRadioButton_CheckedChanged);
      // 
      // clockRadioButton
      // 
      this.clockRadioButton.AutoSize = true;
      this.clockRadioButton.Location = new System.Drawing.Point(23, 37);
      this.clockRadioButton.Name = "clockRadioButton";
      this.clockRadioButton.Size = new System.Drawing.Size(90, 35);
      this.clockRadioButton.TabIndex = 3;
      this.clockRadioButton.TabStop = true;
      this.clockRadioButton.Text = "Clock";
      this.clockRadioButton.UseVisualStyleBackColor = true;
      this.clockRadioButton.CheckedChanged += new System.EventHandler(this.clockRadioButton_CheckedChanged);
      // 
      // functionLabel
      // 
      this.functionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.functionLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.functionLabel.Location = new System.Drawing.Point(12, 9);
      this.functionLabel.Name = "functionLabel";
      this.functionLabel.Size = new System.Drawing.Size(239, 56);
      this.functionLabel.TabIndex = 4;
      this.functionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(530, 236);
      this.Controls.Add(this.functionLabel);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.timeLabel);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label timeLabel;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton timerRadioButton;
    private System.Windows.Forms.RadioButton stopWatchRadioButton;
    private System.Windows.Forms.RadioButton clockRadioButton;
    private System.Windows.Forms.Label functionLabel;
  }
}

