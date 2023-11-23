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
    public partial class IncomesListForm : Form
    {
        public IncomesListForm(int Id)
        {
            InitializeComponent();
            using DataContext db = new DataContext();
            var incomes = db.Incomes.Where(i => i.Id == Id);
            foreach (var income in incomes)
            {
                listView1.Items.Add(income.ToString());
            }
        }
    }
}
