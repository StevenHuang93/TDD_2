using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public interface IBudgetRepo
    {
        List<Budget> GetAll();
    }

    public class Budget
    {
        public string YearMonth { get; set; }
        public int Amount { get; set; }
    }
}
