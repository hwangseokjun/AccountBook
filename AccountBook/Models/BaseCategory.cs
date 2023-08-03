using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public abstract class BaseCategory
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public bool IsDeleted { get; set; }
        [DisplayName("카테고리명")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public abstract object Clone();
    }
}
