using AccountBook.DataAccess;
using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Views
{
    public interface IAccountView
    {
        event Action<Account> SaveAccount;
        event Action<int> RemoveAccount;
        event Action<Account> UpdateAccount;

        event Action<BaseCategory> SaveCategory;
        event Action<int> RemoveCategory;
        event Action<BaseCategory> UpdateCategory;

        List<Account> Accounts { get; set; }
        List<ExpenseCategory> ExpenseCategories { get; set; }
        List<IncomeCategory> IncomeCategories { get; set; }
        List<ExpenseType> ExpenseTypes { get; set; }
        List<Store> Stores { get; set; }
        string TotalIncome { set; }
        string TotalExpense { set; }
        string TotalRemain { set; }
    }
}
