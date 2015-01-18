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
  public partial class FParentForm : Form
  {
    public FParentForm()
    {
      InitializeComponent();
    }

    private void FParentForm_Load(object sender, EventArgs e)
    {

    }

    private void alarmToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FAlarms form = new FAlarms();
      form.MdiParent = this;
      form.Show();
    }

    private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
