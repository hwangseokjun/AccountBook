using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public class CommonCode
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int IsDeleted { get; set; }
    }
}
