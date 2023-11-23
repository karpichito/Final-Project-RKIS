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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnCrtAcc_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            Users user = dc.Users.Find(CurrentUser.CurUsId);

            Accounts acc = new Accounts()
            {
                AccountName = TBAccName.Text,
                AccountType = TBAccType.Text,
                Balance = int.Parse(TBBalance.Text),
                OpeningDate = TBOpDate.Text,
                Users = user
            };
            dc.Accounts.Add(acc);
            dc.SaveChanges();
            Close();
            MessageBox.Show("Счет добавлен.");
        }
    }
}
