using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Expenses> Expenses { get; set; }
        public ICollection<Accounts> Accounts { get; set; }
        public ICollection<Incomes> Incomes { get; set; }
    }
}
