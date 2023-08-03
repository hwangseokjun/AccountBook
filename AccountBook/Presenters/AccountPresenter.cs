using AccountBook.DataAccess;
using AccountBook.Models;
using AccountBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Presenters
{
    public class AccountPresenter
    {
        private readonly IAccountView _accountView;
        private readonly IAccountRepository _accountRepository;
        private readonly ICommonCodeRepository _commonCodeRepository;

        public AccountPresenter(IAccountView accountView, IAccountRepository accountRepository, ICommonCodeRepository commonCodeRepository)
        {
            _accountView = accountView;
            _accountRepository = accountRepository;
            _commonCodeRepository = commonCodeRepository;
            _accountView.SaveAccount += AddAccount;
            _accountView.UpdateAccount += ModifyAccount;
            _accountView.RemoveAccount += DeleteAccount;
            _accountView.SaveCategory += AddCategory;
            _accountView.UpdateCategory += ModifyCategory;
            _accountView.RemoveCategory += DeleteCategory;
        }

        public void Initialize() 
        {
            DateTime currentDate = DateTime.Now;
            string lastMonth19th = currentDate.AddMonths(-1).AddDays(18).ToString("yyyy-MM-dd");
            string currentMonth20th = currentDate.AddDays(19).ToString("yyyy-MM-dd");
            var accountEntities = _accountRepository.GetBetweenDate(lastMonth19th, currentMonth20th);
            var commonCodes = _commonCodeRepository.GetAll();
            var accounts = new List<Account>();

            foreach (var entity in accountEntities) 
            {
                accounts.Add(new Account
                {
                    Id = entity.Id,
                    Date = DateTime.Parse(entity.Date),

                    Description = entity.Description,
                    IncomeAmount = entity.IncomeAmount,
                    ExpenseAmount = entity.ExpenseAmount
                });
            }

            _accountView.Accounts = accounts;
        }

        public void AddAccount(Account account) 
        {
            int id = _accountRepository.Insert(new FinancialAccount(account));
            var accounts = _accountView.Accounts;
            account.Id = id;
            accounts.Add(account);
            _accountView.Accounts = accounts;
            CalculateRemains();
        }

        public void ModifyAccount(Account account) 
        {
            int id = account.Id;
            FinancialAccount financialAccount = _accountRepository.GetById(id);
            financialAccount.Update(account);
            _accountRepository.Update(financialAccount);
            CalculateRemains();
        }

        public void DeleteAccount(int id) 
        {
            _accountRepository.DeleteById(id);
            var accounts = _accountView.Accounts;
            var account = accounts.Find(x => x.Id == id);
            accounts.Remove(account);
            _accountView.Accounts = accounts;
            CalculateRemains();
        }

        public void AddCategory<T>(T category) where T : BaseCategory 
        {
            if (category is ExpenseCategory expenseCategory)
            {

            }
            else if (category is ExpenseType expenseType)
            {

            }
            else if (category is IncomeCategory incomeCategory) 
            { 
            
            }
            else if (category is Store store) 
            { 
            
            }
        }

        public void ModifyCategory<T>(T category) where T : BaseCategory
        {

        }

        public void DeleteCategory(int id) 
        { 
        
        }

        private void CalculateRemains() 
        {
            int totalIncome = GetTotalIncome();
            int totalExpense = GetTotalExpense();
            int totalRemains = totalIncome - totalExpense;

            _accountView.TotalIncome = $"{totalIncome:NO}원";
            _accountView.TotalExpense = $"{totalExpense:NO}원";
            _accountView.TotalRemain = $"{totalRemains:NO}원";
        }

        private int GetTotalIncome() 
        {
            int income = 0;
            var accounts = _accountView.Accounts;
            accounts.ForEach(x => income += x.IncomeAmount);

            return income;
        }

        private int GetTotalExpense() 
        {
            int expense = 0;
            var accounts = _accountView.Accounts;
            accounts.ForEach(x => expense += x.ExpenseAmount);

            return expense;
        }
    }
}
