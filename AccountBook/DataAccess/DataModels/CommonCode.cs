using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    [Table("common_code")]
    public class CommonCode
    {
        public int Id { get; set; }
        public int? Sequence { get; set; }
        /// <summary>
        /// <para> 0 = 수입 항목 </para>
        /// <para> 1 = 지출 항목 </para>
        /// <para> 2 = 지출 분류 </para>
        /// <para> 3 = 구매처 </para>
        /// </summary>
        public int Type { get; set; }
        public string Name { get; set; }
        public int? Amount { get; set; }
        public int IsDeleted { get; set; }
    }
}
