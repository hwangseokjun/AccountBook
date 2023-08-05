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
    public class BudgetSummaryPresenter
    {
        private readonly IBudgetSummaryView _budgetSummaryView;
        private readonly IAccountRepository _accountRepository;
        private readonly ICommonCodeRepository _commonCodeRepository;

        public BudgetSummaryPresenter(IBudgetSummaryView budgetSummartView, IAccountRepository accountRepository, ICommonCodeRepository commonCodeRepository)
        {
            _budgetSummaryView = budgetSummartView;
            _accountRepository = accountRepository;
            _commonCodeRepository = commonCodeRepository;
            _budgetSummaryView.SearchBudgetSummaries += SearchBudgetSummaries;
        }

        public void Initialize() 
        {
            var currentDate = DateTime.Now;
            DateTime lastMonth = currentDate.AddMonths(-1);
            string lastMonth19th = new DateTime(lastMonth.Year, lastMonth.Month, 19).ToString("yyyy-MM-dd");
            string currentMonth20th = new DateTime(currentDate.Year, currentDate.Month, 20).ToString("yyyy-MM-dd");
            var accountEntities = _accountRepository.GetBetweenDate(lastMonth19th, currentMonth20th);
            var commonCodes = _commonCodeRepository.GetAll();
            var expenseCategories = commonCodes.GetByCategoryType(CategoryType.Expense).ToCategories<ExpenseCategory>();
            _budgetSummaryView.ExpenseCategories = expenseCategories;
            _budgetSummaryView.StartDate = $"시작일: {lastMonth19th}";
            _budgetSummaryView.EndDate = $"종료일: {currentMonth20th}";
            _budgetSummaryView.BudgetSummaries = CreateBudgetSummaries(expenseCategories, accountEntities);
        }

        private List<BudgetSummary> CreateBudgetSummaries(List<ExpenseCategory> expenseCategories, IEnumerable<AccountEntity> accountEntities) 
        {
            var budgetSummaries = new List<BudgetSummary>();

            foreach (var expenseCategory in expenseCategories)
            {
                int? expense = 0;
                var accounts = accountEntities.ToList().FindAll(x => x.ExpenseCategoryId == expenseCategory.Id);
                accounts.ForEach(x => expense += x.ExpenseAmount);

                int budget = expenseCategory.Amount ?? 0;
                int actualExpense = (int)expense;
                int remaining = budget - actualExpense;

                budgetSummaries.Add(new BudgetSummary
                {
                    Category = expenseCategory.Name,
                    Budget = budget,
                    Expense = actualExpense,
                    Remaining = remaining
                });
            }

            return budgetSummaries;
        }

        public void SearchBudgetSummaries(SearchKeyword searchKeyword)
        {
            string start = searchKeyword.Start.ToString("yyyy-MM-dd");
            string end = searchKeyword.End.ToString("yyyy-MM-dd");
            var accounts = _accountRepository.GetBetweenDate(start, end);
            var expenseCategories = _budgetSummaryView.ExpenseCategories;
            _budgetSummaryView.BudgetSummaries = CreateBudgetSummaries(expenseCategories, accounts);
            _budgetSummaryView.StartDate = $"시작일: {start}";
            _budgetSummaryView.EndDate = $"종료일: {end}";
        }
    }
}
