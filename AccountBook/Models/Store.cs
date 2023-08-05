using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class Store : BaseCategory
    {
        [Browsable(false)]
        public new int? Amount { get; set; }

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
