using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class ExpenseCategory : BaseCategory
    {
        public override object Clone() 
        {
            return new ExpenseCategory
            {
                Id = this.Id,
                IsDeleted = this.IsDeleted,
                Name = this.Name,
                Amount = this.Amount
            };
        }
    }
}
