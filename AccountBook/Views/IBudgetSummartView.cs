using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Views
{
    public interface IBudgetSummartView
    {
        List<BudgetSummary> BudgetSummaries { get; set; }
    }
}
