using AccountBook.DataAccess;
using AccountBook.Dtos;
using AccountBook.Models;
using AccountBook.Utils;
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
            _accountView.SearchAccount += SearchAccounts;
        }

        public void Initialize()
        {
            var currentDate = DateTime.Now;
            DateTime lastMonth = currentDate.AddMonths(-1);
            string lastMonth19th = new DateTime(lastMonth.Year, lastMonth.Month, 19).ToString("yyyy-MM-dd");
            string currentMonth20th = new DateTime(currentDate.Year, currentDate.Month, 20).ToString("yyyy-MM-dd");
            var accountEntities = _accountRepository.GetBetweenDate(lastMonth19th, currentMonth20th);
            var commonCodes = _commonCodeRepository.GetAll();
            var incomeCategories = commonCodes.GetByCategoryType(CategoryType.Income).ToCategories<IncomeCategory>();
            var expenseCategories = commonCodes.GetByCategoryType(CategoryType.Expense).ToCategories<ExpenseCategory>();
            var expenseTypes = commonCodes.GetByCategoryType(CategoryType.ExpenseType).ToCategories<ExpenseType>();
            var stores = commonCodes.GetByCategoryType(CategoryType.Store).ToCategories<Store>();
            
            _accountView.ExpenseCategories = expenseCategories;
            _accountView.ExpenseTypes = expenseTypes;
            _accountView.IncomeCategories = incomeCategories;
            _accountView.Stores = stores;
            var accounts = ToAccount(accountEntities);
            _accountView.Accounts = accounts;
            _accountView.StartDate = lastMonth19th;
            _accountView.EndDate = currentMonth20th;
            CalculateRemains();
        }

        public void AddAccount(Account account) 
        {
            var expenseCategories = _accountView.ExpenseCategories;
            var incomeCategories = _accountView.IncomeCategories;
            var expenseTypes = _accountView.ExpenseTypes;
            var stores = _accountView.Stores;

            int? storeId = stores.FirstOrDefault(x => x.Name == account.Store)?.Id;
            int? expenseCategoryId = expenseCategories.FirstOrDefault(x => x.Name == account.ExpenseCategory)?.Id;
            int? incomeCategoryId = incomeCategories.FirstOrDefault(x => x.Name == account.IncomeCategory)?.Id;
            int? expenseTypeId = expenseTypes.FirstOrDefault(x => x.Name == account.ExpenseType)?.Id;

            int id = _accountRepository.Insert(new AccountEntity 
            { 
                Date = account.Date.ToString("yyyy-MM-dd"),
                StoreId = storeId,
                ExpenseCategoryId = expenseCategoryId,
                IncomeCategoryId = incomeCategoryId,
                ExpenseTypeId = expenseTypeId,
                Description = account.Description,
                IncomeAmount = account.IncomeAmount,
                ExpenseAmount = account.ExpenseAmount
            });
            var accounts = _accountView.Accounts;
            account.Id = id;
            accounts.Add(account);
            _accountView.Accounts = accounts;
            CalculateRemains();
        }

        public void ModifyAccount(Account account) 
        {
            int id = account.Id;
            var expenseCategories = _accountView.ExpenseCategories;
            var incomeCategories = _accountView.IncomeCategories;
            var expenseTypes = _accountView.ExpenseTypes;
            var stores = _accountView.Stores;
            int? storeId = stores.FirstOrDefault(x => x.Name == account.Store)?.Id;
            int? expenseCategoryId = expenseCategories.FirstOrDefault(x => x.Name == account.ExpenseCategory)?.Id;
            int? incomeCategoryId = incomeCategories.FirstOrDefault(x => x.Name == account.IncomeCategory)?.Id;
            int? expenseTypeId = expenseTypes.FirstOrDefault(x => x.Name == account.ExpenseType)?.Id;
            AccountEntity accountEntity = _accountRepository.GetById(id);
            accountEntity.Date = account.Date.ToString("yyyy-MM-dd");
            accountEntity.StoreId = storeId;
            accountEntity.ExpenseCategoryId = expenseCategoryId;
            accountEntity.IncomeCategoryId = incomeCategoryId;
            accountEntity.ExpenseTypeId = expenseTypeId;
            accountEntity.Description = account.Description;
            accountEntity.IncomeAmount = account.IncomeAmount;
            accountEntity.ExpenseAmount = account.ExpenseAmount;
            _accountRepository.Update(accountEntity);
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
            int id;

            if (category is ExpenseCategory expenseCategory)
            {
                var commonCode = new CommonCode 
                { 
                    Type = 1,
                    Name = expenseCategory.Name,
                    Amount = expenseCategory.Amount
                };
                id = _commonCodeRepository.Insert(commonCode);
                var expenseCategories = _accountView.ExpenseCategories;
                expenseCategory.Id = id;
                expenseCategories.Add(expenseCategory);
                _accountView.ExpenseCategories = expenseCategories;
            }
            else if (category is ExpenseType expenseType)
            {
                var commonCode = new CommonCode
                {
                    Type = 2,
                    Name = expenseType.Name
                };
                id = _commonCodeRepository.Insert(commonCode);
                var expenseTypes = _accountView.ExpenseTypes;
                expenseType.Id = id;
                expenseTypes.Add(expenseType);
                _accountView.ExpenseTypes = expenseTypes;
            }
            else if (category is IncomeCategory incomeCategory) 
            {
                var commonCode = new CommonCode
                {
                    Type = 0,
                    Name = incomeCategory.Name
                };
                id = _commonCodeRepository.Insert(commonCode);
                var incomeCategories = _accountView.IncomeCategories;
                incomeCategory.Id = id;
                incomeCategories.Add(incomeCategory);
                _accountView.IncomeCategories = incomeCategories;
            }
            else if (category is Store store) 
            {
                var commonCode = new CommonCode
                {
                    Type = 3,
                    Name = store.Name
                };
                id = _commonCodeRepository.Insert(commonCode);
                var stores = _accountView.Stores;
                store.Id = id;
                stores.Add(store);
                _accountView.Stores = stores;
            }
        }

        public void ModifyCategory<T>(T category) where T : BaseCategory
        {
            int id = category.Id;
            CommonCode commonCode = _commonCodeRepository.GetById(id);
            commonCode.Update(category);
            _commonCodeRepository.Update(commonCode);
        }

        public void DeleteCategory(int id) 
        {
            CommonCode commonCode = _commonCodeRepository.GetById(id);
            commonCode.IsDeleted = 1;
            _commonCodeRepository.Update(commonCode);
        }

        private void SearchAccounts(SearchKeyword searchKeyword)
        {
            string start = searchKeyword.Start.ToString("yyyy-MM-dd");
            string end = searchKeyword.End.ToString("yyyy-MM-dd");
            var accounts = _accountRepository.GetBetweenDate(start, end);
            _accountView.Accounts = ToAccount(accounts);
            _accountView.StartDate = $"시작일: {start}";
            _accountView.EndDate = $"종료일: {end}";
        }

        private List<Account> ToAccount(IEnumerable<AccountEntity> accountEntities) 
        {
            var accounts = new List<Account>();
            var expenseCategories = _accountView.ExpenseCategories;
            var expenseTypes = _accountView.ExpenseTypes;
            var incomeCategories = _accountView.IncomeCategories;
            var stores = _accountView.Stores;

            foreach (var entity in accountEntities)
            {
                accounts.Add(new Account
                {
                    Id = entity.Id,
                    Date = DateTime.Parse(entity.Date),
                    Store = stores.FirstOrDefaultDeepCopy(x => x.Id == entity.StoreId)?.Name,
                    ExpenseCategory = expenseCategories.FirstOrDefaultDeepCopy(x => x.Id == entity.ExpenseCategoryId)?.Name,
                    ExpenseType = expenseTypes.FirstOrDefaultDeepCopy(x => x.Id == entity.ExpenseTypeId)?.Name,
                    IncomeCategory = incomeCategories.FirstOrDefaultDeepCopy(x => x.Id == entity.IncomeCategoryId)?.Name,
                    Description = entity.Description,
                    IncomeAmount = entity.IncomeAmount ?? 0,
                    ExpenseAmount = entity.ExpenseAmount ?? 0
                });
            }

            return accounts;
        }

        private void CalculateRemains() 
        {
            int totalIncome = GetTotalIncome();
            int totalExpense = GetTotalExpense();
            int totalRemains = totalIncome - totalExpense;

            _accountView.TotalIncome = $"총수입: {totalIncome:n0}원";
            _accountView.TotalExpense = $"총지출: {totalExpense:n0}원";
            _accountView.TotalRemain = $"합계: {totalRemains:n0}원";
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
