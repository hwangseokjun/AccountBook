using AccountBook.Dtos;
using AccountBook.Models;
using AccountBook.Presenters;
using AccountBook.Utils;
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
        public event Action<SearchKeyword> SearchAccount;

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
                var showing = chk_showDeletedCategory.Checked ? _expenseCategories : _expenseCategories.FindAll(x => x.IsDeleted == false);
                dgv_expenseCategory.DataSource = showing;
                cbx_expenseCategory.DataSource = null;
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
                var showing = chk_showDeletedCategory.Checked ? _incomeCategories : _incomeCategories.FindAll(x => x.IsDeleted == false);
                dgv_incomeCategory.DataSource = showing;
                cbx_incomeCategory.DataSource = null;
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
                var showing = chk_showDeletedCategory.Checked ? _expenseTypes : _expenseTypes.FindAll(x => x.IsDeleted == false);
                dgv_expenseType.DataSource = showing;
                cbx_expenseType.DataSource = null;
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
                var showing = chk_showDeletedCategory.Checked ? _stores : _stores.FindAll(x => x.IsDeleted == false);
                dgv_store.DataSource = showing;
                cbx_store.DataSource = null;
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
            var account = new Account 
            { 
                Date = dtp_saveExpense.Value,
                Store = (Store)((Store)cbx_store.SelectedItem).Clone(),
                ExpenseCategory = (ExpenseCategory)((ExpenseCategory)cbx_expenseCategory.SelectedItem).Clone(),
                ExpenseType = (ExpenseType)((ExpenseType)cbx_expenseType.SelectedItem).Clone(),
                ExpenseAmount = int.Parse(txt_expenseAmount.Text),
                Description = txt_expenseDescription.Text
            };
            SaveAccount?.Invoke(account);
        }

        private void btn_saveIncomeAccount_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                Date = dtp_saveIncome.Value,
                IncomeCategory = (IncomeCategory)((IncomeCategory)cbx_incomeCategory.SelectedItem).Clone(),
                IncomeAmount = int.Parse(txt_incomeAmount.Text),
                Description = txt_incomeDescription.Text
            };
            SaveAccount?.Invoke(account);
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
            DateTime start = dtp_from.Value;
            DateTime end = dtp_to.Value;

            var keyword = new SearchKeyword 
            { 
                Start = start,
                End = end
            };

            SearchAccount.Invoke(keyword);
        }

        private void dgv_account_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (0 <= e.RowIndex && 0 <= e.ColumnIndex) 
            //{
                
            //}
            DataGridViewRow changedRow = dgv_account.Rows[e.RowIndex];
            var account = (Account)changedRow.DataBoundItem;
            UpdateAccount?.Invoke(account);
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
            string name = txt_saveCategoryText.Text;
            
            if (string.IsNullOrWhiteSpace(name)) 
            {
                MessageBox.Show("카테고리명 입력 필요");

                return;
            }

            switch (text) 
            {
                case "지출항목":
                    int amount = int.Parse(txt_saveExpenseCategoryAmount.Text);
                    SaveCategory.Invoke(new ExpenseCategory { Name = name, Amount = amount });
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

        private void txt_expenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            string input = textBox.Text;
            char key = e.KeyChar;
            bool isNumeric = IsNumeric(input, key);
            e.Handled = !isNumeric;
        }

        private void txt_incomeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            string input = textBox.Text;
            char key = e.KeyChar;
            bool isNumeric = IsNumeric(input, key);
            e.Handled = !isNumeric;
        }

        private void cbx_saveCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_saveCategory.SelectedIndex == 0)
            {
                txt_saveExpenseCategoryAmount.Enabled = true;
            }
            else 
            {
                txt_saveExpenseCategoryAmount.Enabled = false;
            }
        }

        private void txt_saveExpenseCategoryAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            string input = textBox.Text;
            char key = e.KeyChar;
            bool isNumeric = IsNumeric(input, key);
            e.Handled = !isNumeric;
        }

        private bool IsNumeric(string input, char key) 
        {
            if (string.IsNullOrEmpty(input) && key == '0')
            {
                return false;
            }

            if (!char.IsControl(key) && !char.IsDigit(key))
            {
                return false;
            }

            return true;
        }

        private void btn_budget_Click(object sender, EventArgs e)
        {
            using (var budetSummaryModel = new BudgetSummaryView()) 
            {
                var accountRepository = Singleton.Instance.AccountRepository;
                var commonCodeRepository = Singleton.Instance.CommonCodeRepository;
                var accountPresenter = new BudgetSummaryPresenter(budetSummaryModel, accountRepository, commonCodeRepository);
                accountPresenter.Initialize();
                budetSummaryModel.ShowDialog();
            }
        }

        private void dgv_account_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null) 
            {
                return;
            }

            if (e.ColumnIndex == 7 && 0 < (int)e.Value)
            {
                e.CellStyle.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 8 && 0 < (int)e.Value) 
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void dgv_expenseCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow changedRow = dgv_expenseCategory.Rows[e.RowIndex];
            var expenseCategory = (ExpenseCategory)changedRow.DataBoundItem;
            UpdateCategory?.Invoke(expenseCategory);
        }

        private void dgv_account_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!dgv_account.IsCurrentCellDirty) 
            {
                return;
            }
        }

        private void btn_deleteExpenseCategory_Click(object sender, EventArgs e)
        {
            var categories = ExpenseCategories.FindAll(x => x.IsSelected);

            foreach (var category in categories) 
            {
                RemoveCategory?.Invoke(category.Id);
                category.IsDeleted = true;
            }

            ExpenseCategories = ExpenseCategories;
        }

        private void btn_deleteIncomeCategory_Click(object sender, EventArgs e)
        {
            var categories = IncomeCategories.FindAll(x => x.IsSelected);

            foreach (var category in categories)
            {
                RemoveCategory?.Invoke(category.Id);
                category.IsDeleted = true;
            }

            IncomeCategories = IncomeCategories;
        }

        private void btn_deleteExpenseType_Click(object sender, EventArgs e)
        {
            var categories = ExpenseTypes.FindAll(x => x.IsSelected);

            foreach (var category in categories)
            {
                RemoveCategory?.Invoke(category.Id);
                category.IsDeleted = true;
            }

            ExpenseTypes = ExpenseTypes;
        }

        private void btn_deleteStore_Click(object sender, EventArgs e)
        {
            var categories = Stores.FindAll(x => x.IsSelected);

            foreach (var category in categories)
            {
                RemoveCategory?.Invoke(category.Id);
                category.IsDeleted = true;
            }

            Stores = Stores;
        }

        private void chk_showDeletedCategory_CheckedChanged(object sender, EventArgs e)
        {
            ExpenseCategories = ExpenseCategories;
            IncomeCategories = IncomeCategories;
            ExpenseTypes = ExpenseTypes;
            Stores = Stores;
        }

        private void dgv_expenseCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null)
            {
                return;
            }

            DataGridViewRow changedRow = dgv_expenseCategory.Rows[e.RowIndex];
            var expenseCategory = (ExpenseCategory)changedRow.DataBoundItem;
            if (expenseCategory.IsDeleted) 
            {
                e.CellStyle.BackColor = Color.LightSalmon;
            }
        }

        private void dgv_incomeCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null)
            {
                return;
            }

            DataGridViewRow changedRow = dgv_incomeCategory.Rows[e.RowIndex];
            var incomeCategory = (IncomeCategory)changedRow.DataBoundItem;
            if (incomeCategory.IsDeleted)
            {
                e.CellStyle.BackColor = Color.LightSalmon;
            }
        }

        private void dgv_expenseType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null)
            {
                return;
            }

            DataGridViewRow changedRow = dgv_expenseType.Rows[e.RowIndex];
            var expenseType = (ExpenseType)changedRow.DataBoundItem;
            if (expenseType.IsDeleted)
            {
                e.CellStyle.BackColor = Color.LightSalmon;
            }
        }

        private void dgv_store_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null)
            {
                return;
            }

            DataGridViewRow changedRow = dgv_store.Rows[e.RowIndex];
            var store = (Store)changedRow.DataBoundItem;
            if (store.IsDeleted)
            {
                e.CellStyle.BackColor = Color.LightSalmon;
            }
        }
    }
}
