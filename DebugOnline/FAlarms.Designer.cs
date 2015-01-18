namespace DebugOnline
{
  partial class FAlarms
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
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dB_9B88FC_mainDataSet = new DebugOnline.DB_9B88FC_mainDataSet();
      this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tasksTableAdapter = new DebugOnline.DB_9B88FC_mainDataSetTableAdapters.TasksTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.startPointIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.endPointIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.destinationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.userAccountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dB_9B88FC_mainDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startPointIdDataGridViewTextBoxColumn,
            this.endPointIdDataGridViewTextBoxColumn,
            this.destinationTimeDataGridViewTextBoxColumn,
            this.userAccountIdDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.tasksBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(744, 344);
      this.dataGridView1.TabIndex = 0;
      // 
      // dB_9B88FC_mainDataSet
      // 
      this.dB_9B88FC_mainDataSet.DataSetName = "DB_9B88FC_mainDataSet";
      this.dB_9B88FC_mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tasksBindingSource
      // 
      this.tasksBindingSource.DataMember = "Tasks";
      this.tasksBindingSource.DataSource = this.dB_9B88FC_mainDataSet;
      // 
      // tasksTableAdapter
      // 
      this.tasksTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // userIdDataGridViewTextBoxColumn
      // 
      this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
      this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
      this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // startPointIdDataGridViewTextBoxColumn
      // 
      this.startPointIdDataGridViewTextBoxColumn.DataPropertyName = "StartPointId";
      this.startPointIdDataGridViewTextBoxColumn.HeaderText = "StartPointId";
      this.startPointIdDataGridViewTextBoxColumn.Name = "startPointIdDataGridViewTextBoxColumn";
      // 
      // endPointIdDataGridViewTextBoxColumn
      // 
      this.endPointIdDataGridViewTextBoxColumn.DataPropertyName = "EndPointId";
      this.endPointIdDataGridViewTextBoxColumn.HeaderText = "EndPointId";
      this.endPointIdDataGridViewTextBoxColumn.Name = "endPointIdDataGridViewTextBoxColumn";
      // 
      // destinationTimeDataGridViewTextBoxColumn
      // 
      this.destinationTimeDataGridViewTextBoxColumn.DataPropertyName = "DestinationTime";
      this.destinationTimeDataGridViewTextBoxColumn.HeaderText = "DestinationTime";
      this.destinationTimeDataGridViewTextBoxColumn.Name = "destinationTimeDataGridViewTextBoxColumn";
      // 
      // userAccountIdDataGridViewTextBoxColumn
      // 
      this.userAccountIdDataGridViewTextBoxColumn.DataPropertyName = "userAccount_Id";
      this.userAccountIdDataGridViewTextBoxColumn.HeaderText = "userAccount_Id";
      this.userAccountIdDataGridViewTextBoxColumn.Name = "userAccountIdDataGridViewTextBoxColumn";
      // 
      // FAlarms
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 356);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FAlarms";
      this.Text = "FAlarms";
      this.Load += new System.EventHandler(this.FAlarms_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dB_9B88FC_mainDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DB_9B88FC_mainDataSet dB_9B88FC_mainDataSet;
    private System.Windows.Forms.BindingSource tasksBindingSource;
    private DB_9B88FC_mainDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn startPointIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn endPointIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn destinationTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn userAccountIdDataGridViewTextBoxColumn;
  }
}