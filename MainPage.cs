using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Data;

namespace WinFormsApp1111
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void UpdateAccounts()
        {
            listView3.Items.Clear();
            using DataContext dc = new DataContext();
            var list = dc.Accounts.Where(account => account.Users.Id == CurrentUser.CurUsId).ToList();
            foreach (var account in list)
            {
                listView3.Items.Add($"{account.AccountName} - {account.Balance} руб.");
            }
        }

        public void UpdateIncomes()
        {
            listView2.Items.Clear();
            using DataContext dc = new DataContext();
            var list = dc.Incomes.Where(income => income.Users.Id == CurrentUser.CurUsId).ToList();
            foreach (var income in list)
            {
                listView2.Items.Add($"{income.IncomeSource} - {income.Amount} руб.");
            }
        }

        public void UpdateExpenses()
        {
            listView1.Items.Clear();
            using DataContext dc = new DataContext();
            var list = dc.Expenses.Where(expense => expense.Users.Id == CurrentUser.CurUsId).ToList();
            foreach (var expense in list)
            {
                listView1.Items.Add($"{expense.Category} - {expense.Value} руб.");
            }
        }

        private void btnCrtExp_Click(object sender, EventArgs e)
        {
            UpdateExpenses();
            ExpenseForm expenseForm = new ExpenseForm();
            expenseForm.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            UpdateExpenses();
            UpdateIncomes();
            UpdateAccounts();
            btnRfr.FlatStyle = FlatStyle.Flat;
            btnRfr.FlatAppearance.BorderSize = 0;
        }

        private void btnCrtInc_Click(object sender, EventArgs e)
        {
            UpdateIncomes();
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.Show();
        }

        private void btnCrtAcc_Click(object sender, EventArgs e)
        {
            UpdateAccounts();
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void btnRfr_Click(object sender, EventArgs e)
        {
            UpdateExpenses();
            UpdateIncomes();
            UpdateAccounts();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView1.SelectedItems)
            {
                var temp = item as ListViewItem;
                var text = temp.Text.Split(" ")[0];
                using DataContext db = new DataContext();
                var expense = db.Expenses.First(i => i.Category == text);
                ExpenseListForm expenseListForm = new ExpenseListForm(expense.Id);
                expenseListForm.Show();
            }
        }



        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView2.SelectedItems)
            {
                var temp = item as ListViewItem;
                var text = temp.Text.Split(" ")[0];
                using DataContext db = new DataContext();
                var income = db.Incomes.First(i => i.IncomeSource == text);
                IncomesListForm incomesListForm = new IncomesListForm(income.Id);
                incomesListForm.Show();
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView3.SelectedItems)
            {
                var temp = item as ListViewItem;
                var text = temp.Text.Split(" ")[0];
                using DataContext db = new DataContext();
                var account = db.Accounts.First(i => i.AccountName == text);
                AccountsListForm accountsListForm = new AccountsListForm(account.Id);
                accountsListForm.Show();
            }
        }
    }
}
