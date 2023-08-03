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
    public partial class AccountView : Form, IAccountView
    {
        public event Action<Account> SaveAccount;
        public event Action<int> RemoveAccount;
        public event Action<Account> UpdateAccount;
        public event Action<BaseCategory> SaveCategory;
        public event Action<int> RemoveCategory;
        public event Action<BaseCategory> UpdateCategory;

        private List<Account> _accounts;
        private List<ExpenseCategory> _expenseCategories;
        private List<IncomeCategory> _incomeCategories;
        private List<ExpenseType> _expenseTypes;
        private List<Store> _stores;

        public List<Account> Accounts 
        {
            get => _accounts;
            set 
            {
                _accounts = value;
                dgv_account.DataSource = null;
                dgv_account.DataSource = _accounts.FindAll(x => x.Visible);
            } 
        }
        public List<ExpenseCategory> ExpenseCategories 
        { 
            get => _expenseCategories;
            set 
            {
                _expenseCategories = value;
                dgv_expenseCategory.DataSource = null;
                var showing = _expenseCategories.FindAll(x => x.IsDeleted == false);
                dgv_expenseCategory.DataSource = showing;
                cbx_expenseCategory.DataSource = showing;
                cbx_expenseCategory.DisplayMember = "Name";
            }
        }
        public List<IncomeCategory> IncomeCategories 
        { 
            get => _incomeCategories;
            set
            {
                _incomeCategories = value;
                dgv_incomeCategory.DataSource = null;
                var showing = _incomeCategories.FindAll(x => x.IsDeleted == false);
                dgv_incomeCategory.DataSource = showing;
                cbx_incomeCategory.DataSource = showing;
                cbx_incomeCategory.DisplayMember = "Name";
            }
        }
        public List<ExpenseType> ExpenseTypes 
        { 
            get => _expenseTypes;
            set
            {
                _expenseTypes = value;
                dgv_expenseType.DataSource = null;
                var showing = _expenseTypes.FindAll(x => x.IsDeleted == false);
                dgv_expenseType.DataSource = showing;
                cbx_expenseType.DataSource = showing;
                cbx_expenseType.DisplayMember = "Name";
            }
        }
        public List<Store> Stores 
        { 
            get => _stores;
            set
            {
                _stores = value;
                dgv_store.DataSource = null;
                var showing = _stores.FindAll(x => x.IsDeleted == false);
                dgv_store.DataSource = showing;
                cbx_store.DataSource = showing;
                cbx_store.DisplayMember = "Name";
            }
        }
        public string TotalIncome 
        { 
            set => lbl_totalIncome.Text = value; 
        }
        public string TotalExpense 
        {
            set => lbl_totalExpense.Text = value; 
        }
        public string TotalRemain 
        {
            set => lbl_totalRemain.Text = value; 
        }
        public string StartDate 
        {
            set => lbl_startDate.Text = $"시작일: {value}"; 
        }
        public string EndDate 
        {
            set => lbl_endDate.Text = $"종료일: {value}";
        }

        public AccountView()
        {
            InitializeComponent();
            cbx_saveCategory.SelectedIndex = 0;
        }

        private void btn_saveExpenseAccount_Click(object sender, EventArgs e)
        {
            SaveAccount?.Invoke(null);
        }

        private void btn_saveIncomeAccount_Click(object sender, EventArgs e)
        {
            SaveAccount?.Invoke(null);
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            Accounts.ToList().ForEach(x => 
            {
                if (x.IsSelected) 
                {
                    RemoveAccount?.Invoke(x.Id);
                }
            });
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void dgv_account_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void chk_expense_CheckedChanged(object sender, EventArgs e)
        {
            bool showExpense = chk_expense.Checked;
            Accounts.ForEach(x => 
            {
                if (0 < x.ExpenseAmount) 
                {
                    x.Visible = showExpense;
                }
            });
            Accounts = Accounts;
        }

        private void chk_income_CheckedChanged(object sender, EventArgs e)
        {
            bool showIncome = chk_income.Checked;
            Accounts.ForEach(x =>
            {
                if (0 < x.IncomeAmount)
                {
                    x.Visible = showIncome;
                }
            });
            Accounts = Accounts;
        }

        private void btn_saveCategory_Click(object sender, EventArgs e)
        {
            string text = cbx_saveCategory.SelectedItem.ToString();
            string name = txt_saveCategory.Text;

            if (string.IsNullOrWhiteSpace(name)) 
            {
                MessageBox.Show("카테고리명 입력 필요");

                return;
            }

            switch (text) 
            {
                case "지출항목":
                    SaveCategory.Invoke(new ExpenseCategory { Name = name });
                    break;

                case "수입항목":
                    SaveCategory.Invoke(new IncomeCategory { Name = name });
                    break;

                case "지출종류":
                    SaveCategory.Invoke(new ExpenseType { Name = name });
                    break;

                case "구매처":
                    SaveCategory.Invoke(new Store { Name = name });
                    break;

                default:
                    throw new NotSupportedException("");
            }
        }
    }
}
