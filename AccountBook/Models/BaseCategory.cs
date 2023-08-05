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

        [DisplayName(" ")]
        public bool IsSelected { get; set; } = false;

        [ReadOnly(true)]
        [DisplayName("카테고리명")]
        public string Name { get; set; }

        [DisplayName("한도금액")]
        public int? Amount { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public abstract object Clone();
    }
}
