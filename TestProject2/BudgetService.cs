using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class BudgetService
    {
        IBudgetRepo _budget;
        public BudgetService(IBudgetRepo budgetRepo)
        {
            _budget = budgetRepo;


        }

        public decimal Query(DateTime start, DateTime end)
        {
            var reuslt = _budget.GetAll();

            return 0;
        }
    }
}
