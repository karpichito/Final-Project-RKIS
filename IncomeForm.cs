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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void btnCrtInc_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            Users user = dc.Users.Find(CurrentUser.CurUsId);

            Incomes inc = new Incomes()
            {
                IncomeSource = TBIncSrc.Text,
                Amount = int.Parse(TBAmount.Text),
                IncomeDate = TBIncDate.Text,
                Users = user
            };
            dc.Incomes.Add(inc);
            dc.SaveChanges();
            Close();
            MessageBox.Show("Доход добавлен.");
        }
    }
}
