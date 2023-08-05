using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Models
{
    public class Account
    {
        [Browsable(false)]
        public int Id { get; set; }
        
        [DisplayName(" ")]
        public bool IsSelected { get; set; } = false;
        
        [Browsable(false)]
        public bool Visible { get; set; } = true;
        
        [DisplayName("날짜")]
        public DateTime Date { get; set; }

        [DisplayName("구매처")]
        public string Store { get; set; }

        [DisplayName("수입 항목")]
        public string IncomeCategory { get; set; }

        [DisplayName("지출 항목")]
        public string ExpenseCategory { get; set; }

        [DisplayName("지출 분류")]
        public string ExpenseType { get; set; }

        [DisplayName("설명")]
        public string Description { get; set; }
        
        [DisplayName("수입금액")]
        public int IncomeAmount { get; set; }
        
        [DisplayName("지출금액")]
        public int ExpenseAmount { get; set; }
    }
}
