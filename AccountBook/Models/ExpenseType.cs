using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class ExpenseType : BaseCategory
    {
        public override object Clone()
        {
            return new ExpenseType
            {
                Id = this.Id,
                IsDeleted = this.IsDeleted,
                Name = this.Name
            };
        }
    }
}
