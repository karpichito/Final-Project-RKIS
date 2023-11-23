using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class Expenses
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Value { get; set; }
        public Users Users { get; set; }
        public override string ToString()
        {
            return $"{Category}, {Value}";
        }
    }
}
