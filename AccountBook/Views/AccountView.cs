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
        private bool _toggleDate = false;
        private bool _toggleIncomeAmount = false;
        private bool _toggleExpenseAmount = false;
        private bool _toggleStore;
        private bool _toggleIncomeCategory;
        private bool _toggleExpenseCategory;
        private bool _toggleExpenseType;
        private bool _toggleDescription;

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
                _expenseCategories = value.OrderBy(x => x.Sequence).ToList();
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
                _incomeCategories = value.OrderBy(x => x.Sequence).ToList(); ;
                dgv_incomeCategory.DataSource = null;
                var showing = chk_showDeletedCategory.Checked ? _incomeCategories : _incomeCategories.FindAll(x => x.IsDeleted == false);
                showing = showing.OrderBy(x => x.Sequence).ToList();
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
                _expenseTypes = value.OrderBy(x => x.Sequence).ToList(); ;
                dgv_expenseType.DataSource = null;
                var showing = chk_showDeletedCategory.Checked ? _expenseTypes : _expenseTypes.FindAll(x => x.IsDeleted == false);
                showing = showing.OrderBy(x => x.Sequence).ToList();
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
                _stores = value.OrderBy(x => x.Sequence).ToList(); ;
                dgv_store.DataSource = null;
                var showing = chk_showDeletedCategory.Checked ? _stores : _stores.FindAll(x => x.IsDeleted == false);
                showing = showing.OrderBy(x => x.Sequence).ToList();
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
                Store = ((Store)cbx_store.SelectedItem).Name,
                ExpenseCategory = ((ExpenseCategory)cbx_expenseCategory.SelectedItem).Name,
                ExpenseType = ((ExpenseType)cbx_expenseType.SelectedItem).Name,
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
                IncomeCategory = ((IncomeCategory)cbx_incomeCategory.SelectedItem).Name,
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
                    bool success = int.TryParse(txt_saveExpenseCategoryAmount.Text, out int amount);
                    if (!success) 
                    {
                        amount = 0;
                    }
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

            if (string.IsNullOrEmpty(input)) 
            {
                txt_saveExpenseCategoryAmount.Text = "0";
            }

            if (!char.IsControl(key) && !char.IsDigit(key))
            {
                e.Handled = true;
            }
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

            if (e.ColumnIndex == 1)
            {
                if (e.Value is DateTime date)
                {
                    e.Value = date.ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == 7 && 0 < (int)e.Value)
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

            string name = (string)e.FormattedValue;
            bool exists;

            if (string.IsNullOrEmpty(name)) 
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                exists = Stores.Exists(x => x.Name == name);

                if (!exists) 
                {
                    MessageBox.Show("등록되지 않은 구매처입니다.");
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 3) 
            {
                exists = IncomeCategories.Exists(x => x.Name == name);

                if (!exists)
                {
                    MessageBox.Show("등록되지 않은 수입 항목입니다.");
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 4)
            {
                exists = ExpenseCategories.Exists(x => x.Name == name);
                
                if (!exists)
                {
                    MessageBox.Show("등록되지 않은 지출 항목입니다.");
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                exists = ExpenseTypes.Exists(x => x.Name == name);

                if (!exists)
                {
                    MessageBox.Show("등록되지 않은 지출 분류입니다.");
                    e.Cancel = true;
                }
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

        private void btn_expenseCategoryUp_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_expenseCategory.SelectedCells[0].RowIndex;
            int sequence = 0;
            ExpenseCategories.ForEach(x => x.Sequence = sequence++);
            ExpenseCategories.SwapSequence(rowHandle, true);
            ExpenseCategories.ForEach(x => UpdateCategory(x));
            ExpenseCategories = ExpenseCategories;
        }

        private void btn_expenseCategoryDown_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_expenseCategory.SelectedCells[0].RowIndex;
            int sequence = 0;
            ExpenseCategories.ForEach(x => x.Sequence = sequence++);
            ExpenseCategories.SwapSequence(rowHandle, false);
            ExpenseCategories.ForEach(x => UpdateCategory(x));
            ExpenseCategories = ExpenseCategories;
        }

        private void btn_incomeCategoryUp_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_incomeCategory.SelectedCells[0].RowIndex;
            int sequence = 0;
            IncomeCategories.ForEach(x => x.Sequence = sequence++);
            IncomeCategories.SwapSequence(rowHandle, true);
            IncomeCategories.ForEach(x => UpdateCategory(x));
            IncomeCategories = IncomeCategories;
        }

        private void btn_incomeCategoryDown_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_incomeCategory.SelectedCells[0].RowIndex;
            int sequence = 0;
            IncomeCategories.ForEach(x => x.Sequence = sequence++);
            IncomeCategories.SwapSequence(rowHandle, false);
            IncomeCategories.ForEach(x => UpdateCategory(x));
            IncomeCategories = IncomeCategories;
        }

        private void btn_expenseTypeUp_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_expenseType.SelectedCells[0].RowIndex;
            int sequence = 0;
            ExpenseTypes.ForEach(x => x.Sequence = sequence++);
            ExpenseTypes.SwapSequence(rowHandle, true);
            ExpenseTypes.ForEach(x => UpdateCategory(x));
            ExpenseTypes = ExpenseTypes;
        }

        private void btn_expenseTypeDown_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_expenseType.SelectedCells[0].RowIndex;
            int sequence = 0;
            ExpenseTypes.ForEach(x => x.Sequence = sequence++);
            ExpenseTypes.SwapSequence(rowHandle, false);
            ExpenseTypes.ForEach(x => UpdateCategory(x));
            ExpenseTypes = ExpenseTypes;
        }

        private void btn_storeUp_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_store.SelectedCells[0].RowIndex;
            int sequence = 0;
            Stores.ForEach(x => x.Sequence = sequence++);
            Stores.SwapSequence(rowHandle, true);
            Stores.ForEach(x => UpdateCategory(x));
            Stores = Stores;
        }

        private void btn_storeDown_Click(object sender, EventArgs e)
        {
            int rowHandle = dgv_store.SelectedCells[0].RowIndex;
            int sequence = 0;
            Stores.ForEach(x => x.Sequence = sequence++);
            Stores.SwapSequence(rowHandle, false);
            Stores.ForEach(x => UpdateCategory(x));
            Stores = Stores;
        }

        private void dgv_account_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                _toggleDate ^= true;
                Accounts = _toggleDate ? Accounts.OrderByDescending(x => x.Date).ToList() : Accounts.OrderBy(x => x.Date).ToList();
            }
            else if (e.ColumnIndex == 2)
            {
                _toggleStore ^= true;
                Accounts = _toggleStore ? Accounts.OrderByDescending(x => x.Store).ToList() : Accounts.OrderBy(x => x.Store).ToList();
            }
            else if (e.ColumnIndex == 3)
            {
                _toggleIncomeCategory ^= true;
                Accounts = _toggleIncomeCategory ? Accounts.OrderByDescending(x => x.IncomeCategory).ToList() : Accounts.OrderBy(x => x.IncomeCategory).ToList();
            }
            else if (e.ColumnIndex == 4)
            {
                _toggleExpenseCategory ^= true;
                Accounts = _toggleExpenseCategory ? Accounts.OrderByDescending(x => x.ExpenseCategory).ToList() : Accounts.OrderBy(x => x.ExpenseCategory).ToList();
            }
            else if (e.ColumnIndex == 5)
            {
                _toggleExpenseType ^= true;
                Accounts = _toggleExpenseType ? Accounts.OrderByDescending(x => x.ExpenseType).ToList() : Accounts.OrderBy(x => x.ExpenseType).ToList();
            }
            else if (e.ColumnIndex == 6)
            {
                _toggleDescription ^= true;
                Accounts = _toggleDescription ? Accounts.OrderByDescending(x => x.Description).ToList() : Accounts.OrderBy(x => x.Description).ToList();
            }
            else if (e.ColumnIndex == 7)
            {
                _toggleIncomeAmount ^= true;
                Accounts = _toggleIncomeAmount ? Accounts.OrderByDescending(x => x.IncomeAmount).ToList() : Accounts.OrderBy(x => x.IncomeAmount).ToList();
            }
            else if (e.ColumnIndex == 8)
            {
                _toggleExpenseAmount ^= true;
                Accounts = _toggleExpenseAmount ? Accounts.OrderByDescending(x => x.ExpenseAmount).ToList() : Accounts.OrderBy(x => x.ExpenseAmount).ToList();
            }
        }
    }
}
