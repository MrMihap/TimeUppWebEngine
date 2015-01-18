namespace DebugOnline
{
  partial class FCreateAlarm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.UserName = new System.Windows.Forms.TextBox();
      this.DestX = new System.Windows.Forms.TextBox();
      this.addr = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.DestY = new System.Windows.Forms.TextBox();
      this.CreateButton = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.AlarmName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "User Acc";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Destination";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(115, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(14, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Y";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Addres";
      // 
      // UserName
      // 
      this.UserName.Location = new System.Drawing.Point(118, 13);
      this.UserName.Name = "UserName";
      this.UserName.Size = new System.Drawing.Size(203, 20);
      this.UserName.TabIndex = 1;
      this.UserName.Text = "ivan@gogle.com";
      // 
      // DestX
      // 
      this.DestX.Location = new System.Drawing.Point(135, 38);
      this.DestX.Name = "DestX";
      this.DestX.Size = new System.Drawing.Size(186, 20);
      this.DestX.TabIndex = 1;
      this.DestX.Text = "00.0000";
      // 
      // addr
      // 
      this.addr.Location = new System.Drawing.Point(59, 90);
      this.addr.Multiline = true;
      this.addr.Name = "addr";
      this.addr.Size = new System.Drawing.Size(262, 62);
      this.addr.TabIndex = 1;
      this.addr.Text = "Country, State, street, etc";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(115, 41);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(14, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "X";
      // 
      // DestY
      // 
      this.DestY.Location = new System.Drawing.Point(135, 64);
      this.DestY.Name = "DestY";
      this.DestY.Size = new System.Drawing.Size(186, 20);
      this.DestY.TabIndex = 1;
      this.DestY.Text = "00.0000";
      // 
      // CreateButton
      // 
      this.CreateButton.Location = new System.Drawing.Point(225, 158);
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(96, 23);
      this.CreateButton.TabIndex = 2;
      this.CreateButton.Text = "CREATE";
      this.CreateButton.UseVisualStyleBackColor = true;
      this.CreateButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 163);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Name";
      // 
      // AlarmName
      // 
      this.AlarmName.Location = new System.Drawing.Point(53, 160);
      this.AlarmName.Name = "AlarmName";
      this.AlarmName.Size = new System.Drawing.Size(110, 20);
      this.AlarmName.TabIndex = 1;
      this.AlarmName.Text = "WORK";
      // 
      // FCreateAlarm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 187);
      this.Controls.Add(this.CreateButton);
      this.Controls.Add(this.AlarmName);
      this.Controls.Add(this.DestY);
      this.Controls.Add(this.addr);
      this.Controls.Add(this.DestX);
      this.Controls.Add(this.UserName);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FCreateAlarm";
      this.Text = "FCreateAlarm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox UserName;
    private System.Windows.Forms.TextBox DestX;
    private System.Windows.Forms.TextBox addr;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox DestY;
    private System.Windows.Forms.Button CreateButton;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox AlarmName;
  }
}