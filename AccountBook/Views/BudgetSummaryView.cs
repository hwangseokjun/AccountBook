using AccountBook.Dtos;
using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook.Views
{
    public partial class BudgetSummaryView : Form, IBudgetSummaryView
    {
        public event Action<SearchKeyword> SearchBudgetSummaries;

        public List<BudgetSummary> _budgetSummaries;
        private List<ExpenseCategory> _expenseCategories;

        public List<BudgetSummary> BudgetSummaries 
        { 
            get => _budgetSummaries;
            set 
            {
                _budgetSummaries = value;
                dgv_budgetSummary.DataSource = null;
                dgv_budgetSummary.DataSource = _budgetSummaries;
            }
        }
        public List<ExpenseCategory> ExpenseCategories
        {
            get => _expenseCategories;
            set 
            {
                _expenseCategories = value;
                dgv_expenseCategory.DataSource = null;
                dgv_expenseCategory.DataSource = _expenseCategories;
            }
        }
        public string StartDate 
        {
            set => lbl_start.Text = value; 
        }
        public string EndDate 
        {
            set => lbl_end.Text = value; 
        }

        public BudgetSummaryView()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime start = dtp_from.Value;
            DateTime end = dtp_to.Value;

            var keyword = new SearchKeyword
            {
                Start = start,
                End = end
            };

            SearchBudgetSummaries?.Invoke(keyword);
        }

        private void dgv_budgetSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if ((int)e.Value < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else 
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
    }
}
