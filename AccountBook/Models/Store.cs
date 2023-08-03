using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class Store : BaseCategory
    {
        public override object Clone()
        {
            return new Store
            {
                Id = this.Id,
                IsDeleted = this.IsDeleted,
                Name = this.Name
            };
        }
    }
}
