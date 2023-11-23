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

namespace WinFormsApp1111
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnCrtAcc_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();
            Users u = new Users()
            {
                Name = textBoxNameReg.Text,
                Surname = textBoxSurnameReg.Text,
                Email = textBoxEmailReg.Text,
                Login = textBoxLogReg.Text,
                Password = textBoxPasReg.Text,
            };
            dc.Users.Add(u);
            dc.SaveChanges();
            Close();
            MessageBox.Show("Аккаунт успешно создан!");
        }
    }
}
