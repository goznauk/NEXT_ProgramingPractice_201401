namespace Lab5 {
  partial class Form1 {
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
      this.components = new System.ComponentModel.Container();
      this.sendButton = new System.Windows.Forms.Button();
      this.resetButton = new System.Windows.Forms.Button();
      this.displayBox = new System.Windows.Forms.TextBox();
      this.inputBox = new System.Windows.Forms.TextBox();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // sendButton
      // 
      this.sendButton.Location = new System.Drawing.Point(197, 301);
      this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(79, 23);
      this.sendButton.TabIndex = 0;
      this.sendButton.Text = "보내기";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // resetButton
      // 
      this.resetButton.Location = new System.Drawing.Point(12, 332);
      this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(264, 29);
      this.resetButton.TabIndex = 1;
      this.resetButton.Text = "지우기";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // displayBox
      // 
      this.displayBox.BackColor = System.Drawing.SystemColors.Window;
      this.displayBox.Location = new System.Drawing.Point(12, 68);
      this.displayBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.displayBox.Multiline = true;
      this.displayBox.Name = "displayBox";
      this.displayBox.ReadOnly = true;
      this.displayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.displayBox.Size = new System.Drawing.Size(264, 225);
      this.displayBox.TabIndex = 2;
      // 
      // inputBox
      // 
      this.inputBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.inputBox.Location = new System.Drawing.Point(12, 301);
      this.inputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inputBox.Name = "inputBox";
      this.inputBox.Size = new System.Drawing.Size(179, 23);
      this.inputBox.TabIndex = 3;
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Location = new System.Drawing.Point(6, 25);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(61, 19);
      this.radioButton1.TabIndex = 4;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "심심이";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(71, 25);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(61, 19);
      this.radioButton2.TabIndex = 5;
      this.radioButton2.Text = "삼삼이";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton4);
      this.groupBox1.Controls.Add(this.radioButton3);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Location = new System.Drawing.Point(12, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Size = new System.Drawing.Size(264, 56);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "대화상대";
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(199, 25);
      this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(61, 19);
      this.radioButton4.TabIndex = 7;
      this.radioButton4.Text = "송송이";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(136, 25);
      this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(61, 19);
      this.radioButton3.TabIndex = 6;
      this.radioButton3.Text = "숨숨이";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(288, 369);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.inputBox);
      this.Controls.Add(this.displayBox);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.sendButton);
      this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Lab5";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.TextBox displayBox;
    private System.Windows.Forms.TextBox inputBox;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Timer timer1;
  }
}

