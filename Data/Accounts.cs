using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class Accounts
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; }
        public string AccountType { get; set; }
        public string OpeningDate { get; set; }
        public Users Users { get; set; }
        public override string ToString()
        {
            return $"{AccountType} \"{AccountName}\", баланс: {Balance} ({OpeningDate})";
        }
    }
}
