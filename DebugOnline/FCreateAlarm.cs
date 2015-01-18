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
  public partial class FCreateAlarm : Form
  {
    public FCreateAlarm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Alarm task = new Alarm();
      task.DestinationTime = DateTime.Now;
      task.Name = AlarmName.Text;
      using (AppContext _db = new AppContext())
      {
        UserAccount acc;
        if (_db.UserAccounts.Where(x => x.EMail.Equals(UserName.Text)).Count() > 0)
        {
          acc = new UserAccount();
          acc.EMail = UserName.Text;
          _db.UserAccounts.Add(acc);
          _db.SaveChanges();
        }
        else
        {
          acc = (from account 
                 in _db.UserAccounts 
                 where account.EMail.Equals(UserName.Text) 
                 select account).First();
        }
        task.userAccount = acc;
        task.userId = acc.Id;
        _db.Tasks.Add(task);
        _db.SaveChanges();
      }
    } 
  }
}
