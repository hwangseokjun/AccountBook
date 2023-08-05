using AccountBook.Models;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    [Table("account")]
    public class AccountEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int? StoreId { get; set; }
        public int? ExpenseCategoryId { get; set; }
        public int? IncomeCategoryId { get; set; }
        public int? ExpenseTypeId { get; set; }
        public string Description { get; set; }
        public int? IncomeAmount { get; set; }
        public int? ExpenseAmount { get; set; }

        public AccountEntity()
        {

        }

        public void Update(AccountEntity account) 
        {
            Date = account.Date;
            StoreId = account.StoreId;
            ExpenseCategoryId = account.ExpenseCategoryId;
            IncomeCategoryId = account.IncomeCategoryId;
            ExpenseTypeId = account.ExpenseTypeId;
            Description = account.Description;
            IncomeAmount = account.IncomeAmount;
            ExpenseAmount = account.ExpenseAmount;
        }
    }
}
