using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public class FinancialAccount
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int StoreId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int IncomeCategoryId { get; set; }
        public int ExpenseTypeId { get; set; }
        public string Description { get; set; }
        public int IncomeAmount { get; set; }
        public int ExpenseAmount { get; set; }

        public FinancialAccount()
        {

        }

        public FinancialAccount(Account account)
        {
            Date = account.Date.ToString("yyyy-MM-dd");
            StoreId = account.Store.Id;
            ExpenseCategoryId = account.ExpenseCategory.Id;
            IncomeCategoryId = account.IncomeCategory.Id;
            ExpenseTypeId = account.ExpenseType.Id;
            Description = account.Description;
            IncomeAmount = account.IncomeAmount;
            ExpenseAmount = account.ExpenseAmount;
        }

        public void Update(Account account) 
        {
            Date = account.Date.ToString("yyyy-MM-dd");
            StoreId = account.Store.Id;
            ExpenseCategoryId = account.ExpenseCategory.Id;
            IncomeCategoryId = account.IncomeCategory.Id;
            ExpenseTypeId = account.ExpenseType.Id;
            Description = account.Description;
            IncomeAmount = account.IncomeAmount;
            ExpenseAmount = account.ExpenseAmount;
        }
    }
}
