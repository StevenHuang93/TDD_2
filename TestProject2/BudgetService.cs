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
            var result = _budget.GetAll();

            var queryStart = start.ToString("yyyyMM");

            var queryEnd = end.ToString("yyyyyMM");



            if (start.Year == end.Year && start.Month == end.Month)
            {
                var diff = end.Date - start.Date;

                var diffStart = diff.TotalDays + 1; // 同年月跨日

                var monthsday = DateTime.DaysInMonth(start.Year, start.Month); // 當月有幾天

                var budgetResult = result.FirstOrDefault(a => a.YearMonth == queryStart);

                if (budgetResult != null)
                {
                    var reuslt = (diffStart / monthsday) * budgetResult.Amount;
                }


            }

            return 0;
        }

        
    }
}
