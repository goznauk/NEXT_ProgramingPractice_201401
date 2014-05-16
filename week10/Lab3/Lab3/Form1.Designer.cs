namespace Lab3 {
  partial class Lab3 {
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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.DefaultItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.sdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.InputTextBox = new System.Windows.Forms.TextBox();
      this.ConfirmButton = new System.Windows.Forms.Button();
      this.PrintLabel = new System.Windows.Forms.Label();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultItem,
            this.toolStripMenuItem1,
            this.newMenuToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(284, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // DefaultItem
      // 
      this.DefaultItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
      this.DefaultItem.Name = "DefaultItem";
      this.DefaultItem.Size = new System.Drawing.Size(58, 20);
      this.DefaultItem.Text = "Default";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 22);
      this.toolStripMenuItem3.Text = "1";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(81, 22);
      this.toolStripMenuItem4.Text = "2";
      this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(81, 22);
      this.toolStripMenuItem5.Text = "3";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdToolStripMenuItem,
            this.sdfToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 20);
      this.toolStripMenuItem1.Text = "2";
      // 
      // sdToolStripMenuItem
      // 
      this.sdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.rightToolStripMenuItem});
      this.sdToolStripMenuItem.Name = "sdToolStripMenuItem";
      this.sdToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.sdToolStripMenuItem.Text = "text align";
      // 
      // leftToolStripMenuItem
      // 
      this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
      this.leftToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.leftToolStripMenuItem.Text = "left";
      this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftTooStripMenuItem_Click);
      // 
      // centerToolStripMenuItem
      // 
      this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
      this.centerToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.centerToolStripMenuItem.Text = "center";
      this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
      // 
      // rightToolStripMenuItem
      // 
      this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
      this.rightToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.rightToolStripMenuItem.Text = "right";
      // 
      // sdfToolStripMenuItem
      // 
      this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
      this.sdfToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.sdfToolStripMenuItem.Text = "sdf";
      // 
      // newMenuToolStripMenuItem
      // 
      this.newMenuToolStripMenuItem.Name = "newMenuToolStripMenuItem";
      this.newMenuToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.newMenuToolStripMenuItem.Text = "new menu!";
      // 
      // InputTextBox
      // 
      this.InputTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.InputTextBox.Location = new System.Drawing.Point(12, 155);
      this.InputTextBox.Name = "InputTextBox";
      this.InputTextBox.Size = new System.Drawing.Size(260, 27);
      this.InputTextBox.TabIndex = 1;
      // 
      // ConfirmButton
      // 
      this.ConfirmButton.Location = new System.Drawing.Point(12, 188);
      this.ConfirmButton.Name = "ConfirmButton";
      this.ConfirmButton.Size = new System.Drawing.Size(260, 23);
      this.ConfirmButton.TabIndex = 2;
      this.ConfirmButton.Text = "Confirm";
      this.ConfirmButton.UseVisualStyleBackColor = true;
      this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
      // 
      // PrintLabel
      // 
      this.PrintLabel.Location = new System.Drawing.Point(12, 64);
      this.PrintLabel.Name = "PrintLabel";
      this.PrintLabel.Size = new System.Drawing.Size(260, 23);
      this.PrintLabel.TabIndex = 4;
      this.PrintLabel.Text = "Default";
      // 
      // Lab3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.PrintLabel);
      this.Controls.Add(this.ConfirmButton);
      this.Controls.Add(this.InputTextBox);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "Lab3";
      this.Text = "Lab3";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.TextBox InputTextBox;
    private System.Windows.Forms.Button ConfirmButton;
    private System.Windows.Forms.Label PrintLabel;
    private System.Windows.Forms.ToolStripMenuItem DefaultItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem sdToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newMenuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
  }
}

