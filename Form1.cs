using Microsoft.Data.SqlClient;
using WinFormsApp1111;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrtAcc_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=FinanceDB;Trusted_Connection=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string login = TBLogIn.Text;
                string password = TBPassIn.Text;
                string query = "SELECT COUNT(*) FROM Users WHERE login = '" + login + "' AND password = '" + password + "'";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MainPage mainPage = new MainPage();
                            mainPage.Show();
                            TBLogIn.Clear();
                            TBPassIn.Clear();
                            Visible = false;
                            CurrentUser.CurUsId = UserAuthentication.FindUserId(login, password);
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                            TBLogIn.Clear();
                            TBPassIn.Clear();
                        }
                    }
                }
            }
        }
    }
}
