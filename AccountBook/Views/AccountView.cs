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
                dgv_account.DataSource = _accounts;
            } 
        }
        public List<ExpenseCategory> ExpenseCategories 
        { 
            get => _expenseCategories;
            set => throw new NotImplementedException();
        }
        public List<IncomeCategory> IncomeCategories 
        { 
            get => _incomeCategories; 
            set => throw new NotImplementedException(); 
        }
        public List<ExpenseType> ExpenseTypes 
        { 
            get => _expenseTypes; 
            set => throw new NotImplementedException(); 
        }
        public List<Store> Stores 
        { 
            get => _stores;
            set => throw new NotImplementedException(); 
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

        public AccountView()
        {
            InitializeComponent();
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

        private void cbx_income_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_expense_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_account_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
