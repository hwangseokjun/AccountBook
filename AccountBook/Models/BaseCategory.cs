using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public abstract class BaseCategory
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }

        public BaseCategory(CommonCode commonCode)
        {
            Id = commonCode.Id;
            IsDeleted = Convert.ToBoolean(commonCode.IsDeleted);
            Name = commonCode.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
