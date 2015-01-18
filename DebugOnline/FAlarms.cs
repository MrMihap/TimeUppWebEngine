using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugOnline
{
  public partial class FAlarms : Form
  {
    public FAlarms()
    {
      InitializeComponent();
    }

    private void FAlarms_Load(object sender, EventArgs e)
    {
      // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_9B88FC_mainDataSet.Tasks". При необходимости она может быть перемещена или удалена.
      this.tasksTableAdapter.Fill(this.dB_9B88FC_mainDataSet.Tasks);

    }
  }
}
