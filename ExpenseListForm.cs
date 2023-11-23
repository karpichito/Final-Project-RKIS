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
    public partial class ExpenseListForm : Form
    {
        public ExpenseListForm(int Id)
        {
            InitializeComponent();
            using DataContext db = new DataContext();
            var expenses = db.Expenses.Where(i => i.Id == Id);
            foreach (var expense in expenses)
            {
                listView1.Items.Add(expense.ToString());
            }
        }
    }
}
