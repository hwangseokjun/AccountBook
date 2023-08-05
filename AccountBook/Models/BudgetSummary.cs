using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class BudgetSummary
    {
        [DisplayName("지출 항목")]
        public string Category { get; set; }
        [DisplayName("예산")]
        public int Budget { get; set; }
        [DisplayName("실제 지출")]
        public int Expense { get; set; }
        [DisplayName("남은 예산")]
        public int Remaining { get; set; }
    }
}
