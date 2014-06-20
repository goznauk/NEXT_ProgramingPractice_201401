namespace Lab8 {
  partial class TimerDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.hourTextBox = new System.Windows.Forms.TextBox();
      this.minuteTextBox = new System.Windows.Forms.TextBox();
      this.secondTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.resetButton = new System.Windows.Forms.Button();
      this.applyButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // hourTextBox
      // 
      this.hourTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.hourTextBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.hourTextBox.Location = new System.Drawing.Point(14, 55);
      this.hourTextBox.Name = "hourTextBox";
      this.hourTextBox.Size = new System.Drawing.Size(60, 35);
      this.hourTextBox.TabIndex = 0;
      // 
      // minuteTextBox
      // 
      this.minuteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.minuteTextBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.minuteTextBox.Location = new System.Drawing.Point(110, 55);
      this.minuteTextBox.Name = "minuteTextBox";
      this.minuteTextBox.Size = new System.Drawing.Size(60, 35);
      this.minuteTextBox.TabIndex = 1;
      // 
      // secondTextBox
      // 
      this.secondTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.secondTextBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.secondTextBox.Location = new System.Drawing.Point(206, 55);
      this.secondTextBox.Name = "secondTextBox";
      this.secondTextBox.Size = new System.Drawing.Size(60, 35);
      this.secondTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(278, 37);
      this.label1.TabIndex = 3;
      this.label1.Text = "Input the time [HH:MM:SS]";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(176, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(24, 37);
      this.label2.TabIndex = 4;
      this.label2.Text = ":";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(80, 47);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(24, 37);
      this.label4.TabIndex = 6;
      this.label4.Text = ":";
      // 
      // resetButton
      // 
      this.resetButton.AutoSize = true;
      this.resetButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.resetButton.Location = new System.Drawing.Point(14, 107);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(115, 35);
      this.resetButton.TabIndex = 7;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // applyButton
      // 
      this.applyButton.AutoSize = true;
      this.applyButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.applyButton.Location = new System.Drawing.Point(151, 107);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(115, 35);
      this.applyButton.TabIndex = 8;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // TimerDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(278, 152);
      this.Controls.Add(this.applyButton);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.secondTextBox);
      this.Controls.Add(this.minuteTextBox);
      this.Controls.Add(this.hourTextBox);
      this.Name = "TimerDialog";
      this.Text = "TimerDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox hourTextBox;
    private System.Windows.Forms.TextBox minuteTextBox;
    private System.Windows.Forms.TextBox secondTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Button applyButton;
  }
}