using Microsoft.Data.SqlClient;
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
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }
        
        private void btnCrt1_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            Users user = dc.Users.Find(CurrentUser.CurUsId);

            Expenses exp = new Expenses()
            {
                Category = TBExCtg.Text,
                Value = int.Parse(TBVal.Text),
                Users = user
            };
            dc.Expenses.Add(exp);
            dc.SaveChanges();
            Close();
            MessageBox.Show("Расход добавлен.");
        }
    }
}
