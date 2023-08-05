using AccountBook.Dtos;
using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Views
{
    public interface IBudgetSummaryView
    {
        event Action<SearchKeyword> SearchBudgetSummaries;

        List<BudgetSummary> BudgetSummaries { get; set; }
        List<ExpenseCategory> ExpenseCategories { get; set; }
        string StartDate { set; }
        string EndDate { set; } 
    }
}
