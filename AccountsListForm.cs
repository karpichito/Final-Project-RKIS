using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class AccountsListForm : Form
    {
        public AccountsListForm(int Id)
        {
            InitializeComponent();
            using DataContext db = new DataContext();
            var accounts = db.Accounts.Where(i => i.Id == Id);
            foreach (var account in accounts)
            {
                listView1.Items.Add(account.ToString());
            }
        }
    }
}
