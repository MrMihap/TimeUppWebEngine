namespace DebugOnline
{
  partial class FParentForm
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alarmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.showToolStripMenuItem,
            this.createToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(901, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // showToolStripMenuItem
      // 
      this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmToolStripMenuItem1,
            this.usersToolStripMenuItem});
      this.showToolStripMenuItem.Name = "showToolStripMenuItem";
      this.showToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.showToolStripMenuItem.Text = "Show";
      // 
      // createToolStripMenuItem
      // 
      this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.alarmToolStripMenuItem});
      this.createToolStripMenuItem.Name = "createToolStripMenuItem";
      this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.createToolStripMenuItem.Text = "Create";
      // 
      // userToolStripMenuItem
      // 
      this.userToolStripMenuItem.Name = "userToolStripMenuItem";
      this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.userToolStripMenuItem.Text = "User";
      // 
      // alarmToolStripMenuItem
      // 
      this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
      this.alarmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.alarmToolStripMenuItem.Text = "Alarm";
      this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
      // 
      // alarmToolStripMenuItem1
      // 
      this.alarmToolStripMenuItem1.Name = "alarmToolStripMenuItem1";
      this.alarmToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.alarmToolStripMenuItem1.Text = "Alarm";
      this.alarmToolStripMenuItem1.Click += new System.EventHandler(this.alarmToolStripMenuItem1_Click);
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.usersToolStripMenuItem.Text = "Users";
      // 
      // FParentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(901, 389);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FParentForm";
      this.Text = "Time App Data Viewer";
      this.Load += new System.EventHandler(this.FParentForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
  }
}

