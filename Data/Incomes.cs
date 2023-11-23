using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class Incomes
    {
        public int Id { get; set; }
        public string IncomeSource { get; set; }
        public int Amount { get; set; }
        public string IncomeDate { get; set; }
        public Users Users { get; set; }
        public override string ToString()
        {
            return $"{IncomeSource}, {Amount} руб. ({IncomeDate})";
        }
    }
}
